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
using System.Drawing.Printing;

namespace PhoneMessages
{
    public partial class ReceivedMessages : Form
    {
        public ReceivedMessages()
        {
            //initializes deadGridView and gets data when screen opens up
            DataGridView dataGridView4 = new DataGridView();
            InitializeComponent();
            get_data();
        }
        //Initializes datatable and connection
        DataTable dt = new DataTable();
        MySqlConnection conn = new MySqlConnection("Data Source=10.0.0.17;Port=3306;Initial Catalog=phone_messages;User ID=phone_messages;Password=Ei1CW10ncoCHsaUp");

        private void ReceivedMessages_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView4.CellClick += dataGridView4_CellClick;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //resets table in order to not 
            dt.Clear();
            get_data();
        }

        private void get_data()
        {
            try
            {
                //opens connection 
                conn.Open();
                //fills the data table with mysql query
                String query = "SELECT status,doctor,last_Name,account_number,date,time,message_ID FROM phone_messages";
                MySqlDataAdapter MSDA = new MySqlDataAdapter(query, conn);
                MSDA.Fill(dt);
                dataGridView4.DataSource = dt;
                //close connection
                conn.Close();

                //some settings that needed to be changed for functionality purposes
                dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView4.MultiSelect = false;
                dataGridView4.RowsDefaultCellStyle.BackColor = Color.LightGray;
                dataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Cannot retrieve data from server", ex.ToString());
            }

        }

        private void reprintButton_Click(object sender, EventArgs e)
        {
            //initializes string variables that will serve as containers
            string doc, status, fName, lName, accNum, time, date, age, pNumber, mess, op;
            //Gets message ID from selected row and turns it into an int. 
            Int32.TryParse(dt.Rows[dataGridView4.CurrentCell.RowIndex]["message_ID"].ToString(), out int selected);
            //populates mysql command
            MySqlCommand cmd = new MySqlCommand("SELECT doctor, status, first_name, last_name, account_number, time, date, age, telephone_number, message, operator FROM phone_messages WHERE message_ID = @selected ", conn);
            cmd.Parameters.AddWithValue("@selected", selected);
            try
            {
                conn.Open();
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //holds results from query
                    doc = (string)rdr["doctor"];
                    status = (string)rdr["status"];
                    fName = (string)rdr["first_name"];
                    lName = (string)rdr["last_name"];
                    accNum = (string)rdr["account_number"];
                    time = (string)rdr["time"];
                    date = (string)rdr["date"];
                    age = (string)rdr["age"];
                    pNumber = (string)rdr["telephone_number"];
                    mess = (string)rdr["message"];
                    op = (string)rdr["operator"];

                    //writes text to textfile
                    writeText(doc, status, fName, lName, accNum, time, date, age, pNumber, mess, op);
                    //pints text file
                    filePrint();
                }
                //closes reader and connection
                rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                string error = string.Format("Exception: {0}", ex.Message);
            }

        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void writeText(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k)
        {
            //formats the patients name to be in all uppercase
            f = f.ToUpper();
            g = g.ToUpper();

            //does some formatting for the message
            string introduction = ("You have a new message for Dr." + b + ". The status is: " + a);
            string time = ("\nThis message was sent on " + d + " at " + e);
            string patientInfo = ("\n\nFor Patient: " + g + ", " + f + "\naccount number: " + c + "\nAge: " + h);
            string telephone = ("Patient's phone number: " + i);
            string patientMessage = ("\n\nMessage: \n" + j);
            string operator1 = ("\nFrom Operator: " + k + "\n\n\n\n\n\n\n");

            string receivedBy = ("Message Delivered On: Date_______________, Time___________,\n\nBY________________\n");
            string actionTaken = ("ACTION TAKEN: __________________________________________________________ \n\n");
            string extraLines = ("___________________________________________________________\n\n");
            string nurse = ("NURSE:________________ DATE:__________ TIME:__________ A.M. P.M.\n\n");
            string physician = ("PHYSICIAN:__________________________ DATE:________________");
            //puts all strings into an array
            string[] lines = { introduction, time, patientInfo, telephone, patientMessage, operator1, receivedBy, actionTaken, extraLines, extraLines, extraLines, extraLines, nurse, physician };
            //writes array of strings to file
            System.IO.File.WriteAllLines(@"C:\Users\Public\WriteLines.txt", lines);
        }
        //File Location that is going to be printed
        //Make sure that it matches the location the program is writing to. 
        string filename = (@"C:\Users\Public\WriteLines.txt");
        //Create a Verdana font with size 10
        Font verdana10Font = new Font("Verdana", 10);

        private void filePrint()
        {
            //Create a PrintDocument object
            PrintDocument pd = new PrintDocument();
            //Add PrintPage event handler
            pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);
            //Call Print Method
            pd.Print();
            StreamReader reader = new StreamReader(filename);
            //Close the reader
            if (reader != null)
                reader.Close();
        }

        private void PrintTextFileHandler(object sender, PrintPageEventArgs ppeArgs)
        {
            StreamReader reader = new StreamReader(filename);
            //Get the Graphics object
            Graphics g = ppeArgs.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            //Read margins from PrintPageEventArgs
            float leftMargin = ppeArgs.MarginBounds.Left;
            float topMargin = ppeArgs.MarginBounds.Top;
            string line = null;
            //Calculate the lines per page on the basis of the height of the page and the height of the font
            linesPerPage = ppeArgs.MarginBounds.Height /
            verdana10Font.GetHeight(g);
            //Now read lines one by one, using StreamReader
            while (count < linesPerPage &&
            ((line = reader.ReadLine()) != null))
            {
                //Calculate the starting position
                yPos = topMargin + (count *
                verdana10Font.GetHeight(g));
                //Draw text
                g.DrawString(line, verdana10Font, Brushes.Black,
                leftMargin, yPos, new StringFormat());
                //Move to next line
                count++;
            }
            //If PrintPageEventArgs has more pages to print
            if (line != null)
            {
                ppeArgs.HasMorePages = true;
            }
            else
            {
                ppeArgs.HasMorePages = false;
            }
        }


    }

}
