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
    public partial class AdminLogin : Form
    {
        
        string[] Admin = { "UsmanAli", "MuhammadOsama", "ShahzadUmarBaig", "Zubair" };
        string[] Password = { "Usman001", "Osama007", "Shahzad4", "7ubair" };
        string temp;
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
            AdminPanel AdminPanelRunner = new AdminPanel();
            if (textBox1.Text == "Admin Name" && textBox2.Text == "Password")
            {
                MessageBox.Show("Please Input Your Credentials");
            }
            else if (textBox1.Text == Admin[0] && textBox2.Text == Password[0])
            {
                this.Hide();
                AdminPanelRunner.Show();
            }
            else if (textBox1.Text == Admin[1] && textBox2.Text == Password[1])
            {
                this.Hide();
                AdminPanelRunner.Show();
            }
            else if (textBox1.Text == Admin[2] && textBox2.Text == Password[2])
            {
                this.Hide();
                AdminPanelRunner.Show();
            }
            else if (textBox1.Text == Admin[3] && textBox2.Text == Password[3])
            {
                this.Hide();
                AdminPanelRunner.Show();
            }
            else
            {
                MessageBox.Show("You are not an Admin!");
                temp = textBox1.Text;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Admin Name")
            {
                textBox1.Text = "";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
            }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
            }
            if( textBox1.Text == "")
            {
                textBox1.Text = "Admin Name";
            }
        }

        private void LinkLabel1_Click(object sender, EventArgs e)
        {
            temp = textBox1.Text;
            linkLabel1.Visible = false;
            textBox3.Visible = true;
            linkLabel2.Visible = true;
            button3.Visible = true;
        }

        
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(temp == Admin[0])
            {
                Password[0] = textBox3.Text;
            }
            else if (temp == Admin[1])
            {
                Password[1] = textBox3.Text;
            }
            else if (temp == Admin[2])
            {
                Password[2] = textBox3.Text;
            }
            else
            {
                MessageBox.Show("This isn't an Admin!");
            }
            linkLabel1.Visible = true;
            textBox3.Visible = false;
            linkLabel2.Visible = false;
            button3.Visible = false;

        }

        private void TextBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
    }
}
