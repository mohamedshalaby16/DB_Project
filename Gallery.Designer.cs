namespace DB_Project
{
    partial class Gallery
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.galleryid = new System.Windows.Forms.TextBox();
            this.edate = new System.Windows.Forms.TextBox();
            this.sdate = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.Exhibitionid = new System.Windows.Forms.TextBox();
            this.artworkid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gallerycb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ExhibitionID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "StartDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "EndDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "GalleryID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "ArtworkID";
            // 
            // galleryid
            // 
            this.galleryid.Location = new System.Drawing.Point(150, 161);
            this.galleryid.Name = "galleryid";
            this.galleryid.Size = new System.Drawing.Size(100, 22);
            this.galleryid.TabIndex = 6;
            // 
            // edate
            // 
            this.edate.Location = new System.Drawing.Point(150, 116);
            this.edate.Name = "edate";
            this.edate.Size = new System.Drawing.Size(100, 22);
            this.edate.TabIndex = 7;
            // 
            // sdate
            // 
            this.sdate.Location = new System.Drawing.Point(150, 77);
            this.sdate.Name = "sdate";
            this.sdate.Size = new System.Drawing.Size(100, 22);
            this.sdate.TabIndex = 8;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(150, 45);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 9;
            // 
            // Exhibitionid
            // 
            this.Exhibitionid.Location = new System.Drawing.Point(150, 9);
            this.Exhibitionid.Name = "Exhibitionid";
            this.Exhibitionid.Size = new System.Drawing.Size(100, 22);
            this.Exhibitionid.TabIndex = 10;
            // 
            // artworkid
            // 
            this.artworkid.Location = new System.Drawing.Point(150, 208);
            this.artworkid.Name = "artworkid";
            this.artworkid.Size = new System.Drawing.Size(100, 22);
            this.artworkid.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(52, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 48);
            this.button1.TabIndex = 12;
            this.button1.Text = "Insert Exhibition";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(459, 203);
            this.dataGridView1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(471, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "Show Exhepidition";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Gallery";
            // 
            // gallerycb
            // 
            this.gallerycb.FormattingEnabled = true;
            this.gallerycb.Location = new System.Drawing.Point(599, 265);
            this.gallerycb.Name = "gallerycb";
            this.gallerycb.Size = new System.Drawing.Size(121, 24);
            this.gallerycb.TabIndex = 18;
            this.gallerycb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Gallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gallerycb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.artworkid);
            this.Controls.Add(this.Exhibitionid);
            this.Controls.Add(this.name);
            this.Controls.Add(this.sdate);
            this.Controls.Add(this.edate);
            this.Controls.Add(this.galleryid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Gallery";
            this.Text = "Gallery";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox galleryid;
        private System.Windows.Forms.TextBox edate;
        private System.Windows.Forms.TextBox sdate;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox Exhibitionid;
        private System.Windows.Forms.TextBox artworkid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox gallerycb;
    }
}