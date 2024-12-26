namespace DB_Project
{
    partial class SignupForGallery
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.locationtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.contactinfotxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.signuptxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 30);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact Info:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password:";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(259, 30);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(174, 22);
            this.idtxt.TabIndex = 6;
            // 
            // locationtxt
            // 
            this.locationtxt.Location = new System.Drawing.Point(259, 173);
            this.locationtxt.Name = "locationtxt";
            this.locationtxt.Size = new System.Drawing.Size(174, 22);
            this.locationtxt.TabIndex = 7;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(259, 131);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(174, 22);
            this.nametxt.TabIndex = 8;
            // 
            // contactinfotxt
            // 
            this.contactinfotxt.Location = new System.Drawing.Point(259, 222);
            this.contactinfotxt.Name = "contactinfotxt";
            this.contactinfotxt.Size = new System.Drawing.Size(174, 22);
            this.contactinfotxt.TabIndex = 9;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(259, 79);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(174, 22);
            this.passtxt.TabIndex = 10;
            // 
            // signuptxt
            // 
            this.signuptxt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.signuptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signuptxt.Location = new System.Drawing.Point(306, 306);
            this.signuptxt.Name = "signuptxt";
            this.signuptxt.Size = new System.Drawing.Size(209, 47);
            this.signuptxt.TabIndex = 11;
            this.signuptxt.Text = "Sign Up";
            this.signuptxt.UseVisualStyleBackColor = false;
            this.signuptxt.Click += new System.EventHandler(this.signuptxt_Click);
            // 
            // SignupForGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signuptxt);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.contactinfotxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.locationtxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignupForGallery";
            this.Text = "SignupForGallery";
            this.Load += new System.EventHandler(this.SignupForGallery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox locationtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox contactinfotxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button signuptxt;
    }
}