using System.Windows.Forms;

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
            this.FormattingComboBox = new System.Windows.Forms.ComboBox();
            this.FilteredMessagesListView = new System.Windows.Forms.ListView();
            this.UserColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MessageColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.LogicOperatorGoupBox = new System.Windows.Forms.GroupBox();
            this.AndRadioButton = new System.Windows.Forms.RadioButton();
            this.OrRadioButton = new System.Windows.Forms.RadioButton();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.SearchTextLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.RefreshAllButton = new System.Windows.Forms.Button();
            this.LogicOperatorGoupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormattingComboBox
            // 
            this.FormattingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormattingComboBox.FormattingEnabled = true;
            this.FormattingComboBox.Items.AddRange(new object[] {
            "None",
            "Start with DateTime",
            "End with DateTime",
            "Lowercase",
            "Uppercase"});
            this.FormattingComboBox.Location = new System.Drawing.Point(12, 128);
            this.FormattingComboBox.Name = "FormattingComboBox";
            this.FormattingComboBox.Size = new System.Drawing.Size(121, 21);
            this.FormattingComboBox.TabIndex = 1;
            this.FormattingComboBox.SelectedIndexChanged += new System.EventHandler(this.FormattingComboBoxOnSelectedIndexChanged);
            // 
            // FilteredMessagesListView
            // 
            this.FilteredMessagesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserColumn,
            this.MessageColumn});
            this.FilteredMessagesListView.FullRowSelect = true;
            this.FilteredMessagesListView.GridLines = true;
            this.FilteredMessagesListView.Location = new System.Drawing.Point(12, 155);
            this.FilteredMessagesListView.Name = "FilteredMessagesListView";
            this.FilteredMessagesListView.Size = new System.Drawing.Size(281, 393);
            this.FilteredMessagesListView.TabIndex = 2;
            this.FilteredMessagesListView.TileSize = new System.Drawing.Size(250, 30);
            this.FilteredMessagesListView.UseCompatibleStateImageBehavior = false;
            this.FilteredMessagesListView.View = System.Windows.Forms.View.Tile;
            // 
            // UserColumn
            // 
            this.UserColumn.Text = "User";
            // 
            // MessageColumn
            // 
            this.MessageColumn.Text = "Message";
            this.MessageColumn.Width = 200;
            // 
            // UserComboBox
            // 
            this.UserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Items.AddRange(new object[] {
            "All",
            "Tom",
            "Bob",
            "Ann"});
            this.UserComboBox.Location = new System.Drawing.Point(172, 48);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(121, 21);
            this.UserComboBox.TabIndex = 3;
            this.UserComboBox.SelectedIndexChanged += new System.EventHandler(this.UserComboBoxOnSelectedIndexChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(172, 75);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(121, 20);
            this.SearchTextBox.TabIndex = 4;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBoxOnTextChanged);
            // 
            // LogicOperatorGoupBox
            // 
            this.LogicOperatorGoupBox.Controls.Add(this.AndRadioButton);
            this.LogicOperatorGoupBox.Controls.Add(this.OrRadioButton);
            this.LogicOperatorGoupBox.Location = new System.Drawing.Point(172, -1);
            this.LogicOperatorGoupBox.Name = "LogicOperatorGoupBox";
            this.LogicOperatorGoupBox.Size = new System.Drawing.Size(121, 43);
            this.LogicOperatorGoupBox.TabIndex = 5;
            this.LogicOperatorGoupBox.TabStop = false;
            this.LogicOperatorGoupBox.Text = "Logic operator";
            // 
            // AndRadioButton
            // 
            this.AndRadioButton.AutoSize = true;
            this.AndRadioButton.Location = new System.Drawing.Point(67, 19);
            this.AndRadioButton.Name = "AndRadioButton";
            this.AndRadioButton.Size = new System.Drawing.Size(48, 17);
            this.AndRadioButton.TabIndex = 1;
            this.AndRadioButton.TabStop = true;
            this.AndRadioButton.Text = "AND";
            this.AndRadioButton.UseVisualStyleBackColor = true;
            this.AndRadioButton.CheckedChanged += new System.EventHandler(this.AndRadioButtonOnCheckedChanged);
            // 
            // OrRadioButton
            // 
            this.OrRadioButton.AutoSize = true;
            this.OrRadioButton.Checked = true;
            this.OrRadioButton.Location = new System.Drawing.Point(7, 19);
            this.OrRadioButton.Name = "OrRadioButton";
            this.OrRadioButton.Size = new System.Drawing.Size(41, 17);
            this.OrRadioButton.TabIndex = 0;
            this.OrRadioButton.TabStop = true;
            this.OrRadioButton.Text = "OR";
            this.OrRadioButton.UseVisualStyleBackColor = true;
            this.OrRadioButton.CheckedChanged += new System.EventHandler(this.OrRadioButtonOnCheckedChanged);
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Location = new System.Drawing.Point(172, 102);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.FromDateTimePicker.TabIndex = 6;
            this.FromDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.FromDateTimePicker.ValueChanged += new System.EventHandler(this.FromDateTimePickerOnValueChanged);
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Location = new System.Drawing.Point(172, 129);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.ToDateTimePicker.TabIndex = 7;
            this.ToDateTimePicker.ValueChanged += new System.EventHandler(this.ToDateTimePickerOnValueChanged);
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(136, 102);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(30, 13);
            this.FromLabel.TabIndex = 8;
            this.FromLabel.Text = "From";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(146, 129);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(20, 13);
            this.ToLabel.TabIndex = 9;
            this.ToLabel.Text = "To";
            // 
            // SearchTextLabel
            // 
            this.SearchTextLabel.AutoSize = true;
            this.SearchTextLabel.Location = new System.Drawing.Point(136, 78);
            this.SearchTextLabel.Name = "SearchTextLabel";
            this.SearchTextLabel.Size = new System.Drawing.Size(28, 13);
            this.SearchTextLabel.TabIndex = 10;
            this.SearchTextLabel.Text = "Text";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(135, 51);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(29, 13);
            this.UserLabel.TabIndex = 11;
            this.UserLabel.Text = "User";
            // 
            // RefreshAllButton
            // 
            this.RefreshAllButton.Location = new System.Drawing.Point(13, 96);
            this.RefreshAllButton.Name = "RefreshAllButton";
            this.RefreshAllButton.Size = new System.Drawing.Size(117, 24);
            this.RefreshAllButton.TabIndex = 12;
            this.RefreshAllButton.Text = "Refresh all messages";
            this.RefreshAllButton.UseVisualStyleBackColor = true;
            this.RefreshAllButton.Click += new System.EventHandler(this.RefreshAllButtonOnClick);
            // 
            // FormSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 560);
            this.Controls.Add(this.RefreshAllButton);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.SearchTextLabel);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.ToDateTimePicker);
            this.Controls.Add(this.FromDateTimePicker);
            this.Controls.Add(this.LogicOperatorGoupBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.UserComboBox);
            this.Controls.Add(this.FilteredMessagesListView);
            this.Controls.Add(this.FormattingComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSMS";
            this.Text = "Message Filtering";
            this.Closed += new System.EventHandler(this.FormSMSOnClosed);
            this.LogicOperatorGoupBox.ResumeLayout(false);
            this.LogicOperatorGoupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox FormattingComboBox;
        private System.Windows.Forms.ListView FilteredMessagesListView;
        private ColumnHeader UserColumn;
        private ColumnHeader MessageColumn;
        private ComboBox UserComboBox;
        private TextBox SearchTextBox;
        private GroupBox LogicOperatorGoupBox;
        private RadioButton AndRadioButton;
        private RadioButton OrRadioButton;
        private DateTimePicker FromDateTimePicker;
        private DateTimePicker ToDateTimePicker;
        private Label FromLabel;
        private Label ToLabel;
        private Label SearchTextLabel;
        private Label UserLabel;
        private Button RefreshAllButton;
    }
}

