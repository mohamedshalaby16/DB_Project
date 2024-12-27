namespace DB_Project
{
    partial class SignupForUser
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.signupbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(168, 27);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(168, 22);
            this.idtxt.TabIndex = 5;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(168, 189);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(168, 22);
            this.emailtxt.TabIndex = 6;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(168, 136);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(168, 22);
            this.nametxt.TabIndex = 7;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(168, 78);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(168, 22);
            this.passtxt.TabIndex = 8;
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.signupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.Location = new System.Drawing.Point(270, 293);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(256, 54);
            this.signupbtn.TabIndex = 9;
            this.signupbtn.Text = "Sign Up";
            this.signupbtn.UseVisualStyleBackColor = false;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // SignupForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "SignupForUser";
            this.Text = "SignupForUser";
            this.Load += new System.EventHandler(this.SignupForUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button signupbtn;
    }
}