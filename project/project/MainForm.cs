using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class MainForm : Form
    {

        string MyConnectionString = @"Data Source=DESKTOP-T41SL57\SQLEXPRESS;Initial Catalog=AirLineReservationSystem;Integrated Security=True";
        public static int uid;
        public static string LoginUid;
        public MainForm()
        {
            InitializeComponent();
             string query = "SELECT * FROM Registeration";

            SqlConnection databaseConnection = new SqlConnection(MyConnectionString);
            SqlCommand commandDatabase = new SqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            SqlDataReader reader;


                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    // Success, now list 

                    // If there are available rows
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                           MainForm.uid++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }


                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                MessageBox.Show(ex.ToString());
                }


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin DoubleAdmin = new AdminLogin();
            this.Hide();
            DoubleAdmin.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            uLogin ULoginRunner = new uLogin();
            ULoginRunner.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUs AboutUsRunner = new AboutUs();
            AboutUsRunner.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration registrationrunner = new Registration();
            this.Hide();
            registrationrunner.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services ServicesRunner = new Services();
            ServicesRunner.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Booking BookingRunner = new Booking();
            this.Hide();
            BookingRunner.Show();
        }
    }
}
