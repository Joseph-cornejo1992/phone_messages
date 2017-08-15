using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace PhoneMessages
{
    public partial class ReceivedMessages : Form
    {
        
            public ReceivedMessages()
        {
            InitializeComponent();
            get_data();
        }
        MySqlConnection conn = new MySqlConnection("Data Source=10.0.0.17;Port=3306;Initial Catalog=phone_messages;User ID=phone_messages;Password=Ei1CW10ncoCHsaUp");
        private void ReceivedMessages_Load(object sender, EventArgs e)
        {
            
        }


        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            get_data();

        }

        private void get_data()
        {
            try
            {
                conn.Open();
                String query = "SELECT status,doctor,last_Name,account_number,date,time,Printed FROM phone_messages";
                MySqlDataAdapter MSDA = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                MSDA.Fill(dt);
                dataGridView4.DataSource = dt;
                conn.Close();

                dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView4.MultiSelect = false;
                dataGridView4.RowsDefaultCellStyle.BackColor = Color.LightGray;
                dataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: Cannot retrieve data from server",ex.ToString());
            }
        }

        private void reprintButton_Click(object sender, EventArgs e)
        {

        }
    }//end of class
}
