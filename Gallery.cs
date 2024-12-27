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
        int username;
        public Gallery(int u)
        {
            InitializeComponent();
            controllerobj = new Controller();
            username = u;
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Exhibitionid.Text.Length != 0 || artworkid.Text.Length != 0 || galleryid.Text.Length != 0 || name.Text.Length != 0)
            {
                int x= controllerobj.AddExhibition(Int32.Parse(Exhibitionid.Text),name.Text,sdate.Text,edate.Text,Int32.Parse(galleryid.Text),Int32.Parse(artworkid.Text));
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
            dataGridView1.DataSource = controllerobj.ShowExhibition();
            dataGridView1.Refresh();
        }
    }
        }
    