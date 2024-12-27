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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void signupuserbtn_Click(object sender, EventArgs e)
        {
            SignupForUser f1 = new SignupForUser();
            f1.Show();
        }

        private void signupgallerybtn_Click(object sender, EventArgs e)
        {
            SignupForGallery f1 = new SignupForGallery();
            f1.Show();
        }

        private void signupartistbtn_Click(object sender, EventArgs e)
        {
            SignupForArtist f1 = new SignupForArtist();
            f1.Show();
        }
    }
}
