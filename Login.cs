using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBapplication;

namespace DB_Project
{
    public partial class Login : Form
    {
        int type;
        int username = 0;
        Controller controllerobj;
        public Login(int t)
        {
            // 1 for admin, 2 for user , 3 for gallery , 4 for artist
            InitializeComponent();
            controllerobj=new Controller();
            type = t;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter Username And Password");
            }
            else
            { 
                if (type == 1)
                {
                    int x = controllerobj.CheckAdminPass(Int32.Parse(textBox1.Text), textBox2.Text);
                    if(x==0)
                    { 
                        MessageBox.Show("Wrong password or username");
                    }
                    else
                    {
                        Admin f1 = new Admin(Int32.Parse(textBox1.Text));
                        f1.Show();
                        Close();
                    }
                }
                else if (type == 2)
                {
                    int x = controllerobj.CheckUserPass(Int32.Parse(textBox1.Text), textBox2.Text);
                    if (x == 0)
                    {
                        MessageBox.Show("Wrong password or username");
                    }
                    else
                    {
                        User f1 = new User(Int32.Parse(textBox1.Text));
                        f1.Show();
                        Close();
                    }
                }
                else if (type == 3)
                {
                    int x = controllerobj.CheckGalleryPass(Int32.Parse(textBox1.Text), textBox2.Text);
                    if (x == 0)
                    {
                        MessageBox.Show("Wrong password or username");
                    }
                    else
                    {
                        Gallery f1 = new Gallery(Int32.Parse(textBox1.Text));
                        f1.Show();
                        Close();
                    }
                }
                else if (type == 4)
                {
                    int x = controllerobj.CheckArtistPass(Int32.Parse(textBox1.Text), textBox2.Text);
                    if (x == 0)
                    {
                        MessageBox.Show("Wrong password or username");
                    }
                    else
                    {
                        Artist f1 = new Artist(Int32.Parse(textBox1.Text));
                        f1.Show();
                        Close();
                    }
                }
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
                    Close();
                }
                else if (type == 2)
                {
                    ChangePassword f1 = new ChangePassword(type, Int32.Parse(textBox1.Text));
                    f1.Show();
                    Close();
                }
                else if (type == 3)
                {
                    ChangePassword f1 = new ChangePassword(type, Int32.Parse(textBox1.Text));
                    f1.Show();
                    Close();
                }
                else if (type == 4)
                {
                    ChangePassword f1 = new ChangePassword(type, Int32.Parse(textBox1.Text));
                    f1.Show();
                    Close() ;
                }

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
