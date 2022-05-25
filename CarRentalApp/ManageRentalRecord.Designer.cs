namespace CarRentalApp
{
    partial class ManageRentalRecord
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteVehicleRecord = new System.Windows.Forms.Button();
            this.btnEditVehicleRecord = new System.Windows.Forms.Button();
            this.btnAddVehicleRecord = new System.Windows.Forms.Button();
            this.lblManageRentalRecord = new System.Windows.Forms.Label();
            this.dgvRentalRecord = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(630, 382);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(103, 42);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDeleteVehicleRecord
            // 
            this.btnDeleteVehicleRecord.Location = new System.Drawing.Point(420, 382);
            this.btnDeleteVehicleRecord.Name = "btnDeleteVehicleRecord";
            this.btnDeleteVehicleRecord.Size = new System.Drawing.Size(124, 42);
            this.btnDeleteVehicleRecord.TabIndex = 3;
            this.btnDeleteVehicleRecord.Text = "Delete Vehicle Record";
            this.btnDeleteVehicleRecord.UseVisualStyleBackColor = true;
            this.btnDeleteVehicleRecord.Click += new System.EventHandler(this.btnDeleteVehicleRecord_Click);
            // 
            // btnEditVehicleRecord
            // 
            this.btnEditVehicleRecord.Location = new System.Drawing.Point(237, 382);
            this.btnEditVehicleRecord.Name = "btnEditVehicleRecord";
            this.btnEditVehicleRecord.Size = new System.Drawing.Size(124, 42);
            this.btnEditVehicleRecord.TabIndex = 2;
            this.btnEditVehicleRecord.Text = "Edit Vehicle Record";
            this.btnEditVehicleRecord.UseVisualStyleBackColor = true;
            this.btnEditVehicleRecord.Click += new System.EventHandler(this.btnEditVehicleRecord_Click);
            // 
            // btnAddVehicleRecord
            // 
            this.btnAddVehicleRecord.Location = new System.Drawing.Point(50, 382);
            this.btnAddVehicleRecord.Name = "btnAddVehicleRecord";
            this.btnAddVehicleRecord.Size = new System.Drawing.Size(124, 42);
            this.btnAddVehicleRecord.TabIndex = 1;
            this.btnAddVehicleRecord.Text = "Add Vehicle Record";
            this.btnAddVehicleRecord.UseVisualStyleBackColor = true;
            this.btnAddVehicleRecord.Click += new System.EventHandler(this.btnAddVehicleRecord_Click);
            // 
            // lblManageRentalRecord
            // 
            this.lblManageRentalRecord.AutoSize = true;
            this.lblManageRentalRecord.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageRentalRecord.Location = new System.Drawing.Point(94, 26);
            this.lblManageRentalRecord.Name = "lblManageRentalRecord";
            this.lblManageRentalRecord.Size = new System.Drawing.Size(0, 64);
            this.lblManageRentalRecord.TabIndex = 5;
            // 
            // dgvRentalRecord
            // 
            this.dgvRentalRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalRecord.Location = new System.Drawing.Point(-23, 98);
            this.dgvRentalRecord.Name = "dgvRentalRecord";
            this.dgvRentalRecord.Size = new System.Drawing.Size(847, 247);
            this.dgvRentalRecord.TabIndex = 4;
            // 
            // ManageRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteVehicleRecord);
            this.Controls.Add(this.btnEditVehicleRecord);
            this.Controls.Add(this.btnAddVehicleRecord);
            this.Controls.Add(this.lblManageRentalRecord);
            this.Controls.Add(this.dgvRentalRecord);
            this.Name = "ManageRentalRecord";
            this.Load += new System.EventHandler(this.ManageRentalRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteVehicleRecord;
        private System.Windows.Forms.Button btnEditVehicleRecord;
        private System.Windows.Forms.Button btnAddVehicleRecord;
        private System.Windows.Forms.Label lblManageRentalRecord;
        private System.Windows.Forms.DataGridView dgvRentalRecord;
    }
}