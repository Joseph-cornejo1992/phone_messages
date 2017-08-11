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

namespace PhoneMessages
{
    public partial class ReceivedMessages : Form
    {
        public ReceivedMessages()
        {
            InitializeComponent();
        }

        private void ReceivedMessages_Load(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Hey there");
                //Establish a connection
                MySqlConnection conn = new MySqlConnection("Data Source=10.0.0.17;Port=3306;Initial Catalog=phone_messages;User ID=root;Password=Xalapa123.");
                MySqlDataReader rdr = null;
                MySqlCommand selectquery = new MySqlCommand("SELECT * FROM phone_messages", conn);
                Console.WriteLine(
                    "Account Number                   Doctor                     Last Name                Printed?");
                Console.WriteLine(
                "--------------                   -------                    ----------               --------");
                MessageBox.Show("Hey there");
                try
                {
                    conn.Open();

                    rdr = selectquery.ExecuteReader();

                    Console.WriteLine(
                    "Account Number                   Doctor                     Last Name                Printed?");
                    Console.WriteLine(
                    "--------------                   -------                    ----------               --------");

                    while (rdr.Read())
                    {
                        // get the results of each column
                        string accountNumber = (string)rdr["account_number"];
                        string lastName = (string)rdr["lName"];
                        string doctor = (string)rdr["doctor"];

                        MessageBox.Show(lastName + accountNumber + doctor);


                        // print out the results
                        Console.Write("{0,-25}", accountNumber);
                        Console.Write("{0,-20}", lastName);
                        Console.Write("{0,-25}", doctor);
                        Console.WriteLine();

                    }
                }
                finally
                {
                    // 3. close the reader
                    if (rdr != null)
                    {
                        rdr.Close();
                    }

                    // close the connection
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }
    }//end of class
}
