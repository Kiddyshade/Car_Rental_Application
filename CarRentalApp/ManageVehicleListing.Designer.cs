namespace CarRentalApp
{
    partial class ManageVehicleListing
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
            this.dgvVechicleList = new System.Windows.Forms.DataGridView();
            this.lblManageVechicleListing = new System.Windows.Forms.Label();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnEditVehicle = new System.Windows.Forms.Button();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVechicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVechicleList
            // 
            this.dgvVechicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVechicleList.Location = new System.Drawing.Point(-2, 81);
            this.dgvVechicleList.Name = "dgvVechicleList";
            this.dgvVechicleList.Size = new System.Drawing.Size(847, 247);
            this.dgvVechicleList.TabIndex = 0;
            // 
            // lblManageVechicleListing
            // 
            this.lblManageVechicleListing.AutoSize = true;
            this.lblManageVechicleListing.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageVechicleListing.Location = new System.Drawing.Point(115, 9);
            this.lblManageVechicleListing.Name = "lblManageVechicleListing";
            this.lblManageVechicleListing.Size = new System.Drawing.Size(611, 64);
            this.lblManageVechicleListing.TabIndex = 1;
            this.lblManageVechicleListing.Text = "Manage Vechicle Listing";
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(71, 365);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(124, 42);
            this.btnAddVehicle.TabIndex = 2;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnEditVehicle
            // 
            this.btnEditVehicle.Location = new System.Drawing.Point(258, 365);
            this.btnEditVehicle.Name = "btnEditVehicle";
            this.btnEditVehicle.Size = new System.Drawing.Size(124, 42);
            this.btnEditVehicle.TabIndex = 3;
            this.btnEditVehicle.Text = "Edit Vehicle";
            this.btnEditVehicle.UseVisualStyleBackColor = true;
            this.btnEditVehicle.Click += new System.EventHandler(this.btnEditVehicle_Click);
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Location = new System.Drawing.Point(441, 365);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(124, 42);
            this.btnDeleteVehicle.TabIndex = 4;
            this.btnDeleteVehicle.Text = "Delete Vehicle";
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(651, 365);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(103, 42);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 485);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteVehicle);
            this.Controls.Add(this.btnEditVehicle);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.lblManageVechicleListing);
            this.Controls.Add(this.dgvVechicleList);
            this.Name = "ManageVehicleListing";
            this.Text = "Manage Vehicle Listing";
            this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVechicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVechicleList;
        private System.Windows.Forms.Label lblManageVechicleListing;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnEditVehicle;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.Button btnRefresh;
    }
}