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
    public partial class Registration : Form
    {
        
        
        public Registration()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            upanel UPanelRunner = new upanel();
            if (textBox2.Text != textBox7.Text)
            {
                MessageBox.Show("Your Password Doesn't Match");
            }
            else
            {
                this.Hide();
                UPanelRunner.Show();

                //Uncomment this piece of code to attach database.

                 using (SqlConnection ConnectionToDatabase = new SqlConnection(@"Data Source=DESKTOP-T41SL57\SQLEXPRESS;Initial Catalog=AirLineReservationSystem;Integrated Security=True;"))
                {
                string Query = "INSERT INTO Registeration (Name,CNIC,Email,City,Password, uid)" + "VALUES(@Name, @CNIC, @Email, @City, @Password, @uid)";
                    using (SqlCommand Tester = new SqlCommand(Query, ConnectionToDatabase))
                    {
                        Tester.Parameters.Add("@Name", SqlDbType.VarChar).Value = textBox1.Text;
                        Tester.Parameters.Add("@CNIC", SqlDbType.VarChar).Value = textBox6.Text;
                        Tester.Parameters.Add("@Email", SqlDbType.VarChar).Value = textBox5.Text;
                        Tester.Parameters.Add("@City", SqlDbType.VarChar).Value = textBox4.Text;
                        Tester.Parameters.Add("@Password", SqlDbType.VarChar).Value = textBox7.Text;
                        Tester.Parameters.Add("@uid", SqlDbType.Int).Value = MainForm.uid + 1;

                        Tester.Connection.Open();
                        Tester.ExecuteNonQuery();
                    }
                } 
            }
            //ConnectionToDatabase.Open();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Name")
            {
                textBox1.Text = "";
            }
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "CNIC")
            {
                textBox6.Text = "";
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "Email")
            {
                textBox5.Text = "";
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "City")
            {
                textBox4.Text = "";
            }
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "Password")
            {
                textBox7.Text = "";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Confirm Password")
            {
                textBox2.Text = "";
            }
           
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox7_MouseHover(object sender, EventArgs e)
        {
          
        }
    }
}
