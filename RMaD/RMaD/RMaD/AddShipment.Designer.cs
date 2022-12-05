namespace RMaD
{
    partial class AddShipment
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
            this.lblTracking = new System.Windows.Forms.Label();
            this.lblCarrier = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblShipped = new System.Windows.Forms.Label();
            this.lblCreateShipment = new System.Windows.Forms.Label();
            this.mtbTracking = new System.Windows.Forms.MaskedTextBox();
            this.btnAddShipment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpShipped = new System.Windows.Forms.DateTimePicker();
            this.dtpArrival = new System.Windows.Forms.DateTimePicker();
            this.tbCarrierdpdn = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTracking
            // 
            this.lblTracking.AutoSize = true;
            this.lblTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTracking.Location = new System.Drawing.Point(116, 235);
            this.lblTracking.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTracking.Name = "lblTracking";
            this.lblTracking.Size = new System.Drawing.Size(283, 37);
            this.lblTracking.TabIndex = 0;
            this.lblTracking.Text = "Tracking Number: ";
            // 
            // lblCarrier
            // 
            this.lblCarrier.AutoSize = true;
            this.lblCarrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrier.Location = new System.Drawing.Point(116, 437);
            this.lblCarrier.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCarrier.Name = "lblCarrier";
            this.lblCarrier.Size = new System.Drawing.Size(133, 37);
            this.lblCarrier.TabIndex = 2;
            this.lblCarrier.Text = "Carrier: ";
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrival.Location = new System.Drawing.Point(116, 369);
            this.lblArrival.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(238, 37);
            this.lblArrival.TabIndex = 3;
            this.lblArrival.Text = "Date of Arrival: ";
            // 
            // lblShipped
            // 
            this.lblShipped.AutoSize = true;
            this.lblShipped.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipped.Location = new System.Drawing.Point(116, 302);
            this.lblShipped.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShipped.Name = "lblShipped";
            this.lblShipped.Size = new System.Drawing.Size(228, 37);
            this.lblShipped.TabIndex = 4;
            this.lblShipped.Text = "Date Shipped: ";
            // 
            // lblCreateShipment
            // 
            this.lblCreateShipment.AutoSize = true;
            this.lblCreateShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateShipment.Location = new System.Drawing.Point(320, 108);
            this.lblCreateShipment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCreateShipment.Name = "lblCreateShipment";
            this.lblCreateShipment.Size = new System.Drawing.Size(514, 73);
            this.lblCreateShipment.TabIndex = 5;
            this.lblCreateShipment.Text = "Create Shipment";
            // 
            // mtbTracking
            // 
            this.mtbTracking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTracking.Location = new System.Drawing.Point(462, 225);
            this.mtbTracking.Margin = new System.Windows.Forms.Padding(6);
            this.mtbTracking.Name = "mtbTracking";
            this.mtbTracking.Size = new System.Drawing.Size(512, 44);
            this.mtbTracking.TabIndex = 6;
            this.mtbTracking.ValidatingType = typeof(int);
            // 
            // btnAddShipment
            // 
            this.btnAddShipment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShipment.Location = new System.Drawing.Point(368, 569);
            this.btnAddShipment.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddShipment.Name = "btnAddShipment";
            this.btnAddShipment.Size = new System.Drawing.Size(190, 63);
            this.btnAddShipment.TabIndex = 7;
            this.btnAddShipment.Text = "Submit";
            this.btnAddShipment.UseVisualStyleBackColor = true;
            this.btnAddShipment.Click += new System.EventHandler(this.btnAddShipment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(570, 569);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 63);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dtpShipped
            // 
            this.dtpShipped.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShipped.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShipped.Location = new System.Drawing.Point(462, 292);
            this.dtpShipped.Margin = new System.Windows.Forms.Padding(6);
            this.dtpShipped.Name = "dtpShipped";
            this.dtpShipped.Size = new System.Drawing.Size(510, 44);
            this.dtpShipped.TabIndex = 9;
            this.dtpShipped.ValueChanged += new System.EventHandler(this.dtpShipped_ValueChanged);
            // 
            // dtpArrival
            // 
            this.dtpArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpArrival.Location = new System.Drawing.Point(462, 360);
            this.dtpArrival.Margin = new System.Windows.Forms.Padding(6);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Size = new System.Drawing.Size(510, 44);
            this.dtpArrival.TabIndex = 10;
            // 
            // tbCarrierdpdn
            // 
            this.tbCarrierdpdn.FormattingEnabled = true;
            this.tbCarrierdpdn.Location = new System.Drawing.Point(462, 437);
            this.tbCarrierdpdn.Name = "tbCarrierdpdn";
            this.tbCarrierdpdn.Size = new System.Drawing.Size(510, 33);
            this.tbCarrierdpdn.TabIndex = 12;
            // 
            // AddShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 806);
            this.Controls.Add(this.tbCarrierdpdn);
            this.Controls.Add(this.dtpArrival);
            this.Controls.Add(this.dtpShipped);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddShipment);
            this.Controls.Add(this.mtbTracking);
            this.Controls.Add(this.lblCreateShipment);
            this.Controls.Add(this.lblShipped);
            this.Controls.Add(this.lblArrival);
            this.Controls.Add(this.lblCarrier);
            this.Controls.Add(this.lblTracking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddShipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Shipment";
            this.Load += new System.EventHandler(this.AddShipment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTracking;
        private System.Windows.Forms.Label lblCarrier;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblShipped;
        private System.Windows.Forms.Label lblCreateShipment;
        private System.Windows.Forms.Button btnAddShipment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpShipped;
        private System.Windows.Forms.DateTimePicker dtpArrival;
        private System.Windows.Forms.ComboBox tbCarrierdpdn;
        private System.Windows.Forms.MaskedTextBox mtbTracking;
    }
}