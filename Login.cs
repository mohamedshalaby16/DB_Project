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
    public partial class Login : Form
    {
        int type;
        public Login(int t)
        {
            // 1 for admin, 2 for user , 3 for gallery , 4 for artist
            InitializeComponent();
            type = t;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (type == 1)
            {
                Admin f1 = new Admin();
                f1.Show();
            }
            else if (type == 2)
            {
                User f1 = new User();
                f1.Show();
            }
            else if (type == 3)
            {
                Gallery f1 = new Gallery();
                f1.Show();
            }
            else if (type == 4)
            {
                Artist f1 = new Artist();
                f1.Show();
            }
        }

        private void ChangePassButton_Click(object sender, EventArgs e)
        {
            if (type == 1)
            {
                ChangePassword f1 = new ChangePassword(type);
                f1.Show();
            }
            else if (type == 2)
            {
               ChangePassword f1 = new ChangePassword(type);    
                f1.Show();
            }
            else if (type == 3)
            {
                ChangePassword f1 = new ChangePassword(type);
                f1.Show();
            }
            else if (type == 4)
            {
                ChangePassword f1 = new ChangePassword(type);
                f1.Show();
            }

        }
    }
}
