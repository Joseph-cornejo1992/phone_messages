namespace PhoneMessages
{
    partial class Form1
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
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.infoPanel.SuspendLayout();
            this.patientInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Lime;
            this.sendButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.sendButton.Location = new System.Drawing.Point(569, 599);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(471, 71);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "SEND";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 309);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1578, 249);
            this.textBox2.TabIndex = 2;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(601, 29);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(355, 48);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Phone Messages";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // currentDateTimePicker
            // 
            this.currentDateTimePicker.Location = new System.Drawing.Point(974, 200);
            this.currentDateTimePicker.Name = "currentDateTimePicker";
            this.currentDateTimePicker.Size = new System.Drawing.Size(654, 29);
            this.currentDateTimePicker.TabIndex = 8;
            this.currentDateTimePicker.ValueChanged += new System.EventHandler(this.currentDateTimePicker_ValueChanged);
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Location = new System.Drawing.Point(969, 172);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(59, 25);
            this.calendarLabel.TabIndex = 9;
            this.calendarLabel.Text = "Date:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(10, 14);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(106, 25);
            this.firstNameLabel.TabIndex = 10;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(734, 14);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(106, 25);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(11, 42);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(550, 29);
            this.firstNameTextBox.TabIndex = 12;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(739, 42);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(550, 29);
            this.lastNameTextBox.TabIndex = 13;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(1367, 42);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(186, 29);
            this.ageTextBox.TabIndex = 14;
            this.ageTextBox.TextChanged += new System.EventHandler(this.ageTextBox_TextChanged);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(1362, 14);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(54, 25);
            this.ageLabel.TabIndex = 15;
            this.ageLabel.Text = "Age:";
            // 
            // accountTextBox
            // 
            this.accountTextBox.Location = new System.Drawing.Point(15, 165);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(549, 29);
            this.accountTextBox.TabIndex = 16;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(15, 134);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(158, 25);
            this.accountLabel.TabIndex = 17;
            this.accountLabel.Text = "Account Number";
            this.accountLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(644, 241);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(196, 48);
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
            this.statusComboBox1.Location = new System.Drawing.Point(11, 50);
            this.statusComboBox1.Name = "statusComboBox1";
            this.statusComboBox1.Size = new System.Drawing.Size(400, 32);
            this.statusComboBox1.TabIndex = 3;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(6, 22);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(68, 25);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Status";
            // 
            // doctor_label
            // 
            this.doctor_label.AutoSize = true;
            this.doctor_label.Location = new System.Drawing.Point(11, 103);
            this.doctor_label.Name = "doctor_label";
            this.doctor_label.Size = new System.Drawing.Size(69, 25);
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
            this.doctorComboBox2.Location = new System.Drawing.Point(12, 131);
            this.doctorComboBox2.Name = "doctorComboBox2";
            this.doctorComboBox2.Size = new System.Drawing.Size(399, 32);
            this.doctorComboBox2.TabIndex = 7;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.infoPanel.Controls.Add(this.doctorComboBox2);
            this.infoPanel.Controls.Add(this.doctor_label);
            this.infoPanel.Controls.Add(this.statusLabel);
            this.infoPanel.Controls.Add(this.statusComboBox1);
            this.infoPanel.Location = new System.Drawing.Point(39, 97);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(910, 256);
            this.infoPanel.TabIndex = 19;
            // 
            // patientInfoPanel
            // 
            this.patientInfoPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.patientInfoPanel.Controls.Add(this.telephoneLabel);
            this.patientInfoPanel.Controls.Add(this.telephoneTextBox);
            this.patientInfoPanel.Controls.Add(this.messageLabel);
            this.patientInfoPanel.Controls.Add(this.accountLabel);
            this.patientInfoPanel.Controls.Add(this.accountTextBox);
            this.patientInfoPanel.Controls.Add(this.ageLabel);
            this.patientInfoPanel.Controls.Add(this.ageTextBox);
            this.patientInfoPanel.Controls.Add(this.lastNameTextBox);
            this.patientInfoPanel.Controls.Add(this.firstNameTextBox);
            this.patientInfoPanel.Controls.Add(this.lastNameLabel);
            this.patientInfoPanel.Controls.Add(this.firstNameLabel);
            this.patientInfoPanel.Controls.Add(this.textBox2);
            this.patientInfoPanel.Controls.Add(this.sendButton);
            this.patientInfoPanel.Location = new System.Drawing.Point(40, 391);
            this.patientInfoPanel.Name = "patientInfoPanel";
            this.patientInfoPanel.Size = new System.Drawing.Size(1601, 689);
            this.patientInfoPanel.TabIndex = 20;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(746, 165);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(543, 29);
            this.telephoneTextBox.TabIndex = 19;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(749, 142);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(143, 25);
            this.telephoneLabel.TabIndex = 20;
            this.telephoneLabel.Text = "Phone Number";
            this.telephoneLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1664, 1105);
            this.Controls.Add(this.patientInfoPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.calendarLabel);
            this.Controls.Add(this.currentDateTimePicker);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
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
        private System.Windows.Forms.TextBox textBox2;
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
        private System.Windows.Forms.TextBox telephoneTextBox;
    }
}

