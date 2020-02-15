namespace EA_PS_2342_1B_Control
{
    partial class OutputNode
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBox_outputOnOff = new System.Windows.Forms.CheckBox();
            this.label_outputTitle = new System.Windows.Forms.Label();
            this.label_outputOnOff = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_outputPreset = new System.Windows.Forms.CheckBox();
            this.label_voltage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_controlMode = new System.Windows.Forms.Label();
            this.label_outputStateOnOff = new System.Windows.Forms.Label();
            this.label_titleCurrent = new System.Windows.Forms.Label();
            this.label_titleVoltage = new System.Windows.Forms.Label();
            this.label_current = new System.Windows.Forms.Label();
            this.label_titleSeparator = new System.Windows.Forms.Label();
            this.numericUpDown_Voltage = new System.Windows.Forms.NumericUpDown();
            this.radioButton_remote = new System.Windows.Forms.RadioButton();
            this.radioButton_manual = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer_dataAcquisition = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_lastSetVoltage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_lastSetVoltageTimeStamp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_deviceDesignation = new System.Windows.Forms.TextBox();
            this.toolTip_controlNode = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_voltageIncrement = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button_preset5Volts = new System.Windows.Forms.Button();
            this.button_preset24Volts = new System.Windows.Forms.Button();
            this.button_preset42Volts = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Voltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_voltageIncrement)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_outputOnOff
            // 
            this.checkBox_outputOnOff.AutoCheck = false;
            this.checkBox_outputOnOff.AutoSize = true;
            this.checkBox_outputOnOff.Location = new System.Drawing.Point(279, 179);
            this.checkBox_outputOnOff.Name = "checkBox_outputOnOff";
            this.checkBox_outputOnOff.Size = new System.Drawing.Size(15, 14);
            this.checkBox_outputOnOff.TabIndex = 3;
            this.toolTip_controlNode.SetToolTip(this.checkBox_outputOnOff, "Activate/Deactivate Output.");
            this.checkBox_outputOnOff.UseVisualStyleBackColor = true;
            this.checkBox_outputOnOff.Click += new System.EventHandler(this.checkBox_outputOnOff_Click);
            // 
            // label_outputTitle
            // 
            this.label_outputTitle.AutoSize = true;
            this.label_outputTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outputTitle.Location = new System.Drawing.Point(129, 157);
            this.label_outputTitle.Name = "label_outputTitle";
            this.label_outputTitle.Size = new System.Drawing.Size(65, 16);
            this.label_outputTitle.TabIndex = 1;
            this.label_outputTitle.Text = "Output X";
            // 
            // label_outputOnOff
            // 
            this.label_outputOnOff.AutoSize = true;
            this.label_outputOnOff.Location = new System.Drawing.Point(262, 164);
            this.label_outputOnOff.Name = "label_outputOnOff";
            this.label_outputOnOff.Size = new System.Drawing.Size(46, 13);
            this.label_outputOnOff.TabIndex = 2;
            this.label_outputOnOff.Text = "On / Off";
            this.toolTip_controlNode.SetToolTip(this.label_outputOnOff, "Activate/Deactivate Output.");
            this.label_outputOnOff.Click += new System.EventHandler(this.label_outputOnOff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preset";
            // 
            // checkBox_outputPreset
            // 
            this.checkBox_outputPreset.AutoSize = true;
            this.checkBox_outputPreset.Location = new System.Drawing.Point(31, 179);
            this.checkBox_outputPreset.Name = "checkBox_outputPreset";
            this.checkBox_outputPreset.Size = new System.Drawing.Size(15, 14);
            this.checkBox_outputPreset.TabIndex = 0;
            this.checkBox_outputPreset.UseVisualStyleBackColor = true;
            // 
            // label_voltage
            // 
            this.label_voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_voltage.ForeColor = System.Drawing.Color.White;
            this.label_voltage.Location = new System.Drawing.Point(0, 15);
            this.label_voltage.Name = "label_voltage";
            this.label_voltage.Size = new System.Drawing.Size(139, 39);
            this.label_voltage.TabIndex = 3;
            this.label_voltage.Text = "0.00";
            this.label_voltage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_controlMode);
            this.panel1.Controls.Add(this.label_outputStateOnOff);
            this.panel1.Controls.Add(this.label_titleCurrent);
            this.panel1.Controls.Add(this.label_titleVoltage);
            this.panel1.Controls.Add(this.label_current);
            this.panel1.Controls.Add(this.label_voltage);
            this.panel1.Controls.Add(this.label_titleSeparator);
            this.panel1.Location = new System.Drawing.Point(9, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 93);
            this.panel1.TabIndex = 4;
            // 
            // label_controlMode
            // 
            this.label_controlMode.AutoSize = true;
            this.label_controlMode.ForeColor = System.Drawing.Color.White;
            this.label_controlMode.Location = new System.Drawing.Point(216, 75);
            this.label_controlMode.Name = "label_controlMode";
            this.label_controlMode.Size = new System.Drawing.Size(42, 13);
            this.label_controlMode.TabIndex = 3;
            this.label_controlMode.Text = "Manual";
            // 
            // label_outputStateOnOff
            // 
            this.label_outputStateOnOff.AutoSize = true;
            this.label_outputStateOnOff.ForeColor = System.Drawing.Color.White;
            this.label_outputStateOnOff.Location = new System.Drawing.Point(278, 75);
            this.label_outputStateOnOff.Name = "label_outputStateOnOff";
            this.label_outputStateOnOff.Size = new System.Drawing.Size(21, 13);
            this.label_outputStateOnOff.TabIndex = 3;
            this.label_outputStateOnOff.Text = "Off";
            // 
            // label_titleCurrent
            // 
            this.label_titleCurrent.AutoSize = true;
            this.label_titleCurrent.ForeColor = System.Drawing.Color.White;
            this.label_titleCurrent.Location = new System.Drawing.Point(223, 53);
            this.label_titleCurrent.Name = "label_titleCurrent";
            this.label_titleCurrent.Size = new System.Drawing.Size(41, 13);
            this.label_titleCurrent.TabIndex = 3;
            this.label_titleCurrent.Text = "Current";
            // 
            // label_titleVoltage
            // 
            this.label_titleVoltage.AutoSize = true;
            this.label_titleVoltage.ForeColor = System.Drawing.Color.White;
            this.label_titleVoltage.Location = new System.Drawing.Point(52, 53);
            this.label_titleVoltage.Name = "label_titleVoltage";
            this.label_titleVoltage.Size = new System.Drawing.Size(43, 13);
            this.label_titleVoltage.TabIndex = 3;
            this.label_titleVoltage.Text = "Voltage";
            // 
            // label_current
            // 
            this.label_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_current.ForeColor = System.Drawing.Color.White;
            this.label_current.Location = new System.Drawing.Point(165, 15);
            this.label_current.Name = "label_current";
            this.label_current.Size = new System.Drawing.Size(139, 39);
            this.label_current.TabIndex = 3;
            this.label_current.Text = "0.00";
            this.label_current.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_titleSeparator
            // 
            this.label_titleSeparator.AutoSize = true;
            this.label_titleSeparator.ForeColor = System.Drawing.Color.White;
            this.label_titleSeparator.Location = new System.Drawing.Point(-3, 56);
            this.label_titleSeparator.Name = "label_titleSeparator";
            this.label_titleSeparator.Size = new System.Drawing.Size(313, 13);
            this.label_titleSeparator.TabIndex = 6;
            this.label_titleSeparator.Text = "___________________________________________________";
            // 
            // numericUpDown_Voltage
            // 
            this.numericUpDown_Voltage.DecimalPlaces = 2;
            this.numericUpDown_Voltage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_Voltage.Location = new System.Drawing.Point(133, 228);
            this.numericUpDown_Voltage.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.numericUpDown_Voltage.Name = "numericUpDown_Voltage";
            this.numericUpDown_Voltage.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown_Voltage.TabIndex = 2;
            this.numericUpDown_Voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip_controlNode.SetToolTip(this.numericUpDown_Voltage, "Press \"Enter\" to apply value");
            this.numericUpDown_Voltage.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_Voltage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_Voltage_KeyDown);
            // 
            // radioButton_remote
            // 
            this.radioButton_remote.AutoSize = true;
            this.radioButton_remote.Location = new System.Drawing.Point(185, 24);
            this.radioButton_remote.Name = "radioButton_remote";
            this.radioButton_remote.Size = new System.Drawing.Size(57, 17);
            this.radioButton_remote.TabIndex = 6;
            this.radioButton_remote.Text = "remote";
            this.radioButton_remote.UseVisualStyleBackColor = true;
            this.radioButton_remote.CheckedChanged += new System.EventHandler(this.radioButton_remote_CheckedChanged);
            // 
            // radioButton_manual
            // 
            this.radioButton_manual.AutoSize = true;
            this.radioButton_manual.Checked = true;
            this.radioButton_manual.Location = new System.Drawing.Point(116, 24);
            this.radioButton_manual.Name = "radioButton_manual";
            this.radioButton_manual.Size = new System.Drawing.Size(59, 17);
            this.radioButton_manual.TabIndex = 6;
            this.radioButton_manual.TabStop = true;
            this.radioButton_manual.Text = "manual";
            this.radioButton_manual.UseVisualStyleBackColor = true;
            this.radioButton_manual.CheckedChanged += new System.EventHandler(this.radioButton_manual_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Control Mode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Desired Voltage: ";
            // 
            // timer_dataAcquisition
            // 
            this.timer_dataAcquisition.Enabled = true;
            this.timer_dataAcquisition.Interval = 50;
            this.timer_dataAcquisition.Tick += new System.EventHandler(this.timer_dataAcquisition_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "[V]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last Set Value:";
            // 
            // label_lastSetVoltage
            // 
            this.label_lastSetVoltage.AutoSize = true;
            this.label_lastSetVoltage.Location = new System.Drawing.Point(160, 279);
            this.label_lastSetVoltage.Name = "label_lastSetVoltage";
            this.label_lastSetVoltage.Size = new System.Drawing.Size(27, 13);
            this.label_lastSetVoltage.TabIndex = 1;
            this.label_lastSetVoltage.Text = "N/A";
            this.label_lastSetVoltage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip_controlNode.SetToolTip(this.label_lastSetVoltage, "Shows the last set value sent to the PSU. N/A if no value was sent yet. ");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "[V]";
            // 
            // label_lastSetVoltageTimeStamp
            // 
            this.label_lastSetVoltageTimeStamp.AutoSize = true;
            this.label_lastSetVoltageTimeStamp.Location = new System.Drawing.Point(212, 279);
            this.label_lastSetVoltageTimeStamp.Name = "label_lastSetVoltageTimeStamp";
            this.label_lastSetVoltageTimeStamp.Size = new System.Drawing.Size(82, 13);
            this.label_lastSetVoltageTimeStamp.TabIndex = 1;
            this.label_lastSetVoltageTimeStamp.Text = "(HH:mm:ss:mss)";
            this.label_lastSetVoltageTimeStamp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip_controlNode.SetToolTip(this.label_lastSetVoltageTimeStamp, "Timestamp of most recent voltage value change.");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Device Designation:";
            // 
            // textBox_deviceDesignation
            // 
            this.textBox_deviceDesignation.Location = new System.Drawing.Point(116, 4);
            this.textBox_deviceDesignation.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_deviceDesignation.Name = "textBox_deviceDesignation";
            this.textBox_deviceDesignation.Size = new System.Drawing.Size(200, 20);
            this.textBox_deviceDesignation.TabIndex = 1;
            this.toolTip_controlNode.SetToolTip(this.textBox_deviceDesignation, "Device designator (e.g. PCBA Resource Handling BC3) can be entered here. ");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Desired Increment:";
            // 
            // numericUpDown_voltageIncrement
            // 
            this.numericUpDown_voltageIncrement.DecimalPlaces = 1;
            this.numericUpDown_voltageIncrement.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_voltageIncrement.Location = new System.Drawing.Point(133, 202);
            this.numericUpDown_voltageIncrement.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_voltageIncrement.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_voltageIncrement.Name = "numericUpDown_voltageIncrement";
            this.numericUpDown_voltageIncrement.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown_voltageIncrement.TabIndex = 5;
            this.numericUpDown_voltageIncrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_voltageIncrement.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_voltageIncrement.ValueChanged += new System.EventHandler(this.numericUpDown_voltageIncrement_ValueChanged);
            this.numericUpDown_voltageIncrement.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_Voltage_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "[V]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Presets:";
            // 
            // button_preset5Volts
            // 
            this.button_preset5Volts.Location = new System.Drawing.Point(133, 250);
            this.button_preset5Volts.Name = "button_preset5Volts";
            this.button_preset5Volts.Size = new System.Drawing.Size(42, 23);
            this.button_preset5Volts.TabIndex = 7;
            this.button_preset5Volts.Text = "5V";
            this.button_preset5Volts.UseVisualStyleBackColor = true;
            this.button_preset5Volts.Click += new System.EventHandler(this.button_preset5Volts_Click);
            // 
            // button_preset24Volts
            // 
            this.button_preset24Volts.Location = new System.Drawing.Point(181, 250);
            this.button_preset24Volts.Name = "button_preset24Volts";
            this.button_preset24Volts.Size = new System.Drawing.Size(42, 23);
            this.button_preset24Volts.TabIndex = 7;
            this.button_preset24Volts.Text = "24V";
            this.button_preset24Volts.UseVisualStyleBackColor = true;
            this.button_preset24Volts.Click += new System.EventHandler(this.button_preset24Volts_Click);
            // 
            // button_preset42Volts
            // 
            this.button_preset42Volts.Location = new System.Drawing.Point(229, 250);
            this.button_preset42Volts.Name = "button_preset42Volts";
            this.button_preset42Volts.Size = new System.Drawing.Size(42, 23);
            this.button_preset42Volts.TabIndex = 7;
            this.button_preset42Volts.Text = "42V";
            this.button_preset42Volts.UseVisualStyleBackColor = true;
            this.button_preset42Volts.Click += new System.EventHandler(this.button_preset42Volts_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(4, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 103);
            this.panel2.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.Location = new System.Drawing.Point(4, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(313, 9);
            this.label11.TabIndex = 1;
            this.label11.Text = "_____________________________________________________________________________";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(255, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(59, 39);
            this.panel3.TabIndex = 9;
            this.panel3.Click += new System.EventHandler(this.checkBox_outputOnOff_Click);
            // 
            // OutputNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button_preset42Volts);
            this.Controls.Add(this.button_preset24Volts);
            this.Controls.Add(this.button_preset5Volts);
            this.Controls.Add(this.textBox_deviceDesignation);
            this.Controls.Add(this.radioButton_manual);
            this.Controls.Add(this.radioButton_remote);
            this.Controls.Add(this.numericUpDown_voltageIncrement);
            this.Controls.Add(this.numericUpDown_Voltage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_outputOnOff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_lastSetVoltage);
            this.Controls.Add(this.label_lastSetVoltageTimeStamp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_outputTitle);
            this.Controls.Add(this.checkBox_outputPreset);
            this.Controls.Add(this.checkBox_outputOnOff);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Name = "OutputNode";
            this.Size = new System.Drawing.Size(322, 299);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Voltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_voltageIncrement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_outputOnOff;
        private System.Windows.Forms.Label label_outputTitle;
        private System.Windows.Forms.Label label_outputOnOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_outputPreset;
        private System.Windows.Forms.Label label_voltage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_titleVoltage;
        private System.Windows.Forms.Label label_titleCurrent;
        private System.Windows.Forms.Label label_current;
        private System.Windows.Forms.NumericUpDown numericUpDown_Voltage;
        private System.Windows.Forms.Label label_outputStateOnOff;
        private System.Windows.Forms.Label label_titleSeparator;
        private System.Windows.Forms.Label label_controlMode;
        private System.Windows.Forms.RadioButton radioButton_remote;
        private System.Windows.Forms.RadioButton radioButton_manual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer_dataAcquisition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_lastSetVoltage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_lastSetVoltageTimeStamp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_deviceDesignation;
        private System.Windows.Forms.ToolTip toolTip_controlNode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_voltageIncrement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_preset5Volts;
        private System.Windows.Forms.Button button_preset24Volts;
        private System.Windows.Forms.Button button_preset42Volts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
    }
}
