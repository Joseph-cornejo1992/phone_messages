namespace PhoneMessages
{
    partial class enterPhoneMessages
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
            this.sendButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.currentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.statusComboBox1 = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.doctor_label = new System.Windows.Forms.Label();
            this.doctorComboBox2 = new System.Windows.Forms.ComboBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.patientInfoPanel = new System.Windows.Forms.Panel();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.operatorTextBox = new System.Windows.Forms.TextBox();
            this.reviewMessagesButton = new System.Windows.Forms.Button();
            this.operatorLabel = new System.Windows.Forms.Label();
            this.infoPanel.SuspendLayout();
            this.patientInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Lime;
            this.sendButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.sendButton.Location = new System.Drawing.Point(481, 321);
            this.sendButton.Margin = new System.Windows.Forms.Padding(2);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(368, 38);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "SEND";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(5, 167);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(863, 137);
            this.messageTextBox.TabIndex = 2;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(328, 16);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(214, 29);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Phone Messages";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // currentDateTimePicker
            // 
            this.currentDateTimePicker.Location = new System.Drawing.Point(531, 108);
            this.currentDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.currentDateTimePicker.Name = "currentDateTimePicker";
            this.currentDateTimePicker.Size = new System.Drawing.Size(359, 20);
            this.currentDateTimePicker.TabIndex = 8;
            this.currentDateTimePicker.ValueChanged += new System.EventHandler(this.currentDateTimePicker_ValueChanged);
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Location = new System.Drawing.Point(529, 93);
            this.calendarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(33, 13);
            this.calendarLabel.TabIndex = 9;
            this.calendarLabel.Text = "Date:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(5, 8);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 10;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(400, 8);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(6, 23);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(302, 20);
            this.firstNameTextBox.TabIndex = 12;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(403, 23);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(302, 20);
            this.lastNameTextBox.TabIndex = 13;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(746, 23);
            this.ageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(103, 20);
            this.ageTextBox.TabIndex = 14;
            this.ageTextBox.TextChanged += new System.EventHandler(this.ageTextBox_TextChanged);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(743, 8);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(29, 13);
            this.ageLabel.TabIndex = 15;
            this.ageLabel.Text = "Age:";
            // 
            // accountTextBox
            // 
            this.accountTextBox.Location = new System.Drawing.Point(8, 89);
            this.accountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(301, 20);
            this.accountTextBox.TabIndex = 16;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(8, 73);
            this.accountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(87, 13);
            this.accountLabel.TabIndex = 17;
            this.accountLabel.Text = "Account Number";
            this.accountLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(351, 131);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(119, 29);
            this.messageLabel.TabIndex = 18;
            this.messageLabel.Text = "Message";
            // 
            // statusComboBox1
            // 
            this.statusComboBox1.FormattingEnabled = true;
            this.statusComboBox1.Items.AddRange(new object[] {
            "2nd Call",
            "Earlier Appointment",
            "Refill",
            "URGENT"});
            this.statusComboBox1.Location = new System.Drawing.Point(6, 27);
            this.statusComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.statusComboBox1.Name = "statusComboBox1";
            this.statusComboBox1.Size = new System.Drawing.Size(220, 21);
            this.statusComboBox1.TabIndex = 3;
            this.statusComboBox1.SelectedIndexChanged += new System.EventHandler(this.statusComboBox1_SelectedIndexChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(3, 12);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Status";
            // 
            // doctor_label
            // 
            this.doctor_label.AutoSize = true;
            this.doctor_label.Location = new System.Drawing.Point(6, 56);
            this.doctor_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doctor_label.Name = "doctor_label";
            this.doctor_label.Size = new System.Drawing.Size(39, 13);
            this.doctor_label.TabIndex = 6;
            this.doctor_label.Text = "Doctor";
            // 
            // doctorComboBox2
            // 
            this.doctorComboBox2.FormattingEnabled = true;
            this.doctorComboBox2.Items.AddRange(new object[] {
            "Cognetta",
            "Soni",
            "Green",
            "McKinney",
            "Hoffman",
            "Van der Kooi",
            "Jackson",
            "Dolehide",
            "Inglese",
            "Cohen",
            "Richardson",
            "Low",
            "Other"});
            this.doctorComboBox2.Location = new System.Drawing.Point(7, 71);
            this.doctorComboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.doctorComboBox2.Name = "doctorComboBox2";
            this.doctorComboBox2.Size = new System.Drawing.Size(219, 21);
            this.doctorComboBox2.TabIndex = 7;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.infoPanel.Controls.Add(this.doctorComboBox2);
            this.infoPanel.Controls.Add(this.doctor_label);
            this.infoPanel.Controls.Add(this.statusLabel);
            this.infoPanel.Controls.Add(this.statusComboBox1);
            this.infoPanel.Location = new System.Drawing.Point(21, 53);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(496, 139);
            this.infoPanel.TabIndex = 19;
            // 
            // patientInfoPanel
            // 
            this.patientInfoPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.patientInfoPanel.Controls.Add(this.operatorLabel);
            this.patientInfoPanel.Controls.Add(this.operatorTextBox);
            this.patientInfoPanel.Controls.Add(this.telephoneLabel);
            this.patientInfoPanel.Controls.Add(this.phoneTextBox);
            this.patientInfoPanel.Controls.Add(this.messageLabel);
            this.patientInfoPanel.Controls.Add(this.accountLabel);
            this.patientInfoPanel.Controls.Add(this.accountTextBox);
            this.patientInfoPanel.Controls.Add(this.ageLabel);
            this.patientInfoPanel.Controls.Add(this.ageTextBox);
            this.patientInfoPanel.Controls.Add(this.lastNameTextBox);
            this.patientInfoPanel.Controls.Add(this.firstNameTextBox);
            this.patientInfoPanel.Controls.Add(this.lastNameLabel);
            this.patientInfoPanel.Controls.Add(this.firstNameLabel);
            this.patientInfoPanel.Controls.Add(this.messageTextBox);
            this.patientInfoPanel.Controls.Add(this.sendButton);
            this.patientInfoPanel.Location = new System.Drawing.Point(22, 212);
            this.patientInfoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.patientInfoPanel.Name = "patientInfoPanel";
            this.patientInfoPanel.Size = new System.Drawing.Size(873, 373);
            this.patientInfoPanel.TabIndex = 20;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(400, 74);
            this.telephoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(78, 13);
            this.telephoneLabel.TabIndex = 20;
            this.telephoneLabel.Text = "Phone Number";
            this.telephoneLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(403, 89);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(302, 20);
            this.phoneTextBox.TabIndex = 19;
            // 
            // operatorTextBox
            // 
            this.operatorTextBox.Location = new System.Drawing.Point(5, 331);
            this.operatorTextBox.Name = "operatorTextBox";
            this.operatorTextBox.Size = new System.Drawing.Size(370, 20);
            this.operatorTextBox.TabIndex = 21;
            this.operatorTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // reviewMessagesButton
            // 
            this.reviewMessagesButton.BackColor = System.Drawing.Color.Orange;
            this.reviewMessagesButton.Location = new System.Drawing.Point(768, 45);
            this.reviewMessagesButton.Name = "reviewMessagesButton";
            this.reviewMessagesButton.Size = new System.Drawing.Size(102, 35);
            this.reviewMessagesButton.TabIndex = 21;
            this.reviewMessagesButton.Text = "Review Messages";
            this.reviewMessagesButton.UseVisualStyleBackColor = false;
            // 
            // operatorLabel
            // 
            this.operatorLabel.AutoSize = true;
            this.operatorLabel.Location = new System.Drawing.Point(3, 315);
            this.operatorLabel.Name = "operatorLabel";
            this.operatorLabel.Size = new System.Drawing.Size(66, 13);
            this.operatorLabel.TabIndex = 22;
            this.operatorLabel.Text = "By Operator:";
            // 
            // enterPhoneMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(908, 604);
            this.Controls.Add(this.reviewMessagesButton);
            this.Controls.Add(this.patientInfoPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.calendarLabel);
            this.Controls.Add(this.currentDateTimePicker);
            this.Controls.Add(this.TitleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "enterPhoneMessages";
            this.Text = "Phone Messages App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.patientInfoPanel.ResumeLayout(false);
            this.patientInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.DateTimePicker currentDateTimePicker;
        private System.Windows.Forms.Label calendarLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.ComboBox statusComboBox1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label doctor_label;
        private System.Windows.Forms.ComboBox doctorComboBox2;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel patientInfoPanel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox operatorTextBox;
        private System.Windows.Forms.Label operatorLabel;
        private System.Windows.Forms.Button reviewMessagesButton;
    }
}

