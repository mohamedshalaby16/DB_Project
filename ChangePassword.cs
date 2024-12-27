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
    public partial class ChangePassword : Form
    {
        int type;
        int username = 0;
        Controller controllerobj;
        public ChangePassword(int t,int u)
        {
            // 1 for admin, 2 for user , 3 for gallery , 4 for artist
            InitializeComponent();
            type= t;
            username= u;
            controllerobj = new Controller();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if(newpass.Text=="")
            {
                MessageBox.Show("Enter New Password");
            }
            if (confirmpass.Text == "")
            {
                MessageBox.Show("Enter New Password");
            }
            if(confirmpass.Text != newpass.Text)
            {
                MessageBox.Show("Passwords Don't Match");
            }
            if (type == 1)
            {
                int x = controllerobj.ChangeAdminPass(newpass.Text, username);
                if (x == 0)
                {
                    MessageBox.Show("Password Not Changed");
                }
                else
                {
                    MessageBox.Show("Password Updated Successfully");
                }

            }
            if (type == 4)
            {
                int x = controllerobj.ChangeArtistPass(newpass.Text, username);
                if (x == 0)
                {
                    MessageBox.Show("Password Not Changed");
                }
                else
                {
                    MessageBox.Show("Password Updated Successfully");
                }

            }
            if (type == 2)
            {
                int x = controllerobj.ChangeUserPass(newpass.Text, username);
                if (x == 0)
                {
                    MessageBox.Show("Password Not Changed");
                }
                else
                {
                    MessageBox.Show("Password Updated Successfully");
                }

            }
            if (type == 3)
            {
                int x = controllerobj.ChangeGalleryPass(newpass.Text, username);
                if (x == 0)
                {
                    MessageBox.Show("Password Not Changed");
                }
                else
                {
                    MessageBox.Show("Password Updated Successfully");
                }

            }

        }
    }
}
