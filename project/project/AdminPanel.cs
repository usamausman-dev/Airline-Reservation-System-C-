using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class AdminPanel : Form
    {
        
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MainForm MainFormRunner = new MainForm();
            this.Hide();
            MainFormRunner.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airLineReservationSystemDataSet1.Registeration' table. You can move, or remove it, as needed.
            this.registerationTableAdapter.Fill(this.airLineReservationSystemDataSet1.Registeration);
            // TODO: This line of code loads data into the 'airLineReservationSystemDataSet.Registeration' table. You can move, or remove it, as needed.


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
