using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class ArtTrust : Form
    {
        public ArtTrust()
        {
            InitializeComponent();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            Login f1 = new Login(1);
            f1.Show();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            Login f1 = new Login(2);
            f1.Show();
        }

        private void GalleryButton_Click(object sender, EventArgs e)
        {
            Login f1 = new Login(3);
            f1.Show();
        }

        private void ArtistButton_Click(object sender, EventArgs e)
        {
            Login f1 = new Login(4);
            f1.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUp f1 = new SignUp();
            f1.Show();
        }
    }
}
