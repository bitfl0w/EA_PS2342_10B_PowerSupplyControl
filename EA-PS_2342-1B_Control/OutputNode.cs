using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.IO.Ports;

namespace EA_PS_2342_1B_Control {
    public partial class OutputNode : UserControl {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);

        FontFamily ff;
        Font font;
        private int nodeId;
        Device_EA_PS_2342_10B psuDev;
        bool getStatusEnabled;
        //bool initialStatusRequest;

        // constructor
        public OutputNode() {
            InitializeComponent();
            loadFont();
            allocFont(font, this.label_current, 26);
            allocFont(font, this.label_voltage, 26);
            getStatusEnabled = false;
            //initialStatusRequest = true;
        }

        // font loader
        private void loadFont() {
            byte[] fontArray = EA_PS_2342_1B_Control.Properties.Resources.DSEG7Modern_Italic;
            int dataLength = EA_PS_2342_1B_Control.Properties.Resources.DSEG7Modern_Italic.Length;

            IntPtr ptr = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontArray, 0, ptr, dataLength);    // copies the fontArray from idx 0 to ptr

            uint cFonts = 0;
            AddFontMemResourceEx(ptr, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddMemoryFont(ptr, dataLength);
            Marshal.FreeCoTaskMem(ptr);
            ff = pfc.Families[0];
            font = new Font(ff, 15f, FontStyle.Italic);
        }

        private void allocFont(Font f, Control c, float size) {
            FontStyle fs = FontStyle.Italic;
            c.Font = new Font(ff, size, fs);
        }

        public void setNodeId(int nodeId) {
            this.nodeId = nodeId;
            label_outputTitle.Text = "Output " + nodeId;
        }

        public void addPsDevice(Device_EA_PS_2342_10B psDev) {
            this.psuDev = psDev;
            // per default, manual mode is active
            changeViewToManual();
            psDev.switchModeToManual(nodeId);
        }

        private void actOnOutputStateChange(bool labelClick) {
            if(!psuDev.getStatus(nodeId).outputState) {
                psuDev.activateOutput(nodeId);
            } else {
                psuDev.deactivateOutput(nodeId);
            }
        }

        private void radioButton_remote_CheckedChanged(object sender, EventArgs e) {
            if(radioButton_remote.Checked) {
                setControlToRemote();
                getStatusEnabled = true;
            } else {
                setControlToManual();
                getStatusEnabled = false;
            }
        }

        public void setControlToRemote() {
            psuDev.switchModeToRemote(nodeId);
            changeViewToRemote();
        }

        public void setControlToManual() {
            psuDev.switchModeToManual(nodeId);
            changeViewToManual();
        }
        private void radioButton_manual_CheckedChanged(object sender, EventArgs e) {
            if(radioButton_remote.Checked) {
                setControlToRemote();
                getStatusEnabled = true;
            } else {
                setControlToManual();
                getStatusEnabled = false;
            }
        }

        private void changeViewToRemote() {
            label_controlMode.Text = "Remote";
            checkBox_outputPreset.Enabled = true;
            checkBox_outputOnOff.Enabled = true;
            numericUpDown_Voltage.Enabled = true;
            numericUpDown_voltageIncrement.Enabled = true;
            button_preset5Volts.Enabled = true;
            button_preset24Volts.Enabled = true;
            button_preset42Volts.Enabled = true;
        }

        private void changeViewToManual() {
            label_controlMode.Text = "Manual";
            checkBox_outputPreset.Enabled = false;
            checkBox_outputOnOff.Enabled = false;
            numericUpDown_Voltage.Enabled = false;
            numericUpDown_voltageIncrement.Enabled = false;
            button_preset5Volts.Enabled = false;
            button_preset24Volts.Enabled = false;
            button_preset42Volts.Enabled = false;
        }

        private void setVoltage(decimal desiredVoltage) {
            if((float)desiredVoltage > 26.4) {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("The desired voltage exceeds 26.4 V (24 V + 10%). \n" +
                                "Do you really want to apply this voltage to Output " + nodeId + "?",
                                "Verifiy selection",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);
                if(dr == DialogResult.No) {
                    return;
                }
            }

            // set voltage on node
            psuDev.setVoltage(desiredVoltage, nodeId);
            label_lastSetVoltageTimeStamp.Text = "(" + DateTime.Now.ToString("HH:mm:ss.fff", System.Globalization.DateTimeFormatInfo.InvariantInfo) + ")";

            psuDev.lastSetVoltage = desiredVoltage;
            label_lastSetVoltage.Text = desiredVoltage.ToString("0.00");
            numericUpDown_Voltage.Value = desiredVoltage;
        }

        private void numericUpDown_Voltage_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyValue == (char)Keys.Enter) {
                setVoltage(numericUpDown_Voltage.Value);
                e.Handled = e.SuppressKeyPress = true;  // surpress sound generated by keypress (enter)
            }
        }

        private void label_outputOnOff_Click(object sender, EventArgs e) {
            actOnOutputStateChange(true);
        }

        private void checkBox_outputOnOff_Click(object sender, EventArgs e) {
            actOnOutputStateChange(false);
        }

        private void numericUpDown_voltageIncrement_ValueChanged(object sender, EventArgs e) {
            numericUpDown_Voltage.Increment = numericUpDown_voltageIncrement.Value;
        }

        private void timer_dataAcquisition_Tick(object sender, EventArgs e) {
            if(getStatusEnabled) {
                psuDev.sendStatusRequst(nodeId);
                updatePsuData();
            }
        }

        private void updatePsuData() {
            Device_EA_PS_2342_10B.statusResponse rsp = new Device_EA_PS_2342_10B.statusResponse();
            rsp = psuDev.getStatus(nodeId);
            if(rsp.outputState) {
                label_outputStateOnOff.Text = "On";
            } else {
                label_outputStateOnOff.Text = "Off";
            }
            checkBox_outputOnOff.Checked = rsp.outputState;

            // cosmetics
            string format = "0.00";
            if(rsp.actualCurrent > 9.99) {
                format = "00.00";
            }
            label_current.Text = rsp.actualCurrent.ToString(format);
            format = "0.00";
            if(rsp.actualVoltage > 9.99) {
                format = "00.00";
            }
            label_voltage.Text = rsp.actualVoltage.ToString(format);

        }

        private void button_preset5Volts_Click(object sender, EventArgs e) {
            setVoltage(new decimal(5));
        }

        private void button_preset24Volts_Click(object sender, EventArgs e) {
            setVoltage(new decimal(24));
        }

        private void button_preset42Volts_Click(object sender, EventArgs e) {
            setVoltage(new decimal(42));
        }
    }
}
