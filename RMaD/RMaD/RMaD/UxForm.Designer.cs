using RMaD.Classes;

namespace RMaD
{
    partial class UxForm
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
            this.user = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.tbTestUser = new System.Windows.Forms.TextBox();
            this.tbTestPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(141, 99);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(53, 13);
            this.user.TabIndex = 0;
            this.user.Text = "username";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(141, 162);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(52, 13);
            this.pass.TabIndex = 1;
            this.pass.Text = "password";
            // 
            // tbTestUser
            // 
            this.tbTestUser.Location = new System.Drawing.Point(275, 92);
            this.tbTestUser.Name = "tbTestUser";
            this.tbTestUser.Size = new System.Drawing.Size(100, 20);
            this.tbTestUser.TabIndex = 2;
            // 
            // tbTestPass
            // 
            this.tbTestPass.Location = new System.Drawing.Point(275, 162);
            this.tbTestPass.Name = "tbTestPass";
            this.tbTestPass.Size = new System.Drawing.Size(100, 20);
            this.tbTestPass.TabIndex = 3;
            // 
            // UxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 491);
            this.Controls.Add(this.tbTestPass);
            this.Controls.Add(this.tbTestUser);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Name = "UxForm";
            this.Text = "UxForm";
            this.Load += new System.EventHandler(this.UxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox tbTestUser;
        private System.Windows.Forms.TextBox tbTestPass;
    }
}