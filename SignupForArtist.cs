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
    public partial class SignupForArtist : Form
    {
        Controller controllerobj;
        public SignupForArtist()
        {
            InitializeComponent();
            controllerobj = new Controller();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            if(idtxt.Text.Length!=0 || fnametxt.Text.Length != 0 || lnametxt.Text.Length != 0 || emailtxt.Text.Length != 0 || passtxt.Text.Length != 0 )
            {
                int x = controllerobj.InsertArtist(Int32.Parse(idtxt.Text), fnametxt.Text, lnametxt.Text, passtxt.Text, emailtxt.Text, nationalitytxt.Text);
                if(x == 0 )
                {
                    MessageBox.Show("Could not insert artist, use different ID or email and try again");
                }
                else
                {
                    MessageBox.Show("Artist added successfully");
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields before signing up!");
            }
        }

        private void SignupForArtist_Load(object sender, EventArgs e)
        {

        }
    }
}
