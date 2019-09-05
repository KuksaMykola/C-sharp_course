namespace SimCorp.IMS.WindowsFormsApp
{
    partial class MainForm
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
            this.PlayBackGoupBox = new System.Windows.Forms.GroupBox();
            this.PlaybackApplyButton = new System.Windows.Forms.Button();
            this.UnofficialHeadsetRadioButton = new System.Windows.Forms.RadioButton();
            this.SamsungHeadsetRadioButton = new System.Windows.Forms.RadioButton();
            this.iPhoneHeadSetRadioButton = new System.Windows.Forms.RadioButton();
            this.ExternalSpeakerRadioButton = new System.Windows.Forms.RadioButton();
            this.ChargerDevicesGroupBox = new System.Windows.Forms.GroupBox();
            this.ChargerApplyButton = new System.Windows.Forms.Button();
            this.CarChargerRadioButton = new System.Windows.Forms.RadioButton();
            this.ContactLessChargerRadioButton = new System.Windows.Forms.RadioButton();
            this.LaptopCableChargerRadioButton = new System.Windows.Forms.RadioButton();
            this.PowerBankRadioButton = new System.Windows.Forms.RadioButton();
            this.SocetChargerRadioButton = new System.Windows.Forms.RadioButton();
            this.OutTextBox = new System.Windows.Forms.TextBox();
            this.CleanButton = new System.Windows.Forms.Button();
            this.PlayBackGoupBox.SuspendLayout();
            this.ChargerDevicesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayBackGoupBox
            // 
            this.PlayBackGoupBox.Controls.Add(this.PlaybackApplyButton);
            this.PlayBackGoupBox.Controls.Add(this.UnofficialHeadsetRadioButton);
            this.PlayBackGoupBox.Controls.Add(this.SamsungHeadsetRadioButton);
            this.PlayBackGoupBox.Controls.Add(this.iPhoneHeadSetRadioButton);
            this.PlayBackGoupBox.Controls.Add(this.ExternalSpeakerRadioButton);
            this.PlayBackGoupBox.Location = new System.Drawing.Point(12, 12);
            this.PlayBackGoupBox.Name = "PlayBackGoupBox";
            this.PlayBackGoupBox.Size = new System.Drawing.Size(189, 147);
            this.PlayBackGoupBox.TabIndex = 0;
            this.PlayBackGoupBox.TabStop = false;
            this.PlayBackGoupBox.Text = "Playback components";
            // 
            // PlaybackApplyButton
            // 
            this.PlaybackApplyButton.Location = new System.Drawing.Point(108, 115);
            this.PlaybackApplyButton.Name = "PlaybackApplyButton";
            this.PlaybackApplyButton.Size = new System.Drawing.Size(75, 23);
            this.PlaybackApplyButton.TabIndex = 4;
            this.PlaybackApplyButton.Text = "Apply";
            this.PlaybackApplyButton.UseVisualStyleBackColor = true;
            this.PlaybackApplyButton.Click += new System.EventHandler(this.PlaybackApplyButtonOnClick);
            // 
            // UnofficialHeadsetRadioButton
            // 
            this.UnofficialHeadsetRadioButton.AutoSize = true;
            this.UnofficialHeadsetRadioButton.Location = new System.Drawing.Point(7, 92);
            this.UnofficialHeadsetRadioButton.Name = "UnofficialHeadsetRadioButton";
            this.UnofficialHeadsetRadioButton.Size = new System.Drawing.Size(146, 17);
            this.UnofficialHeadsetRadioButton.TabIndex = 3;
            this.UnofficialHeadsetRadioButton.TabStop = true;
            this.UnofficialHeadsetRadioButton.Text = "Unofficial Phone Headset";
            this.UnofficialHeadsetRadioButton.UseVisualStyleBackColor = true;
            // 
            // SamsungHeadsetRadioButton
            // 
            this.SamsungHeadsetRadioButton.AutoSize = true;
            this.SamsungHeadsetRadioButton.Location = new System.Drawing.Point(7, 68);
            this.SamsungHeadsetRadioButton.Name = "SamsungHeadsetRadioButton";
            this.SamsungHeadsetRadioButton.Size = new System.Drawing.Size(112, 17);
            this.SamsungHeadsetRadioButton.TabIndex = 2;
            this.SamsungHeadsetRadioButton.TabStop = true;
            this.SamsungHeadsetRadioButton.Text = "Samsung Headset";
            this.SamsungHeadsetRadioButton.UseVisualStyleBackColor = true;
            // 
            // iPhoneHeadSetRadioButton
            // 
            this.iPhoneHeadSetRadioButton.AutoSize = true;
            this.iPhoneHeadSetRadioButton.Location = new System.Drawing.Point(7, 44);
            this.iPhoneHeadSetRadioButton.Name = "iPhoneHeadSetRadioButton";
            this.iPhoneHeadSetRadioButton.Size = new System.Drawing.Size(103, 17);
            this.iPhoneHeadSetRadioButton.TabIndex = 1;
            this.iPhoneHeadSetRadioButton.TabStop = true;
            this.iPhoneHeadSetRadioButton.Text = "iPhone HeadSet";
            this.iPhoneHeadSetRadioButton.UseVisualStyleBackColor = true;
            // 
            // ExternalSpeakerRadioButton
            // 
            this.ExternalSpeakerRadioButton.AutoSize = true;
            this.ExternalSpeakerRadioButton.Checked = true;
            this.ExternalSpeakerRadioButton.Location = new System.Drawing.Point(7, 20);
            this.ExternalSpeakerRadioButton.Name = "ExternalSpeakerRadioButton";
            this.ExternalSpeakerRadioButton.Size = new System.Drawing.Size(140, 17);
            this.ExternalSpeakerRadioButton.TabIndex = 0;
            this.ExternalSpeakerRadioButton.TabStop = true;
            this.ExternalSpeakerRadioButton.Text = "External Phone Speaker";
            this.ExternalSpeakerRadioButton.UseVisualStyleBackColor = true;
            // 
            // ChargerDevicesGroupBox
            // 
            this.ChargerDevicesGroupBox.Controls.Add(this.ChargerApplyButton);
            this.ChargerDevicesGroupBox.Controls.Add(this.CarChargerRadioButton);
            this.ChargerDevicesGroupBox.Controls.Add(this.ContactLessChargerRadioButton);
            this.ChargerDevicesGroupBox.Controls.Add(this.LaptopCableChargerRadioButton);
            this.ChargerDevicesGroupBox.Controls.Add(this.PowerBankRadioButton);
            this.ChargerDevicesGroupBox.Controls.Add(this.SocetChargerRadioButton);
            this.ChargerDevicesGroupBox.Location = new System.Drawing.Point(234, 12);
            this.ChargerDevicesGroupBox.Name = "ChargerDevicesGroupBox";
            this.ChargerDevicesGroupBox.Size = new System.Drawing.Size(199, 147);
            this.ChargerDevicesGroupBox.TabIndex = 1;
            this.ChargerDevicesGroupBox.TabStop = false;
            this.ChargerDevicesGroupBox.Text = "Charger Devices";
            // 
            // ChargerApplyButton
            // 
            this.ChargerApplyButton.Location = new System.Drawing.Point(118, 115);
            this.ChargerApplyButton.Name = "ChargerApplyButton";
            this.ChargerApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ChargerApplyButton.TabIndex = 5;
            this.ChargerApplyButton.Text = "Apply";
            this.ChargerApplyButton.UseVisualStyleBackColor = true;
            this.ChargerApplyButton.Click += new System.EventHandler(this.ChargerApplyButtonOnClick);
            // 
            // CarChargerRadioButton
            // 
            this.CarChargerRadioButton.AutoSize = true;
            this.CarChargerRadioButton.Location = new System.Drawing.Point(6, 115);
            this.CarChargerRadioButton.Name = "CarChargerRadioButton";
            this.CarChargerRadioButton.Size = new System.Drawing.Size(81, 17);
            this.CarChargerRadioButton.TabIndex = 4;
            this.CarChargerRadioButton.TabStop = true;
            this.CarChargerRadioButton.Text = "Car Charger";
            this.CarChargerRadioButton.UseVisualStyleBackColor = true;
            // 
            // ContactLessChargerRadioButton
            // 
            this.ContactLessChargerRadioButton.AutoSize = true;
            this.ContactLessChargerRadioButton.Location = new System.Drawing.Point(7, 91);
            this.ContactLessChargerRadioButton.Name = "ContactLessChargerRadioButton";
            this.ContactLessChargerRadioButton.Size = new System.Drawing.Size(127, 17);
            this.ContactLessChargerRadioButton.TabIndex = 3;
            this.ContactLessChargerRadioButton.TabStop = true;
            this.ContactLessChargerRadioButton.Text = "Contact Less Charger";
            this.ContactLessChargerRadioButton.UseVisualStyleBackColor = true;
            // 
            // LaptopCableChargerRadioButton
            // 
            this.LaptopCableChargerRadioButton.AutoSize = true;
            this.LaptopCableChargerRadioButton.Location = new System.Drawing.Point(7, 67);
            this.LaptopCableChargerRadioButton.Name = "LaptopCableChargerRadioButton";
            this.LaptopCableChargerRadioButton.Size = new System.Drawing.Size(128, 17);
            this.LaptopCableChargerRadioButton.TabIndex = 2;
            this.LaptopCableChargerRadioButton.TabStop = true;
            this.LaptopCableChargerRadioButton.Text = "Laptop Cable Charger";
            this.LaptopCableChargerRadioButton.UseVisualStyleBackColor = true;
            // 
            // PowerBankRadioButton
            // 
            this.PowerBankRadioButton.AutoSize = true;
            this.PowerBankRadioButton.Location = new System.Drawing.Point(7, 43);
            this.PowerBankRadioButton.Name = "PowerBankRadioButton";
            this.PowerBankRadioButton.Size = new System.Drawing.Size(123, 17);
            this.PowerBankRadioButton.TabIndex = 1;
            this.PowerBankRadioButton.TabStop = true;
            this.PowerBankRadioButton.Text = "Power Bank Charger";
            this.PowerBankRadioButton.UseVisualStyleBackColor = true;
            // 
            // SocetChargerRadioButton
            // 
            this.SocetChargerRadioButton.AutoSize = true;
            this.SocetChargerRadioButton.Checked = true;
            this.SocetChargerRadioButton.Location = new System.Drawing.Point(6, 19);
            this.SocetChargerRadioButton.Name = "SocetChargerRadioButton";
            this.SocetChargerRadioButton.Size = new System.Drawing.Size(93, 17);
            this.SocetChargerRadioButton.TabIndex = 0;
            this.SocetChargerRadioButton.TabStop = true;
            this.SocetChargerRadioButton.Text = "Socet Charger";
            this.SocetChargerRadioButton.UseVisualStyleBackColor = true;
            // 
            // OutTextBox
            // 
            this.OutTextBox.Location = new System.Drawing.Point(12, 166);
            this.OutTextBox.Multiline = true;
            this.OutTextBox.Name = "OutTextBox";
            this.OutTextBox.ReadOnly = true;
            this.OutTextBox.Size = new System.Drawing.Size(421, 212);
            this.OutTextBox.TabIndex = 2;
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(358, 384);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(75, 23);
            this.CleanButton.TabIndex = 3;
            this.CleanButton.Text = "Clear";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButtonOnClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 415);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.OutTextBox);
            this.Controls.Add(this.ChargerDevicesGroupBox);
            this.Controls.Add(this.PlayBackGoupBox);
            this.Name = "MainForm";
            this.Text = "Win Form App";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.PlayBackGoupBox.ResumeLayout(false);
            this.PlayBackGoupBox.PerformLayout();
            this.ChargerDevicesGroupBox.ResumeLayout(false);
            this.ChargerDevicesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PlayBackGoupBox;
        private System.Windows.Forms.RadioButton UnofficialHeadsetRadioButton;
        private System.Windows.Forms.RadioButton SamsungHeadsetRadioButton;
        private System.Windows.Forms.RadioButton iPhoneHeadSetRadioButton;
        private System.Windows.Forms.RadioButton ExternalSpeakerRadioButton;
        private System.Windows.Forms.Button PlaybackApplyButton;
        private System.Windows.Forms.GroupBox ChargerDevicesGroupBox;
        private System.Windows.Forms.Button ChargerApplyButton;
        private System.Windows.Forms.RadioButton CarChargerRadioButton;
        private System.Windows.Forms.RadioButton ContactLessChargerRadioButton;
        private System.Windows.Forms.RadioButton LaptopCableChargerRadioButton;
        private System.Windows.Forms.RadioButton PowerBankRadioButton;
        private System.Windows.Forms.RadioButton SocetChargerRadioButton;
        private System.Windows.Forms.TextBox OutTextBox;
        private System.Windows.Forms.Button CleanButton;
    }
}

