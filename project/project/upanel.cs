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
    public partial class upanel : Form
    {
        public upanel()
        {
            InitializeComponent();
        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Upanel_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=DESKTOP-T41SL57\SQLEXPRESS;Initial Catalog=AirLineReservationSystem;Integrated Security=True;";
            using (connection)
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from BookingNew WHERE BookerId = '" + MainForm.LoginUid.ToString() + "'",connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds,"BookingNew");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "BookingNew";


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm MainformRunner = new MainForm();
            this.Hide();
            MainformRunner.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Booking BookingRunner = new Booking();
            this.Hide();
            BookingRunner.Show();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
             upanel tester = new upanel();
             this.Close();
             tester.Show();
           
        }
    }
}
