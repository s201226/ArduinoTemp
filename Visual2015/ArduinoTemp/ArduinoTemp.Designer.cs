namespace ArduinoTemp
{
    partial class ArduinoTemp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.textBoxOutMain = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.USB = new System.IO.Ports.SerialPort(this.components);
            this.labelTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(71, 32);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(89, 12);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(71, 32);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Measure";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTemp.Location = new System.Drawing.Point(152, 48);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.ReadOnly = true;
            this.textBoxTemp.Size = new System.Drawing.Size(173, 27);
            this.textBoxTemp.TabIndex = 2;
            this.textBoxTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxOutMain
            // 
            this.textBoxOutMain.Location = new System.Drawing.Point(12, 80);
            this.textBoxOutMain.Multiline = true;
            this.textBoxOutMain.Name = "textBoxOutMain";
            this.textBoxOutMain.ReadOnly = true;
            this.textBoxOutMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutMain.Size = new System.Drawing.Size(236, 156);
            this.textBoxOutMain.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(254, 80);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(71, 32);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // USB
            // 
            this.USB.DtrEnable = true;
            this.USB.PortName = "COM3";
            this.USB.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.USB_DataReceived);
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.Location = new System.Drawing.Point(12, 47);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(140, 25);
            this.labelTemp.TabIndex = 5;
            this.labelTemp.Text = "Temperature:";
            // 
            // ArduinoTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 244);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.textBoxOutMain);
            this.Controls.Add(this.textBoxTemp);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonStart);
            this.Name = "ArduinoTemp";
            this.Text = "ArduinoTemp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxTemp;
        private System.Windows.Forms.TextBox textBoxOutMain;
        private System.Windows.Forms.Button buttonCancel;
        private System.IO.Ports.SerialPort USB;
        private System.Windows.Forms.Label labelTemp;
    }
}

