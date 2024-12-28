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
            this.label6 = new System.Windows.Forms.Label();
            this.edate = new System.Windows.Forms.TextBox();
            this.sdate = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.Exhibitionid = new System.Windows.Forms.TextBox();
            this.artworkid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.artworkidnewtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.insertauctionbtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.highestauctionbtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ExhibitionID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "StartDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "EndDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "ArtworkID";
            // 
            // edate
            // 
            this.edate.Location = new System.Drawing.Point(154, 166);
            this.edate.Name = "edate";
            this.edate.Size = new System.Drawing.Size(100, 22);
            this.edate.TabIndex = 7;
            // 
            // sdate
            // 
            this.sdate.Location = new System.Drawing.Point(154, 127);
            this.sdate.Name = "sdate";
            this.sdate.Size = new System.Drawing.Size(100, 22);
            this.sdate.TabIndex = 8;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(154, 95);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 9;
            // 
            // Exhibitionid
            // 
            this.Exhibitionid.Location = new System.Drawing.Point(154, 59);
            this.Exhibitionid.Name = "Exhibitionid";
            this.Exhibitionid.Size = new System.Drawing.Size(100, 22);
            this.Exhibitionid.TabIndex = 10;
            // 
            // artworkid
            // 
            this.artworkid.Location = new System.Drawing.Point(154, 207);
            this.artworkid.Name = "artworkid";
            this.artworkid.Size = new System.Drawing.Size(100, 22);
            this.artworkid.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 244);
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
            this.button2.Location = new System.Drawing.Point(465, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "Show Exhibition";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Insert Auction House";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Selling Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "ArtworkID:";
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(124, 439);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(159, 22);
            this.pricetxt.TabIndex = 21;
            // 
            // artworkidnewtxt
            // 
            this.artworkidnewtxt.Location = new System.Drawing.Point(124, 408);
            this.artworkidnewtxt.Name = "artworkidnewtxt";
            this.artworkidnewtxt.Size = new System.Drawing.Size(159, 22);
            this.artworkidnewtxt.TabIndex = 22;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(124, 374);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(159, 22);
            this.nametxt.TabIndex = 23;
            // 
            // insertauctionbtn
            // 
            this.insertauctionbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.insertauctionbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertauctionbtn.Location = new System.Drawing.Point(40, 485);
            this.insertauctionbtn.Name = "insertauctionbtn";
            this.insertauctionbtn.Size = new System.Drawing.Size(188, 45);
            this.insertauctionbtn.TabIndex = 24;
            this.insertauctionbtn.Text = "Insert Auction House";
            this.insertauctionbtn.UseVisualStyleBackColor = false;
            this.insertauctionbtn.Click += new System.EventHandler(this.insertauctionbtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Insert Exhibition";
            // 
            // highestauctionbtn
            // 
            this.highestauctionbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.highestauctionbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestauctionbtn.Location = new System.Drawing.Point(465, 485);
            this.highestauctionbtn.Name = "highestauctionbtn";
            this.highestauctionbtn.Size = new System.Drawing.Size(188, 45);
            this.highestauctionbtn.TabIndex = 26;
            this.highestauctionbtn.Text = "Show Auctions Descendingly";
            this.highestauctionbtn.UseVisualStyleBackColor = false;
            this.highestauctionbtn.Click += new System.EventHandler(this.highestauctionbtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(329, 343);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(459, 127);
            this.dataGridView2.TabIndex = 27;
            // 
            // Gallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.highestauctionbtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.insertauctionbtn);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.artworkidnewtxt);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.artworkid);
            this.Controls.Add(this.Exhibitionid);
            this.Controls.Add(this.name);
            this.Controls.Add(this.sdate);
            this.Controls.Add(this.edate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Gallery";
            this.Text = "Gallery";
            this.Load += new System.EventHandler(this.Gallery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edate;
        private System.Windows.Forms.TextBox sdate;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox Exhibitionid;
        private System.Windows.Forms.TextBox artworkid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.TextBox artworkidnewtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Button insertauctionbtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button highestauctionbtn;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}