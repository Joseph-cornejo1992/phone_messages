using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace PhoneMessages
{
    public partial class enterPhoneMessages : Form
    {
        public enterPhoneMessages()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            //error check to make sure all the fields are populated.
            bool check = errorCheck();
            if (check == false)
            {
                return;
            }

            //extracts variables from text and comboboxes
            string fName = firstNameTextBox.Text;
            string lName = lastNameTextBox.Text;
            string pNumber = phoneTextBox.Text;
            string acctNumber = accountTextBox.Text;
            string message = messageTextBox.Text;
            string age = ageTextBox.Text;
            string operator1 = operatorTextBox.Text;
            string status = this.statusComboBox1.GetItemText(this.statusComboBox1.SelectedItem);
            string doctor = this.doctorComboBox2.GetItemText(this.doctorComboBox2.SelectedItem);
            //picks current time from DateTimePicker
            string date1 = currentDateTimePicker.Value.Year + "-" + currentDateTimePicker.Value.Month + "-" + currentDateTimePicker.Value.Day;
            string time = DateTime.Now.ToString("hh:mm");
            
            //this changes doctor variable to name entered in othertextbox in case the operator chose the "other" selection on the doctorComboBox. 
            if (string.Equals(doctor,"other") == true)
            {
                doctor = otherTextBox.Text;
            }

            //Establish a connection
            MySqlConnection conn = new MySqlConnection("Data Source=10.0.0.17;Port=3306;Initial Catalog=phone_messages;User ID=phone_messages;Password=Ei1CW10ncoCHsaUp");

            try
            {
                conn.Open();

                if (conn.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Connection Closed");
                }
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connection open");
                }
                MySqlCommand cmd = new MySqlCommand("INSERT INTO phone_messages (account_number, first_name, last_name, status, doctor, date, time, age, telephone_number, message, operator)VALUES(@account_number, @first_name, @last_name, @status, @doctor, @date, @time, @age, @telephone_number, @message, @operator)", conn);
                cmd.Parameters.AddWithValue("@account_number",acctNumber);
                cmd.Parameters.AddWithValue("@first_name",fName);
                cmd.Parameters.AddWithValue("@last_name",lName);
                cmd.Parameters.AddWithValue("@status",status);
                cmd.Parameters.AddWithValue("@doctor",doctor);
                cmd.Parameters.AddWithValue("@date",date1);
                cmd.Parameters.AddWithValue("@time",time);
                cmd.Parameters.AddWithValue("@age",age);
                cmd.Parameters.AddWithValue("@telephone_number",pNumber);
                cmd.Parameters.AddWithValue("@message",message);
                cmd.Parameters.AddWithValue("@operator",operator1);
                if (conn.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Connection 1 Closed");
                }
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connection 1 open");
                }
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("connection closed");
               if( conn.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Connection 2 Closed");
                }
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connection 2 open");
                }
            }

            catch (Exception ex)
            {
                //MessageBox.Show(" Can't open connection ! ");
                string error = string.Format("Exception: {0}", ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void currentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        private bool errorCheck()
        {
            //this function serves to error check and returns false if any field is not populated

            if (accountTextBox.TextLength > 6 || accountTextBox.TextLength < 1)
            {
                MessageBox.Show("Please double check the account number");
                return false;
            }

            if (firstNameTextBox.TextLength < 1)
            {
                MessageBox.Show("First name cannot be empty");
                return false;
            }

            if (lastNameTextBox.TextLength < 1)
            {
                MessageBox.Show("Last Name cannot be empty");
                return false;
            }

            if (phoneTextBox.TextLength < 1)
            {
                MessageBox.Show("Phone number cannot be empty");
                return false;
            }

            if (messageTextBox.TextLength < 1)
            {
                MessageBox.Show("Message cannot be empty");
                return false;
            }

            if (ageTextBox.TextLength < 1)
            {
                MessageBox.Show("Age cannot be empty");
                return false;
            }
            // These 2 lines put the combobox selected into strings so the program can errorcheck to make sure they are not empty.
            string statusSelected = this.statusComboBox1.GetItemText(this.statusComboBox1.SelectedItem);
            string doctorSelected = this.doctorComboBox2.GetItemText(this.doctorComboBox2.SelectedItem);

            if(statusSelected.Length < 1)
            {
                MessageBox.Show("Please select a Status");
                return false;
            }

            if (doctorSelected.Length < 1)
            {
                MessageBox.Show("Please select a Doctor");
                return false;
            }
            
            //return true if all else is fine
            return true;
        }

        private void statusComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void reviewMessagesButton_Click(object sender, EventArgs e)
        {
            ReceivedMessages rm = new ReceivedMessages();
            rm.Show();
        }

        private void infoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void doctorComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {   
            //if doctorcomboBox is set to "other", this sets the otherTextBox to visible 
            string doctor = this.doctorComboBox2.GetItemText(this.doctorComboBox2.SelectedItem);
            if (string.Equals(doctor, "Other") == true)
            {
                otherTextBox.Visible = true;
            }
        }
    }
}
