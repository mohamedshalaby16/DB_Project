namespace DB_Project
{
    partial class SignUp
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
            this.signupuserbtn = new System.Windows.Forms.Button();
            this.signupgallerybtn = new System.Windows.Forms.Button();
            this.signupartistbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signupuserbtn
            // 
            this.signupuserbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.signupuserbtn.Location = new System.Drawing.Point(329, 100);
            this.signupuserbtn.Name = "signupuserbtn";
            this.signupuserbtn.Size = new System.Drawing.Size(174, 59);
            this.signupuserbtn.TabIndex = 0;
            this.signupuserbtn.Text = "Sign Up as User";
            this.signupuserbtn.UseVisualStyleBackColor = false;
            this.signupuserbtn.Click += new System.EventHandler(this.signupuserbtn_Click);
            // 
            // signupgallerybtn
            // 
            this.signupgallerybtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.signupgallerybtn.Location = new System.Drawing.Point(329, 191);
            this.signupgallerybtn.Name = "signupgallerybtn";
            this.signupgallerybtn.Size = new System.Drawing.Size(174, 59);
            this.signupgallerybtn.TabIndex = 1;
            this.signupgallerybtn.Text = "Sign Up as Gallery";
            this.signupgallerybtn.UseVisualStyleBackColor = false;
            this.signupgallerybtn.Click += new System.EventHandler(this.signupgallerybtn_Click);
            // 
            // signupartistbtn
            // 
            this.signupartistbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.signupartistbtn.Location = new System.Drawing.Point(329, 276);
            this.signupartistbtn.Name = "signupartistbtn";
            this.signupartistbtn.Size = new System.Drawing.Size(174, 59);
            this.signupartistbtn.TabIndex = 2;
            this.signupartistbtn.Text = "Sign Up as Artist";
            this.signupartistbtn.UseVisualStyleBackColor = false;
            this.signupartistbtn.Click += new System.EventHandler(this.signupartistbtn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signupartistbtn);
            this.Controls.Add(this.signupgallerybtn);
            this.Controls.Add(this.signupuserbtn);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signupuserbtn;
        private System.Windows.Forms.Button signupgallerybtn;
        private System.Windows.Forms.Button signupartistbtn;
    }
}