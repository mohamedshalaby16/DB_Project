using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class Login : Form
    {
        int type;
        int username = 0;
        public Login(int t)
        {
            // 1 for admin, 2 for user , 3 for gallery , 4 for artist
            InitializeComponent();
            type = t;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (type == 1)
            {
                Admin f1 = new Admin(Int32.Parse(textBox1.Text));
                f1.Show();
            }
            else if (type == 2)
            {
                User f1 = new User(Int32.Parse(textBox1.Text));
                f1.Show();
            }
            else if (type == 3)
            {
                Gallery f1 = new Gallery(Int32.Parse(textBox1.Text));
                f1.Show();
            }
            else if (type == 4)
            {
                Artist f1 = new Artist(Int32.Parse(textBox1.Text));
                f1.Show();
            }
        }

        private void ChangePassButton_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Username");
            }
            else
            {
                if (type == 1)
                {
                    ChangePassword f1 = new ChangePassword(type, Int32.Parse(textBox1.Text));
                    f1.Show();
                }
                else if (type == 2)
                {
                    ChangePassword f1 = new ChangePassword(type, Int32.Parse(textBox1.Text));
                    f1.Show();
                }
                else if (type == 3)
                {
                    ChangePassword f1 = new ChangePassword(type, Int32.Parse(textBox1.Text));
                    f1.Show();
                }
                else if (type == 4)
                {
                    ChangePassword f1 = new ChangePassword(type, Int32.Parse(textBox1.Text));
                    f1.Show();
                }

            }
        }
    }
}
