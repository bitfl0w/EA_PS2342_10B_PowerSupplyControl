using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace NS_Device_EA_PS_2342_10B
{
    public class Device_EA_PS_2342_10B
    {
        // structs
        public struct statusResponse
        {
            public int nodeId;
            public int objectId;
            public int controlMode;
            public bool outputState;
            public int controllerState;
            public bool trackingState;
            public bool ovpState;
            public bool ocpState;
            public bool oppState;
            public bool otpState;
            public float actualVoltage;
            public float actualCurrent;
        }

        // constants
        const string ERROR_STRING = "-1";
        const int MAX_VOLTAGE = 42; // Volts
        const int MAX_CURRENT = 10; // Amps

        // fields
        //public int nodeId { get; set; }
        private SerialPort mySerialPort;
        public decimal lastSetVoltage { get; set; }
        private statusResponse statusNode1 { get; set; }
        private statusResponse statusNode2 { get; set; }

        // constructor
        public Device_EA_PS_2342_10B(SerialPort comInterface)
        {
            setSerialPort(comInterface);
            //mySerialPort = comInterface;
            lastSetVoltage = 0;
        }

        // methods
        private void setSerialPort(SerialPort serialPort)
        {
            mySerialPort = serialPort;
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytes = mySerialPort.BytesToRead;
            if(bytes > 0)
            {
                byte[] buffer = new byte[bytes];
                mySerialPort.Read(buffer, 0, bytes);
                if (buffer[0] == 0x85)
                {
                    decodeIncomingData(buffer);
                }
            }
        }

        private statusResponse decodeIncomingData(byte[] buffer)
        {
            // Mögliche Antwort: 85 00 47 01 01 64 00 1E 00 01 50

            // create response variable
            statusResponse rsp = new statusResponse();
            
            int bytesToRead = buffer[0] & 0b000_1111;
            rsp.nodeId = buffer[1] + 1;
            rsp.objectId = buffer[2];
            rsp.controlMode = buffer[3] & 0b0000_0011;
            rsp.outputState = Convert.ToBoolean(buffer[4] & 0b0000_0001);
            rsp.controllerState = buffer[3] & 0b0000_0110;
            rsp.trackingState = Convert.ToBoolean(buffer[3] & 0b0000_1000);
            rsp.ovpState = Convert.ToBoolean(buffer[3] & 0b0001_0000);
            rsp.ocpState = Convert.ToBoolean(buffer[3] & 0b0010_0000);
            rsp.oppState = Convert.ToBoolean(buffer[3] & 0b0100_0000);
            rsp.otpState = Convert.ToBoolean(buffer[3] & 0b1000_0000);

            int receivedVoltageValue = Convert.ToInt16("0x" + buffer[5].ToString("X2") + buffer[6].ToString("X2"), 16);
            int receivedCurrentValue = Convert.ToInt16("0x" + buffer[7].ToString("X2") + buffer[8].ToString("X2"), 16);

            // convert to actual voltage and round last digit to nearest five (seems to be done this way on the PSU itself)
            rsp.actualVoltage = (float)(Math.Round(((float)receivedVoltageValue * MAX_VOLTAGE / 256) / 5.0) * 5) / 100;
            rsp.actualCurrent = (float)receivedCurrentValue * MAX_CURRENT / 25600;

            if(rsp.nodeId == 1)
            {
                statusNode1 = rsp;
            } else
            {
                statusNode2 = rsp;
            }
            return rsp;
        }

        private void generateAndSendFullyQualifiedCommand(string cmdStrWithoutNodeIdAndCrc, int nodeId)
        {
            // replace node placeholders with desired node
            string cmdStr = cmdStrWithoutNodeIdAndCrc.Replace("__", (nodeId - 1).ToString("00"));

            // split up string to calculate crc
            string[] splittedCmdString = cmdStr.Split(' ');
            int[] ints = new int[splittedCmdString.Length];
            int crcSum = 0;

            for (int i = 0; i < splittedCmdString.Length; i++)
            {
                crcSum += Convert.ToInt16(splittedCmdString[i], 16);
            }

            string crcStr = crcSum.ToString("X4");  // this is the four digit full crc
            cmdStr += " " + crcStr.Substring(0, 2) + " " + crcStr.Substring(2, 2);  // generate full string

            // convert the string array to a bytes array to send it afterwards
            byte[] bytes = cmdStr.Split(' ').Select(s => Convert.ToByte(s, 16)).ToArray();
            try
            {
                mySerialPort.Write(bytes, 0, bytes.Length);
            }
            catch(Exception exc)
            {
                //throw exc;
            }
        }

        public void activateOutput(int nodeId)
        {
            generateAndSendFullyQualifiedCommand("F1 __ 36 01 01", nodeId);         
        }

        public void deactivateOutput(int nodeId)
        {
            generateAndSendFullyQualifiedCommand("F1 __ 36 01 00", nodeId);
        }

        public void switchModeToManual(int nodeId)
        {
            generateAndSendFullyQualifiedCommand("F1 __ 36 10 00", nodeId);
        }

        public void switchModeToRemote(int nodeId)
        {
            generateAndSendFullyQualifiedCommand("F1 __ 36 10 10", nodeId);
        }

        public void setVoltage(decimal voltage, int nodeId)
        {
            string voltageStr = Convert.ToInt16((voltage / MAX_VOLTAGE) * 100 * 256).ToString("X4");
            string cmdString = "F1 __ 32 " + voltageStr.Substring(0, 2) + " " + voltageStr.Substring(2, 2);
            generateAndSendFullyQualifiedCommand(cmdString, nodeId);
        }

        public void sendStatusRequst(int nodeId)
        {
            generateAndSendFullyQualifiedCommand("75 __ 47", nodeId);
        }

        public statusResponse getStatus(int nodeId)
        {
            if (nodeId == 1)
            {
                return statusNode1;
            }
            else
            {
                return statusNode2;
            }
        }
    }
}
