namespace IMS.WindowsFormsCallList
{
    partial class CallListForm
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
            this.CallListListView = new System.Windows.Forms.ListView();
            this.UserColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserNumbeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CallTimeCcolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CallDirectionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OnOffgroupBox = new System.Windows.Forms.GroupBox();
            this.OffRadioButton = new System.Windows.Forms.RadioButton();
            this.OnRadioButton = new System.Windows.Forms.RadioButton();
            this.ParamsGroupBox = new System.Windows.Forms.GroupBox();
            this.CallDirectionComboBox = new System.Windows.Forms.ComboBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OnOffgroupBox.SuspendLayout();
            this.ParamsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CallListListView
            // 
            this.CallListListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserColumn,
            this.UserNumbeColumn,
            this.CallTimeCcolumn,
            this.CallDirectionColumn,
            this.CountColumn});
            this.CallListListView.GridLines = true;
            this.CallListListView.Location = new System.Drawing.Point(12, 145);
            this.CallListListView.Name = "CallListListView";
            this.CallListListView.Size = new System.Drawing.Size(456, 320);
            this.CallListListView.TabIndex = 0;
            this.CallListListView.UseCompatibleStateImageBehavior = false;
            this.CallListListView.View = System.Windows.Forms.View.Details;
            // 
            // UserColumn
            // 
            this.UserColumn.Text = "User";
            this.UserColumn.Width = 36;
            // 
            // UserNumbeColumn
            // 
            this.UserNumbeColumn.Text = "Phone Number";
            this.UserNumbeColumn.Width = 89;
            // 
            // CallTimeCcolumn
            // 
            this.CallTimeCcolumn.Text = "Time";
            this.CallTimeCcolumn.Width = 140;
            // 
            // CallDirectionColumn
            // 
            this.CallDirectionColumn.Text = "Direction";
            this.CallDirectionColumn.Width = 62;
            // 
            // CountColumn
            // 
            this.CountColumn.Text = "Count";
            this.CountColumn.Width = 68;
            // 
            // OnOffgroupBox
            // 
            this.OnOffgroupBox.Controls.Add(this.OffRadioButton);
            this.OnOffgroupBox.Controls.Add(this.OnRadioButton);
            this.OnOffgroupBox.Location = new System.Drawing.Point(353, 13);
            this.OnOffgroupBox.Name = "OnOffgroupBox";
            this.OnOffgroupBox.Size = new System.Drawing.Size(104, 49);
            this.OnOffgroupBox.TabIndex = 1;
            this.OnOffgroupBox.TabStop = false;
            this.OnOffgroupBox.Text = "Call Generation";
            // 
            // OffRadioButton
            // 
            this.OffRadioButton.AutoSize = true;
            this.OffRadioButton.Location = new System.Drawing.Point(54, 19);
            this.OffRadioButton.Name = "OffRadioButton";
            this.OffRadioButton.Size = new System.Drawing.Size(45, 17);
            this.OffRadioButton.TabIndex = 1;
            this.OffRadioButton.Text = "OFF";
            this.OffRadioButton.UseVisualStyleBackColor = true;
            this.OffRadioButton.CheckedChanged += new System.EventHandler(this.OffRadioButtonOnCheckedChanged);
            // 
            // OnRadioButton
            // 
            this.OnRadioButton.AutoSize = true;
            this.OnRadioButton.Checked = true;
            this.OnRadioButton.Location = new System.Drawing.Point(7, 20);
            this.OnRadioButton.Name = "OnRadioButton";
            this.OnRadioButton.Size = new System.Drawing.Size(41, 17);
            this.OnRadioButton.TabIndex = 0;
            this.OnRadioButton.TabStop = true;
            this.OnRadioButton.Text = "ON";
            this.OnRadioButton.UseVisualStyleBackColor = true;
            // 
            // ParamsGroupBox
            // 
            this.ParamsGroupBox.Controls.Add(this.label4);
            this.ParamsGroupBox.Controls.Add(this.label3);
            this.ParamsGroupBox.Controls.Add(this.label2);
            this.ParamsGroupBox.Controls.Add(this.label1);
            this.ParamsGroupBox.Controls.Add(this.CallDirectionComboBox);
            this.ParamsGroupBox.Controls.Add(this.DateTimePicker);
            this.ParamsGroupBox.Controls.Add(this.UserComboBox);
            this.ParamsGroupBox.Location = new System.Drawing.Point(12, 13);
            this.ParamsGroupBox.Name = "ParamsGroupBox";
            this.ParamsGroupBox.Size = new System.Drawing.Size(321, 126);
            this.ParamsGroupBox.TabIndex = 2;
            this.ParamsGroupBox.TabStop = false;
            this.ParamsGroupBox.Text = "Parameters";
            // 
            // CallDirectionComboBox
            // 
            this.CallDirectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CallDirectionComboBox.FormattingEnabled = true;
            this.CallDirectionComboBox.Location = new System.Drawing.Point(99, 75);
            this.CallDirectionComboBox.Name = "CallDirectionComboBox";
            this.CallDirectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.CallDirectionComboBox.TabIndex = 2;
            this.CallDirectionComboBox.SelectedIndexChanged += new System.EventHandler(this.CallDirectionComboBoxOnSelectedIndexChanged);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(99, 48);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.DateTimePicker.TabIndex = 1;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePickerOnValueChanged);
            // 
            // UserComboBox
            // 
            this.UserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Items.AddRange(new object[] {
            "",
            "Ann",
            "Bob",
            "Tom"});
            this.UserComboBox.Location = new System.Drawing.Point(99, 20);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(121, 21);
            this.UserComboBox.TabIndex = 0;
            this.UserComboBox.SelectedIndexChanged += new System.EventHandler(this.UserComboBoxOnSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Call direction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "NB Bob has two phone numbers";
            // 
            // CallListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 477);
            this.Controls.Add(this.ParamsGroupBox);
            this.Controls.Add(this.OnOffgroupBox);
            this.Controls.Add(this.CallListListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CallListForm";
            this.Text = "CallList";
            this.Closed += new System.EventHandler(this.CallListFormOnClosed);
            this.Load += new System.EventHandler(this.CallListFormOnLoad);
            this.OnOffgroupBox.ResumeLayout(false);
            this.OnOffgroupBox.PerformLayout();
            this.ParamsGroupBox.ResumeLayout(false);
            this.ParamsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CallListListView;
        private System.Windows.Forms.ColumnHeader UserColumn;
        private System.Windows.Forms.ColumnHeader UserNumbeColumn;
        private System.Windows.Forms.ColumnHeader CallTimeCcolumn;
        private System.Windows.Forms.ColumnHeader CallDirectionColumn;
        private System.Windows.Forms.ColumnHeader CountColumn;
        private System.Windows.Forms.GroupBox OnOffgroupBox;
        private System.Windows.Forms.RadioButton OffRadioButton;
        private System.Windows.Forms.RadioButton OnRadioButton;
        private System.Windows.Forms.GroupBox ParamsGroupBox;
        private System.Windows.Forms.ComboBox UserComboBox;
        private System.Windows.Forms.ComboBox CallDirectionComboBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

