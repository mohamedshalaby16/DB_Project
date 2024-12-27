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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
