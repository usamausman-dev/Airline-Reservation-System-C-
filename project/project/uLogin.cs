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

namespace project
{
    public partial class uLogin : Form
    {
        public uLogin()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            upanel upanelrunner = new upanel();
            string canvotecheckQuery = "SELECT uid FROM Registeration WHERE Name = '" + textBox1.Text + "' and Password='" + textBox2.Text + "'";

            SqlConnection NewConnection = new SqlConnection(@"Data Source=DESKTOP-T41SL57\SQLEXPRESS;Initial Catalog=AirLineReservationSystem;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Registeration where Name='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", NewConnection);
            SqlDataAdapter uidCheck = new SqlDataAdapter(canvotecheckQuery, NewConnection);
            DataTable DT = new DataTable();
            DataTable uidTable = new DataTable();

            sda.Fill(DT);
            uidCheck.Fill(uidTable);

            MainForm.LoginUid = uidTable.Rows[0][0].ToString();

            if (DT.Rows[0][0].ToString() == "1")
            {
                this.Hide();

                upanelrunner.Show();

            }
            else
            {
                MessageBox.Show("Input Username and Password");
            }
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm MainFormRunner = new MainForm();
            this.Hide();
            MainFormRunner.Show();
        }

        private void uLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Username")
            {
            textBox1.Text = "";
            textBox2.Text = "Password";
            }
            else
            {
                textBox2.Text = "Password";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Username")
            {
            textBox2.Text = "";
            textBox1.Text = "Username";
            }
            else
            {
                textBox2.Text = "";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel2_Click(object sender, EventArgs e)
        {
            Registration registerationrunner = new Registration();
            this.Hide();
            registerationrunner.Show();
        }
    }
}
