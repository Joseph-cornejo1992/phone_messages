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
            string fName = firstNameTextBox.Text;
            string lName = lastNameTextBox.Text;
            string pNumber = phoneTextBox.Text;
            string acctNumber = accountTextBox.Text;
            string message = messageTextBox.Text;
            string age = ageTextBox.Text;

            
            bool check = errorCheck();

            if(check == false)
            {
                return;
            }
              
            //Establish a connection
            MySqlConnection conn = new MySqlConnection("Data Source=10.0.0.17;Initial Catalog=phone_messages;User ID=root;Password=Xalapa123.");

            try
            {
                conn.Open();
                // prepare command string
                string insertString = @"
                INSERT INTO phone_messages
                (account_number, first_name, last_name, status, doctor, date, time, age, telephone_number, message, operator)
                VALUES (100000, 'Bob', 'Ross', 2, 7, date, 0247, 94, 13864559825, 'Patient is testing', 'Test')";


           /*     string insertString1;
                String.Format(@"INSERT INTO phone_messages('{0}','{1}','{2},{3},{4},{5},{6},{7},{8},{9},{10})VALUES (100000, 'Bob', 'Ross', 2, 7, date, 0247, 94, 13864559825, 'Patient is testing', 'Test')",);
           */ 
                // 1. Instantiate a new command with a query and connection
                MySqlCommand cmd = new MySqlCommand(insertString, conn);

                // 2. Call ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();
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
            //this function serves to error check and returns false if anything is incorrect

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

        }
    }
}
