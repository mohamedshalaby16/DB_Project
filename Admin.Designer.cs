namespace DB_Project
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gallerycb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adminid = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.insertadmin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RatingsButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PriceButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Namecb = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.Statuscb = new System.Windows.Forms.ComboBox();
            this.SetButton = new System.Windows.Forms.Button();
            this.PendingBtn = new System.Windows.Forms.Button();
            this.NumPendingtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 379);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(326, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gallery";
            // 
            // gallerycb
            // 
            this.gallerycb.FormattingEnabled = true;
            this.gallerycb.Location = new System.Drawing.Point(77, 284);
            this.gallerycb.Name = "gallerycb";
            this.gallerycb.Size = new System.Drawing.Size(434, 24);
            this.gallerycb.TabIndex = 2;
            this.gallerycb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "AdminID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // adminid
            // 
            this.adminid.Location = new System.Drawing.Point(122, 33);
            this.adminid.Name = "adminid";
            this.adminid.Size = new System.Drawing.Size(100, 22);
            this.adminid.TabIndex = 5;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(122, 89);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 22);
            this.password.TabIndex = 6;
            // 
            // insertadmin
            // 
            this.insertadmin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.insertadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertadmin.Location = new System.Drawing.Point(62, 141);
            this.insertadmin.Name = "insertadmin";
            this.insertadmin.Size = new System.Drawing.Size(125, 35);
            this.insertadmin.TabIndex = 7;
            this.insertadmin.Text = "Insert Admin";
            this.insertadmin.UseVisualStyleBackColor = false;
            this.insertadmin.Click += new System.EventHandler(this.insertadmin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gallery Information";
            // 
            // RatingsButton
            // 
            this.RatingsButton.Location = new System.Drawing.Point(12, 325);
            this.RatingsButton.Name = "RatingsButton";
            this.RatingsButton.Size = new System.Drawing.Size(141, 38);
            this.RatingsButton.TabIndex = 9;
            this.RatingsButton.Text = "Show Ratings";
            this.RatingsButton.UseVisualStyleBackColor = true;
            this.RatingsButton.Click += new System.EventHandler(this.RatingsButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(431, 379);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(345, 194);
            this.dataGridView2.TabIndex = 10;
            // 
            // PriceButton
            // 
            this.PriceButton.Location = new System.Drawing.Point(431, 325);
            this.PriceButton.Name = "PriceButton";
            this.PriceButton.Size = new System.Drawing.Size(202, 38);
            this.PriceButton.TabIndex = 11;
            this.PriceButton.Text = "Show Average Selling Price";
            this.PriceButton.UseVisualStyleBackColor = true;
            this.PriceButton.Click += new System.EventHandler(this.PriceButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 624);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Request Handling";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 661);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "User Name";
            // 
            // Namecb
            // 
            this.Namecb.FormattingEnabled = true;
            this.Namecb.Location = new System.Drawing.Point(122, 658);
            this.Namecb.Name = "Namecb";
            this.Namecb.Size = new System.Drawing.Size(216, 24);
            this.Namecb.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 702);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Set Status";
            // 
            // Statuscb
            // 
            this.Statuscb.FormattingEnabled = true;
            this.Statuscb.Items.AddRange(new object[] {
            "Approved",
            "Rejected ",
            "Pending"});
            this.Statuscb.Location = new System.Drawing.Point(122, 699);
            this.Statuscb.Name = "Statuscb";
            this.Statuscb.Size = new System.Drawing.Size(216, 24);
            this.Statuscb.TabIndex = 16;
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(22, 743);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(141, 38);
            this.SetButton.TabIndex = 17;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // PendingBtn
            // 
            this.PendingBtn.Location = new System.Drawing.Point(396, 658);
            this.PendingBtn.Name = "PendingBtn";
            this.PendingBtn.Size = new System.Drawing.Size(172, 53);
            this.PendingBtn.TabIndex = 19;
            this.PendingBtn.Text = "Show Count of Pending Requests";
            this.PendingBtn.UseVisualStyleBackColor = true;
            this.PendingBtn.Click += new System.EventHandler(this.PendingBtn_Click);
            // 
            // NumPendingtxt
            // 
            this.NumPendingtxt.Location = new System.Drawing.Point(585, 673);
            this.NumPendingtxt.Name = "NumPendingtxt";
            this.NumPendingtxt.Size = new System.Drawing.Size(100, 22);
            this.NumPendingtxt.TabIndex = 20;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 968);
            this.Controls.Add(this.NumPendingtxt);
            this.Controls.Add(this.PendingBtn);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.Statuscb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Namecb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PriceButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.RatingsButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.insertadmin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.adminid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gallerycb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox gallerycb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminid;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button insertadmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RatingsButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button PriceButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Namecb;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Statuscb;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Button PendingBtn;
        private System.Windows.Forms.TextBox NumPendingtxt;
    }
}