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
            this.pnlShipments = new System.Windows.Forms.Panel();
            this.lblShipments = new System.Windows.Forms.Label();
            this.pnlGroups = new System.Windows.Forms.Panel();
            this.lblGroups = new System.Windows.Forms.Label();
            this.btnShipmentMenu = new System.Windows.Forms.Button();
            this.btnGroupMenu = new System.Windows.Forms.Button();
            this.btnReportsMenu = new System.Windows.Forms.Button();
            this.btnUserMenu = new System.Windows.Forms.Button();
            this.btnSettingsMenu = new System.Windows.Forms.Button();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.lblReports = new System.Windows.Forms.Label();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.lblSettins = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.pnlShipments.SuspendLayout();
            this.pnlGroups.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlShipments
            // 
            this.pnlShipments.Controls.Add(this.lblShipments);
            this.pnlShipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlShipments.Location = new System.Drawing.Point(77, 2);
            this.pnlShipments.Name = "pnlShipments";
            this.pnlShipments.Size = new System.Drawing.Size(550, 670);
            this.pnlShipments.TabIndex = 0;
            // 
            // lblShipments
            // 
            this.lblShipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipments.Location = new System.Drawing.Point(30, 27);
            this.lblShipments.Name = "lblShipments";
            this.lblShipments.Size = new System.Drawing.Size(180, 42);
            this.lblShipments.TabIndex = 0;
            this.lblShipments.Text = "Shipments";
            // 
            // pnlGroups
            // 
            this.pnlGroups.Controls.Add(this.lblGroups);
            this.pnlGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlGroups.Location = new System.Drawing.Point(77, 2);
            this.pnlGroups.Name = "pnlGroups";
            this.pnlGroups.Size = new System.Drawing.Size(550, 670);
            this.pnlGroups.TabIndex = 1;
            // 
            // lblGroups
            // 
            this.lblGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroups.Location = new System.Drawing.Point(30, 27);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(127, 42);
            this.lblGroups.TabIndex = 0;
            this.lblGroups.Text = "Groups";
            // 
            // btnShipmentMenu
            // 
            this.btnShipmentMenu.Location = new System.Drawing.Point(12, 12);
            this.btnShipmentMenu.Name = "btnShipmentMenu";
            this.btnShipmentMenu.Size = new System.Drawing.Size(59, 42);
            this.btnShipmentMenu.TabIndex = 1;
            this.btnShipmentMenu.Text = "Ship";
            this.btnShipmentMenu.UseVisualStyleBackColor = true;
            this.btnShipmentMenu.Click += new System.EventHandler(this.btnShipmentMenu_Click);
            // 
            // btnGroupMenu
            // 
            this.btnGroupMenu.Location = new System.Drawing.Point(12, 60);
            this.btnGroupMenu.Name = "btnGroupMenu";
            this.btnGroupMenu.Size = new System.Drawing.Size(59, 42);
            this.btnGroupMenu.TabIndex = 2;
            this.btnGroupMenu.Text = "Group";
            this.btnGroupMenu.UseVisualStyleBackColor = true;
            this.btnGroupMenu.Click += new System.EventHandler(this.btnGroupMenu_Click);
            // 
            // btnReportsMenu
            // 
            this.btnReportsMenu.Location = new System.Drawing.Point(12, 108);
            this.btnReportsMenu.Name = "btnReportsMenu";
            this.btnReportsMenu.Size = new System.Drawing.Size(59, 42);
            this.btnReportsMenu.TabIndex = 3;
            this.btnReportsMenu.Text = "Report";
            this.btnReportsMenu.UseVisualStyleBackColor = true;
            this.btnReportsMenu.Click += new System.EventHandler(this.btnReportsMenu_Click);
            // 
            // btnUserMenu
            // 
            this.btnUserMenu.Location = new System.Drawing.Point(12, 569);
            this.btnUserMenu.Name = "btnUserMenu";
            this.btnUserMenu.Size = new System.Drawing.Size(59, 42);
            this.btnUserMenu.TabIndex = 4;
            this.btnUserMenu.Text = "User";
            this.btnUserMenu.UseVisualStyleBackColor = true;
            this.btnUserMenu.Click += new System.EventHandler(this.btnUserMenu_Click);
            // 
            // btnSettingsMenu
            // 
            this.btnSettingsMenu.Location = new System.Drawing.Point(12, 618);
            this.btnSettingsMenu.Name = "btnSettingsMenu";
            this.btnSettingsMenu.Size = new System.Drawing.Size(59, 42);
            this.btnSettingsMenu.TabIndex = 5;
            this.btnSettingsMenu.Text = "Settings";
            this.btnSettingsMenu.UseVisualStyleBackColor = true;
            this.btnSettingsMenu.Click += new System.EventHandler(this.btnSettingsMenu_Click);
            // 
            // pnlReports
            // 
            this.pnlReports.Controls.Add(this.lblReports);
            this.pnlReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlReports.Location = new System.Drawing.Point(77, 2);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(550, 670);
            this.pnlReports.TabIndex = 2;
            // 
            // lblReports
            // 
            this.lblReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(30, 27);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(127, 42);
            this.lblReports.TabIndex = 0;
            this.lblReports.Text = "Reports";
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblUser);
            this.pnlUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUser.Location = new System.Drawing.Point(77, 2);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(550, 670);
            this.pnlUser.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(177, 165);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(176, 42);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username";
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.lblSettins);
            this.pnlSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSettings.Location = new System.Drawing.Point(77, 2);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(550, 670);
            this.pnlSettings.TabIndex = 4;
            // 
            // lblSettins
            // 
            this.lblSettins.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettins.Location = new System.Drawing.Point(30, 27);
            this.lblSettins.Name = "lblSettins";
            this.lblSettins.Size = new System.Drawing.Size(137, 42);
            this.lblSettins.TabIndex = 0;
            this.lblSettins.Text = "Settings";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // UxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 672);
            this.Controls.Add(this.btnSettingsMenu);
            this.Controls.Add(this.btnUserMenu);
            this.Controls.Add(this.btnReportsMenu);
            this.Controls.Add(this.btnGroupMenu);
            this.Controls.Add(this.btnShipmentMenu);
            this.Controls.Add(this.pnlShipments);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.pnlReports);
            this.Controls.Add(this.pnlGroups);
            this.Name = "UxForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UxForm_FormClosed);
            this.Load += new System.EventHandler(this.UxForm_Load);
            this.pnlShipments.ResumeLayout(false);
            this.pnlGroups.ResumeLayout(false);
            this.pnlReports.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShipments;
        private System.Windows.Forms.Label lblShipments;
        private System.Windows.Forms.Button btnShipmentMenu;
        private System.Windows.Forms.Button btnGroupMenu;
        private System.Windows.Forms.Button btnReportsMenu;
        private System.Windows.Forms.Button btnUserMenu;
        private System.Windows.Forms.Button btnSettingsMenu;
        private System.Windows.Forms.Panel pnlGroups;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label lblSettins;
        private System.Diagnostics.EventLog eventLog1;
    }
}