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
    public partial class Admin : Form
    {
        Controller controllerobj;
        int username;
        public Admin(int u)
        {
            InitializeComponent();
            controllerobj = new Controller();
            DataTable dt = controllerobj.ShowGallery();
            gallerycb.DataSource = dt;
            gallerycb.ValueMember = "GalleryID";
            gallerycb.DisplayMember = "Name";
            username = u;
            DataTable dt2 = controllerobj.PendingRequests();
            Namecb.DataSource = dt2;
            Namecb.ValueMember = "UserID";
            Namecb.DisplayMember = "Name";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void RatingsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerobj.HighestRated((Int32)gallerycb.SelectedValue);
            dataGridView1.Refresh();
        }

        private void PriceButton_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = controllerobj.AvgSellingPrice((Int32)gallerycb.SelectedValue);
            dataGridView2.Refresh();
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            int x=controllerobj.UpdateRequestStatus(Statuscb.Text, (Int32)Namecb.SelectedValue);
            if (x == 0) 
            {
                MessageBox.Show("Not Set");
            }
            else
            {
                MessageBox.Show("Status is Set");
            }

        }

        private void PendingBtn_Click(object sender, EventArgs e)
        {
           NumPendingtxt.Text = controllerobj.NumPending().ToString(); 
        }

        private void insertadmin_Click(object sender, EventArgs e)
        {
            bool exit = true;

            if(adminid.Text == "")
            {
                MessageBox.Show("No ID Entered");
                exit = false;
            }
            else if (!Int32.TryParse(adminid.Text,out int result))
            {
                MessageBox.Show("ID Must be integer value");
            }

            if(password.Text == "")
            {
                MessageBox.Show("No Password Entered");
                exit = false;
            }

            if (exit) 
            {
                int x = controllerobj.InsertAdmin(Int32.Parse(adminid.Text), password.Text);
                if (x == 0) 
                {
                    MessageBox.Show("Admin Not Added");
                }
                else
                {
                    
                    MessageBox.Show("Admin Added");
                }
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            ArtTrust f1 = new ArtTrust();
            f1.Show();
            Close();
        }
    }
}
