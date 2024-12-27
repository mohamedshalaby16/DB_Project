namespace DB_Project
{
    partial class Artist
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
            this.label7 = new System.Windows.Forms.Label();
            this.artworkidtxt = new System.Windows.Forms.TextBox();
            this.artistidtxt = new System.Windows.Forms.TextBox();
            this.descriptiontxt = new System.Windows.Forms.TextBox();
            this.datetxt = new System.Windows.Forms.TextBox();
            this.dimtxt = new System.Windows.Forms.TextBox();
            this.titletxt = new System.Windows.Forms.TextBox();
            this.insertartworkbrn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Artwork";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ArtworkID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Creation Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dimensions:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Title:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "ArtistID:";
            // 
            // artworkidtxt
            // 
            this.artworkidtxt.Location = new System.Drawing.Point(129, 45);
            this.artworkidtxt.Name = "artworkidtxt";
            this.artworkidtxt.Size = new System.Drawing.Size(183, 22);
            this.artworkidtxt.TabIndex = 7;
            // 
            // artistidtxt
            // 
            this.artistidtxt.Location = new System.Drawing.Point(129, 191);
            this.artistidtxt.Name = "artistidtxt";
            this.artistidtxt.Size = new System.Drawing.Size(183, 22);
            this.artistidtxt.TabIndex = 8;
            // 
            // descriptiontxt
            // 
            this.descriptiontxt.Location = new System.Drawing.Point(129, 161);
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.Size = new System.Drawing.Size(183, 22);
            this.descriptiontxt.TabIndex = 9;
            // 
            // datetxt
            // 
            this.datetxt.Location = new System.Drawing.Point(129, 133);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(183, 22);
            this.datetxt.TabIndex = 10;
            // 
            // dimtxt
            // 
            this.dimtxt.Location = new System.Drawing.Point(129, 105);
            this.dimtxt.Name = "dimtxt";
            this.dimtxt.Size = new System.Drawing.Size(183, 22);
            this.dimtxt.TabIndex = 11;
            // 
            // titletxt
            // 
            this.titletxt.Location = new System.Drawing.Point(129, 73);
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(183, 22);
            this.titletxt.TabIndex = 12;
            // 
            // insertartworkbrn
            // 
            this.insertartworkbrn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.insertartworkbrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertartworkbrn.Location = new System.Drawing.Point(28, 229);
            this.insertartworkbrn.Name = "insertartworkbrn";
            this.insertartworkbrn.Size = new System.Drawing.Size(209, 39);
            this.insertartworkbrn.TabIndex = 13;
            this.insertartworkbrn.Text = "Insert Artwork";
            this.insertartworkbrn.UseVisualStyleBackColor = false;
            this.insertartworkbrn.Click += new System.EventHandler(this.insertartworkbrn_Click);
            // 
            // Artist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insertartworkbrn);
            this.Controls.Add(this.titletxt);
            this.Controls.Add(this.dimtxt);
            this.Controls.Add(this.datetxt);
            this.Controls.Add(this.descriptiontxt);
            this.Controls.Add(this.artistidtxt);
            this.Controls.Add(this.artworkidtxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Artist";
            this.Text = "Artist";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox artworkidtxt;
        private System.Windows.Forms.TextBox artistidtxt;
        private System.Windows.Forms.TextBox descriptiontxt;
        private System.Windows.Forms.TextBox datetxt;
        private System.Windows.Forms.TextBox dimtxt;
        private System.Windows.Forms.TextBox titletxt;
        private System.Windows.Forms.Button insertartworkbrn;
    }
}