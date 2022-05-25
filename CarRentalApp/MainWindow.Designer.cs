namespace CarRentalApp
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.manageVechicleListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRentalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArchivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsvFormUserLogginAs = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1274, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVechicleListingToolStripMenuItem,
            this.manageRentalRecordsToolStripMenuItem,
            this.manageUsersToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1274, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // manageVechicleListingToolStripMenuItem
            // 
            this.manageVechicleListingToolStripMenuItem.Name = "manageVechicleListingToolStripMenuItem";
            this.manageVechicleListingToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.manageVechicleListingToolStripMenuItem.Text = "Manage Vechicle Listing";
            this.manageVechicleListingToolStripMenuItem.Click += new System.EventHandler(this.manageVechicleListingToolStripMenuItem_Click);
            // 
            // manageRentalRecordsToolStripMenuItem
            // 
            this.manageRentalRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRentalRecordsToolStripMenuItem,
            this.viewArchivesToolStripMenuItem});
            this.manageRentalRecordsToolStripMenuItem.Name = "manageRentalRecordsToolStripMenuItem";
            this.manageRentalRecordsToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.manageRentalRecordsToolStripMenuItem.Text = "Manage Rental Records";
            // 
            // AddRentalRecordsToolStripMenuItem
            // 
            this.AddRentalRecordsToolStripMenuItem.Name = "AddRentalRecordsToolStripMenuItem";
            this.AddRentalRecordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddRentalRecordsToolStripMenuItem.Text = "Add Rental Records";
            this.AddRentalRecordsToolStripMenuItem.Click += new System.EventHandler(this.manageRenToolStripMenuItem_Click);
            // 
            // viewArchivesToolStripMenuItem
            // 
            this.viewArchivesToolStripMenuItem.Name = "viewArchivesToolStripMenuItem";
            this.viewArchivesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewArchivesToolStripMenuItem.Text = "View Archives";
            this.viewArchivesToolStripMenuItem.Click += new System.EventHandler(this.viewArchivesToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsvFormUserLogginAs});
            this.statusStrip1.Location = new System.Drawing.Point(0, 794);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1274, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsvFormUserLogginAs
            // 
            this.tsvFormUserLogginAs.Name = "tsvFormUserLogginAs";
            this.tsvFormUserLogginAs.Size = new System.Drawing.Size(118, 17);
            this.tsvFormUserLogginAs.Text = "toolStripStatusLabel1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 816);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Car Rental Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem manageVechicleListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddRentalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArchivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsvFormUserLogginAs;
    }
}