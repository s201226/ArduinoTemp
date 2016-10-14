using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoTemp
{
    public partial class ArduinoTemp : Form
    {
        private string BuffChars;
        static double V_REF = 5; //1.09
        static double GAIN = 100;

        public ArduinoTemp()
        {
            InitializeComponent();
        }

        delegate void CrossThreadUSBAppend(TextBox output, string str);
        void USBWriteAppend(TextBox output, string str)
        {
            if (output.InvokeRequired)
            {
                CrossThreadUSBAppend writer = new CrossThreadUSBAppend(USBWriteAppend);
                this.Invoke(writer, new object[] { output, str });
            }
            else
            {
                output.AppendText(str+"\n");
            }
        }

        delegate void CrossThreadUSB(TextBox output, string str);
        void USBWrite(TextBox output, string str)
        {
            if (output.InvokeRequired)
            {
                CrossThreadUSB writer = new CrossThreadUSB(USBWrite);
                this.Invoke(writer, new object[] { output, str });
            }
            else
            {
                output.Text=str;
            }
        }

        void USBDataElaboration(string str)
        {
            int ADCvalue;
            double temp,uncertainty;

            try
            {
                ADCvalue = Int32.Parse(str);
                USBWriteAppend(textBoxOutMain, ADCvalue.ToString());
                temp = GAIN * (ADCvalue / 1024.0) * V_REF - 273.15;
                uncertainty = 2.0 + GAIN * (4.0 / 1024.0) * V_REF;
                USBWrite(textBoxTemp, temp.ToString("#0.0") + " ± " + uncertainty.ToString("#0.0") + " °C");
            }
            catch (FormatException)
            {
                USBWriteAppend(textBoxOutMain, str);
            }
        }

        private void USB_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int lPos;
            string aLine;

            if (e.EventType == System.IO.Ports.SerialData.Chars)
            {
                BuffChars += USB.ReadExisting();
                lPos = BuffChars.IndexOf("\n");
                while (lPos > 0)
                {
                    aLine = BuffChars.Substring(0, lPos);

                    USBDataElaboration(aLine);

                    BuffChars = BuffChars.Substring(lPos + 1);
                    lPos = BuffChars.IndexOf("\n");
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (USB.IsOpen)
            {
                USB.Close();
                buttonSend.Enabled = false;
                buttonStart.Text = "Start";
            }
            else
            {
                USB.Open();
                buttonSend.Enabled = true;
                USB.DiscardInBuffer();
                buttonStart.Text = "Close";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxOutMain.ResetText();
            textBoxTemp.ResetText();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            USB.Write("Measure\n");
        }
    }
} /*Botteon Bertone Berto Prono*/
