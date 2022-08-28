using System.Windows.Forms;

namespace InventoryStock
{
    partial class Login
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Signup = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.passl = new System.Windows.Forms.Label();
            this.userl = new System.Windows.Forms.Label();
            this.Signup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Signup
            // 
            this.Signup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Signup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Signup.Controls.Add(this.pictureBox1);
            this.Signup.Controls.Add(this.label1);
            this.Signup.Controls.Add(this.loginbtn);
            this.Signup.Controls.Add(this.pass);
            this.Signup.Controls.Add(this.username);
            this.Signup.Controls.Add(this.passl);
            this.Signup.Controls.Add(this.userl);
            this.Signup.Location = new System.Drawing.Point(89, 37);
            this.Signup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Signup.Name = "Signup";
            this.Signup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Signup.Size = new System.Drawing.Size(355, 295);
            this.Signup.TabIndex = 0;
            this.Signup.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::InventoryStock.Properties.Resources.adminn;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(171, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginbtn.Location = new System.Drawing.Point(133, 235);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(148, 33);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Continue";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // pass
            // 
            this.pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pass.Location = new System.Drawing.Point(133, 188);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(148, 22);
            this.pass.TabIndex = 4;
            // 
            // username
            // 
            this.username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username.Location = new System.Drawing.Point(133, 146);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(148, 22);
            this.username.TabIndex = 3;
            // 
            // passl
            // 
            this.passl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passl.AutoSize = true;
            this.passl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passl.Location = new System.Drawing.Point(52, 191);
            this.passl.Name = "passl";
            this.passl.Size = new System.Drawing.Size(72, 19);
            this.passl.TabIndex = 2;
            this.passl.Text = "Password";
            // 
            // userl
            // 
            this.userl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userl.AutoSize = true;
            this.userl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userl.Location = new System.Drawing.Point(47, 149);
            this.userl.Name = "userl";
            this.userl.Size = new System.Drawing.Size(77, 19);
            this.userl.TabIndex = 1;
            this.userl.Text = "Username";
            this.userl.Click += new System.EventHandler(this.label2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.Signup);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Elite Management";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Signup.ResumeLayout(false);
            this.Signup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox Signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passl;
        private System.Windows.Forms.Label userl;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.PictureBox pictureBox1;

  
    }
}

