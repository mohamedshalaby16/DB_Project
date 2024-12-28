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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Project
{
    public partial class Gallery : Form
    {
        Controller controllerobj;
        int galleryid;
        public Gallery(int u)
        {
            InitializeComponent();
            controllerobj = new Controller();
            galleryid = u;
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Exhibitionid.Text.Length != 0 || artworkid.Text.Length != 0 || name.Text.Length != 0)
            {
                int x= controllerobj.AddExhibition(Int32.Parse(Exhibitionid.Text),name.Text,sdate.Text,edate.Text,galleryid,Int32.Parse(artworkid.Text));
                if (x == 0)
                {
                    MessageBox.Show("Could not insert Exhibition, use existing GalleryID and ArtworkID");
                }
                else
                {
                    MessageBox.Show("Exhibition added successfully");
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields before clicking insert");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Int32.Parse(gallerycb.SelectedValue.ToString())
            dataGridView1.DataSource = controllerobj.ShowExhibition(galleryid);
            dataGridView1.Refresh();
        }

        private void Gallery_Load(object sender, EventArgs e)
        {

        }

        private void insertauctionbtn_Click(object sender, EventArgs e)
        {
           if(artworkidnewtxt.Text !="" || nametxt.Text!=""|| pricetxt.Text!="")
           {
                int x = controllerobj.AddAuction(galleryid, Int32.Parse(artworkidnewtxt.Text), nametxt.Text, Int32.Parse(pricetxt.Text));
                if (x == 0)
                    MessageBox.Show("Could not add Auction House");
                else
                    MessageBox.Show("Auction House added successfully");

           }
            else
            {
                MessageBox.Show("Please fill all fields first");
            }
        }

        private void highestauctionbtn_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource=controllerobj.GetHighestAuction(galleryid);
            dataGridView2.Refresh();
            if(dataGridView2.Rows.Count==0)
            {
                MessageBox.Show("No Auctions were done for this gallery");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArtTrust f1= new ArtTrust();
            f1.Show();
            Close();
        }
    }
}
    