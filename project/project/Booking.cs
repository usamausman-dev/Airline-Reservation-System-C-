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
    public partial class Booking : Form
    {
        string MyConnectionString = @"Data Source=DESKTOP-T41SL57\SQLEXPRESS;Initial Catalog=AirLineReservationSystem;Integrated Security=True";
        public Booking()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airLineReservationSystemDataSet.Registeration' table. You can move, or remove it, as needed.
            //this.registerationTableAdapter.Fill(this.airLineReservationSystemDataSet.Registeration);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            upanel UPanelRunner = new upanel();
            //Application.Exit();
            this.Hide();
            UPanelRunner.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            upanel upanelrunner = new upanel();
            this.Hide();
            upanelrunner.Show();
            using (SqlConnection ConnectionToDatabase = new SqlConnection(@"Data Source=DESKTOP-T41SL57\SQLEXPRESS;Initial Catalog=AirLineReservationSystem;Integrated Security=True;"))
                {
                string Query = "INSERT INTO BookingNew (PName,PCNIC,PNumber,DepartureC,DepartureP,ArrivalC,ArrivalP,Payment,BookerId)" + "VALUES(@PName, @PCNIC, @PNumber, @DepartureC, @DepartureP, @ArrivalC, @ArrivalP, @Payment, @BookerId)";
                    using (SqlCommand Tester = new SqlCommand(Query, ConnectionToDatabase))
                    {
                        Tester.Parameters.Add("@PName", SqlDbType.VarChar).Value = textBox9.Text;
                        Tester.Parameters.Add("@PCNIC", SqlDbType.VarChar).Value = textBox8.Text;
                        Tester.Parameters.Add("@PNumber", SqlDbType.VarChar).Value = textBox5.Text;

                    if(comboBox4.SelectedIndex == 0)
                    {
                        Tester.Parameters.Add("@DepartureC", SqlDbType.VarChar).Value = comboBox4.SelectedItem;
                        Tester.Parameters.Add("@DepartureP", SqlDbType.VarChar).Value = comboBox6.SelectedItem;
                    }
                    if (comboBox4.SelectedIndex == 1)
                    {
                        Tester.Parameters.Add("@DepartureC", SqlDbType.VarChar).Value = comboBox4.SelectedItem;
                        Tester.Parameters.Add("@DepartureP", SqlDbType.VarChar).Value = comboBox5.SelectedItem;
                    }
                    if (comboBox4.SelectedIndex == 2)
                    {
                        Tester.Parameters.Add("@DepartureC", SqlDbType.VarChar).Value = comboBox4.SelectedItem;
                        Tester.Parameters.Add("@DepartureP", SqlDbType.VarChar).Value = comboBox3.SelectedItem;
                    }
                    if (comboBox4.SelectedIndex == 3)
                    {
                        Tester.Parameters.Add("@DepartureC", SqlDbType.VarChar).Value = comboBox4.SelectedItem;
                        Tester.Parameters.Add("@DepartureP", SqlDbType.VarChar).Value = comboBox2.SelectedItem;
                    }
                    if (comboBox4.SelectedIndex == 4)
                    {
                        Tester.Parameters.Add("@DepartureC", SqlDbType.VarChar).Value = comboBox4.SelectedItem;
                        Tester.Parameters.Add("@DepartureP", SqlDbType.VarChar).Value = comboBox1.SelectedItem;
                    }
                    if (comboBox8.SelectedIndex == 0)
                    {
                        Tester.Parameters.Add("@ArrivalC", SqlDbType.VarChar).Value = comboBox8.SelectedItem;
                        Tester.Parameters.Add("@ArrivalP", SqlDbType.VarChar).Value = comboBox13.SelectedItem;
                    }
                    if (comboBox8.SelectedIndex == 1)
                    {
                        Tester.Parameters.Add("@ArrivalC", SqlDbType.VarChar).Value = comboBox8.SelectedItem;
                        Tester.Parameters.Add("@ArrivalP", SqlDbType.VarChar).Value = comboBox12.SelectedItem;
                    }
                    if (comboBox8.SelectedIndex == 2)
                    {
                        Tester.Parameters.Add("@ArrivalC", SqlDbType.VarChar).Value = comboBox8.SelectedItem;
                        Tester.Parameters.Add("@ArrivalP", SqlDbType.VarChar).Value = comboBox11.SelectedItem;
                    }
                    if (comboBox8.SelectedIndex == 3)
                    {
                        Tester.Parameters.Add("@ArrivalC", SqlDbType.VarChar).Value = comboBox8.SelectedItem;
                        Tester.Parameters.Add("@ArrivalP", SqlDbType.VarChar).Value = comboBox10.SelectedItem;
                    }
                    if (comboBox8.SelectedIndex == 4)
                    {
                        Tester.Parameters.Add("@ArrivalC", SqlDbType.VarChar).Value = comboBox8.SelectedItem;
                        Tester.Parameters.Add("@ArrivalP", SqlDbType.VarChar).Value = comboBox9.SelectedItem;
                    }
                    

                    Tester.Parameters.Add("@Payment", SqlDbType.VarChar).Value = textBox6.Text;
                    Tester.Parameters.Add("@BookerId", SqlDbType.VarChar).Value = MainForm.LoginUid;

                    Tester.Connection.Open();
                        Tester.ExecuteNonQuery();
                    }
                } 
            if (comboBox4.SelectedItem == comboBox8.SelectedItem)
            {
                MessageBox.Show("Arrival and Departure can't be same");
            }
            
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "Enter Your Name")
            {
                textBox9.Text = "";
            }
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "Enter Your National ID Number")
                {
                    textBox8.Text = "";
                }
            
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "Enter Your Passport Number")
            {
                textBox5.Text = "";
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox4.SelectedIndex == 0)
            {
                comboBox7.Visible = false;
                comboBox6.Visible = true;
                comboBox5.Visible = false;
                comboBox3.Visible = false;
                comboBox2.Visible = false;
                comboBox1.Visible = false;

            }
            if (comboBox4.SelectedIndex == 1)
            {
                comboBox7.Visible = false;
                comboBox5.Visible = true;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox6.Visible = false;
                comboBox1.Visible = false;

            }
            if (comboBox4.SelectedIndex == 2)
            {
                comboBox7.Visible = false;
                comboBox3.Visible = true;
                comboBox5.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox6.Visible = false;

            }
            if (comboBox4.SelectedIndex == 3)
            {
                comboBox7.Visible = false;
                comboBox2.Visible = true;
                comboBox6.Visible = false;
                comboBox3.Visible = false;
                comboBox5.Visible = false;
                comboBox1.Visible = false;

            }
            if (comboBox4.SelectedIndex == 4)
            {
                comboBox7.Visible = false;
                comboBox1.Visible = true;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;

            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox8.SelectedIndex == 0)
            {
                comboBox9.Visible = false;
                comboBox13.Visible = true;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox14.Visible = false;

            }
            if (comboBox8.SelectedIndex == 1)
            {
                comboBox14.Visible = false;
                comboBox12.Visible = true;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox13.Visible = false;
                comboBox9.Visible = false;

            }
            if (comboBox8.SelectedIndex == 2)
            {
                comboBox10.Visible = false;
                comboBox11.Visible = true;
                comboBox9.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;
                comboBox14.Visible = false;

            }
            if (comboBox8.SelectedIndex == 3)
            {
                comboBox9.Visible = false;
                comboBox10.Visible = true;
                comboBox14.Visible = false;
                comboBox13.Visible = false;
                comboBox12.Visible = false;
                comboBox11.Visible = false;

            }
            if (comboBox8.SelectedIndex == 4)
            {
                comboBox11.Visible = false;
                comboBox9.Visible = true;
                comboBox10.Visible = false;
                comboBox14.Visible = false;
                comboBox12.Visible = false;
                comboBox13.Visible = false;

            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "Account No")
            {
                textBox6.Text = "";
            }
        }
    }
}
