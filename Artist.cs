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
    public partial class Artist : Form
    {
        Controller controllerobj;
        int username;
        public Artist(int u)
        {
            InitializeComponent();
            controllerobj = new Controller();
            username = u;


        }

        private void insertartworkbrn_Click(object sender, EventArgs e)
        {
            if(artworkidtxt.Text.Length!=0 || titletxt.Text.Length != 0 ||datetxt.Text.Length!=0)
            {
                int x = controllerobj.AddArtwork(Int32.Parse(artworkidtxt.Text), titletxt.Text, dimtxt.Text, datetxt.Text, descriptiontxt.Text, username);
                if (x == 0)
                {
                    MessageBox.Show("Could not insert Artwork, use existing artist ID and different artwork ID");
                }
                else
                {
                    MessageBox.Show("Artwork added successfully");
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields before clicking insert");
            }
        }

        private void showartwork_Click(object sender, EventArgs e)
        {
          
            dataGridView1.DataSource = controllerobj.ShowArtworks(username);
            dataGridView1.Refresh();
        }

        private void Updateinfobtn_Click(object sender, EventArgs e)
        {
            int x = controllerobj.UpdateArtistProfile(Emailtxt.Text, Nationtxt.Text, username);
            if(x == 0)
            {
                MessageBox.Show("Not Updated");
            }
            else
            {
                MessageBox.Show("Updated");
            }
        }

        private void ShowBuyer_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource=controllerobj.ShowHighestBuyer(username);
            dataGridView2.Refresh();
        }

        private void Artist_Load(object sender, EventArgs e)
        {

        }
    }
}
