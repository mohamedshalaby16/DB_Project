using DBapplication;
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
    public partial class User : Form
    {
        int username;
        Controller controllerobj;
        public User(int u)
        {
            InitializeComponent();
            username = u;
            controllerobj = new Controller();
            DataTable dt = controllerobj.getArtworks();
            DataTable dt2 = controllerobj.getArtworksofuser(u);
            comboBox1.DataSource= dt;
            comboBox1.ValueMember = "ArtworkID";
            comboBox1.DisplayMember = "Title";
            comboBox3.DataSource = dt2;
            comboBox3.ValueMember = "ArtworkID";
            comboBox3.DisplayMember = "Title";
            comboBox4.DataSource = dt;
            comboBox4.ValueMember = "ArtworkID";
            comboBox4.DisplayMember = "Title";
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerobj.ViewOwnedArtworks(username);
            dataGridView1.Refresh();  
            if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No Owned Artworks", "Error", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = controllerobj.RequestVerification(username, Convert.ToInt32(comboBox4.SelectedValue), reqdate_textbox.Text, "Pending");
            if(x == 0)
            {
                MessageBox.Show("Could not Request", "Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Verification Requested", "Success", MessageBoxButtons.OK);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = controllerobj.giveFeedback(username, Convert.ToInt32(comboBox1.SelectedValue), Feedback_textbox.Text, Convert.ToInt32(comboBox2.Text));
            if (x == 0)
            {
                MessageBox.Show("Could not Give Feedback", "Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Feedback Submitted", "Success", MessageBoxButtons.OK);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = controllerobj.getRequestStatus(username,Convert.ToInt32(comboBox3.SelectedValue));
            dataGridView2.Refresh();
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("No Owned Artworks", "Error", MessageBoxButtons.OK);
            }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
