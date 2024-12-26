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
    
    public partial class SignupForUser : Form
    {
        Controller controllerobj;
        public SignupForUser()
        {
            InitializeComponent();
            controllerobj = new Controller();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            if (idtxt.Text.Length != 0 || nametxt.Text.Length != 0 || emailtxt.Text.Length != 0 || passtxt.Text.Length != 0)
            {
                int x = controllerobj.InsertUser(Int32.Parse(idtxt.Text), passtxt.Text, nametxt.Text, emailtxt.Text);
                if (x == 0)
                {
                    MessageBox.Show("Could not insert User, use different ID or email and try again");
                }
                else
                {
                    MessageBox.Show("User added successfully");
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields before signing up!");
            }
        }

        private void SignupForUser_Load(object sender, EventArgs e)
        {
          
        }
    }
}
