
namespace Alinabil_ad0497
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblusername.Location = new System.Drawing.Point(46, 51);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(197, 48);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "User Name";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(249, 62);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(318, 37);
            this.txtusername.TabIndex = 1;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(46, 140);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(168, 48);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(249, 140);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(318, 37);
            this.txtpassword.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnlogin.Location = new System.Drawing.Point(279, 197);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(264, 93);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "login ";
            this.btnlogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Name = "Form1";
            this.Text = "SuperMarket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
    }
}

