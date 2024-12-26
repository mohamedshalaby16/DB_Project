namespace DB_Project
{
    partial class SignupForArtist
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
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nationalitytxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.lnametxt = new System.Windows.Forms.TextBox();
            this.fnametxt = new System.Windows.Forms.TextBox();
            this.signupbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(191, 31);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(192, 22);
            this.idtxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nationality:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password:";
            // 
            // nationalitytxt
            // 
            this.nationalitytxt.Location = new System.Drawing.Point(191, 288);
            this.nationalitytxt.Name = "nationalitytxt";
            this.nationalitytxt.Size = new System.Drawing.Size(188, 22);
            this.nationalitytxt.TabIndex = 7;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(191, 234);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(188, 22);
            this.passtxt.TabIndex = 8;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(191, 181);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(188, 22);
            this.emailtxt.TabIndex = 9;
            // 
            // lnametxt
            // 
            this.lnametxt.Location = new System.Drawing.Point(191, 121);
            this.lnametxt.Name = "lnametxt";
            this.lnametxt.Size = new System.Drawing.Size(188, 22);
            this.lnametxt.TabIndex = 10;
            // 
            // fnametxt
            // 
            this.fnametxt.Location = new System.Drawing.Point(191, 68);
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(188, 22);
            this.fnametxt.TabIndex = 11;
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.signupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.Location = new System.Drawing.Point(298, 360);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(196, 40);
            this.signupbtn.TabIndex = 12;
            this.signupbtn.Text = "Sign Up";
            this.signupbtn.UseVisualStyleBackColor = false;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // SignupForArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.fnametxt);
            this.Controls.Add(this.lnametxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.nationalitytxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label1);
            this.Name = "SignupForArtist";
            this.Text = "SignupForArtist";
            this.Load += new System.EventHandler(this.SignupForArtist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nationalitytxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox lnametxt;
        private System.Windows.Forms.TextBox fnametxt;
        private System.Windows.Forms.Button signupbtn;
    }
}