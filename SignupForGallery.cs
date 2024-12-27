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
    public partial class SignupForGallery : Form
    {
        Controller controllerobj;
        public SignupForGallery()
        {
            InitializeComponent();
            controllerobj = new Controller();
        }

        private void signuptxt_Click(object sender, EventArgs e)
        {
            if (idtxt.Text.Length != 0 || nametxt.Text.Length != 0 || passtxt.Text.Length != 0 || contactinfotxt.Text.Length != 0 || locationtxt.Text.Length != 0)
            {
                int x = controllerobj.InsertGallery(Int32.Parse(idtxt.Text), passtxt.Text, nametxt.Text, locationtxt.Text, contactinfotxt.Text);
                if (x == 0)
                {
                    MessageBox.Show("Could not insert gallery, use different ID or email and try again");
                }
                else
                {
                    MessageBox.Show("Gallery added successfully");
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields before signing up!");
            }
        }

        private void SignupForGallery_Load(object sender, EventArgs e)
        {

        }
    }
}
