namespace SimCorp.IMS.WindowsFormsAppSMS
{
    partial class FormSMS
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
            this.MessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.FormattingComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MessageRichTextBox
            // 
            this.MessageRichTextBox.Location = new System.Drawing.Point(12, 61);
            this.MessageRichTextBox.Name = "MessageRichTextBox";
            this.MessageRichTextBox.ReadOnly = true;
            this.MessageRichTextBox.Size = new System.Drawing.Size(365, 278);
            this.MessageRichTextBox.TabIndex = 0;
            this.MessageRichTextBox.Text = "";
            // 
            // FormattingComboBox
            // 
            this.FormattingComboBox.FormattingEnabled = true;
            this.FormattingComboBox.Items.AddRange(new object[] {
            "None",
            "Start with DateTime",
            "End with DateTime",
            "Lowercase",
            "Uppercase"});
            this.FormattingComboBox.Location = new System.Drawing.Point(13, 13);
            this.FormattingComboBox.Name = "FormattingComboBox";
            this.FormattingComboBox.Size = new System.Drawing.Size(121, 21);
            this.FormattingComboBox.TabIndex = 1;
            this.FormattingComboBox.Text = "Select Formatting";
            this.FormattingComboBox.SelectedIndexChanged += new System.EventHandler(this.FormattingComboBox_SelectedIndexChanged);
            // 
            // FormSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 351);
            this.Controls.Add(this.FormattingComboBox);
            this.Controls.Add(this.MessageRichTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSMS";
            this.Text = "SMS";
            this.Closed += new System.EventHandler(this.FormSMSOnClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox MessageRichTextBox;
        private System.Windows.Forms.ComboBox FormattingComboBox;
    }
}

