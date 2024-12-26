namespace DB_Project
{
    partial class ArtTrust
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
            this.AdminButton = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.GalleryButton = new System.Windows.Forms.Button();
            this.ArtistButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.Location = new System.Drawing.Point(60, 157);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(238, 49);
            this.AdminButton.TabIndex = 0;
            this.AdminButton.Text = "Login as Admin";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // UserButton
            // 
            this.UserButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.UserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserButton.Location = new System.Drawing.Point(494, 157);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(243, 52);
            this.UserButton.TabIndex = 1;
            this.UserButton.Text = "Login as User";
            this.UserButton.UseVisualStyleBackColor = false;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // GalleryButton
            // 
            this.GalleryButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GalleryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GalleryButton.Location = new System.Drawing.Point(60, 262);
            this.GalleryButton.Name = "GalleryButton";
            this.GalleryButton.Size = new System.Drawing.Size(238, 52);
            this.GalleryButton.TabIndex = 2;
            this.GalleryButton.Text = "Login as Gallery";
            this.GalleryButton.UseVisualStyleBackColor = false;
            this.GalleryButton.Click += new System.EventHandler(this.GalleryButton_Click);
            // 
            // ArtistButton
            // 
            this.ArtistButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ArtistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistButton.Location = new System.Drawing.Point(494, 262);
            this.ArtistButton.Name = "ArtistButton";
            this.ArtistButton.Size = new System.Drawing.Size(243, 52);
            this.ArtistButton.TabIndex = 3;
            this.ArtistButton.Text = "Login as Artist";
            this.ArtistButton.UseVisualStyleBackColor = false;
            this.ArtistButton.Click += new System.EventHandler(this.ArtistButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to ArtTrust";
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.Location = new System.Drawing.Point(276, 360);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(238, 52);
            this.SignUpButton.TabIndex = 5;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // ArtTrust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArtistButton);
            this.Controls.Add(this.GalleryButton);
            this.Controls.Add(this.UserButton);
            this.Controls.Add(this.AdminButton);
            this.Name = "ArtTrust";
            this.Text = "ArtTrust";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button GalleryButton;
        private System.Windows.Forms.Button ArtistButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignUpButton;
    }
}