using System.Drawing;

namespace RMaD
{
    partial class RMaD
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.llHelp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSubmit.Location = new System.Drawing.Point(218, 232);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(102, 27);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(168, 130);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(211, 20);
            this.tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(167, 185);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(211, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Title.Location = new System.Drawing.Point(100, 39);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(351, 37);
            this.Title.TabIndex = 5;
            this.Title.Text = "Receiving Mail Daemon";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(150, 114);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(149, 169);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // llHelp
            // 
            this.llHelp.AutoSize = true;
            this.llHelp.Location = new System.Drawing.Point(255, 262);
            this.llHelp.Name = "llHelp";
            this.llHelp.Size = new System.Drawing.Size(29, 13);
            this.llHelp.TabIndex = 8;
            this.llHelp.TabStop = true;
            this.llHelp.Text = "Help";
            // 
            // RMaD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(537, 392);
            this.Controls.Add(this.llHelp);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btnSubmit);
            this.Name = "RMaD";
            this.Text = "Receiving Mail Daemon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel llHelp;
    }
}

