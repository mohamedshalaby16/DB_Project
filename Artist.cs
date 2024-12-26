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
        public Artist()
        {
            InitializeComponent();
            controllerobj = new Controller();
        }

        private void insertartworkbrn_Click(object sender, EventArgs e)
        {
            if(artistidtxt.Text.Length!=0 || artworkidtxt.Text.Length!=0 || titletxt.Text.Length != 0 ||datetxt.Text.Length!=0)
            {
                int x = controllerobj.AddArtwork(Int32.Parse(artworkidtxt.Text), titletxt.Text, dimtxt.Text, datetxt.Text, descriptiontxt.Text, Int32.Parse(artistidtxt.Text));
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
    }
}
