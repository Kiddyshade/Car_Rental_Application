using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ManageRentalRecord : Form
    {
        private readonly CarRentalSystemEntities1 _db;
        public ManageRentalRecord()
        {
            InitializeComponent();
            Text = "Manage Rental Records";
            lblManageRentalRecord.Text = "Manage Rental Records";
            _db = new CarRentalSystemEntities1();
        }

        private void ManageRentalRecord_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid(); // Data Table rows and columns will be available on dataGrid
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex.InnerException.Message);
            }
        }

        public void PopulateGrid()
        {
            var records = _db.CarRentalRecord.Select(q => new
            {
                Id = q.ID,
                CustomerName = q.CustomerName,
                DateOut = q.DateRented,
                DateIn = q.DateReturned,
                Cost = q.Cost,
                Car = q.TypesOfCars.Make + " " + q.TypesOfCars.Model
            }).ToList();
            dgvRentalRecord.DataSource = records;
            dgvRentalRecord.Columns["DateOut"].HeaderText = "Date Out";
            dgvRentalRecord.Columns["DateIn"].HeaderText = "Date In";
            dgvRentalRecord.Columns["Id"].Visible = false;

        }

        private void btnAddVehicleRecord_Click(object sender, EventArgs e)
        {
            
            
                var addRentalRecords = new AddEditRentalRecords(this);
                {
                    MdiParent = this.MdiParent;               // new way of representing MDI parent using Intellisence
                }

                addRentalRecords.Show(); 
            
        }

        private void btnEditVehicleRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //Select Id of the Selected Row
                var id = (int)dgvRentalRecord.SelectedRows[0].Cells["Id"].Value;
                //Search the above Id in the database Table (CarRentalRecords)
                var record = _db.CarRentalRecord.FirstOrDefault(q => q.ID == id);
                var addEditRentalRecords = new AddEditRentalRecords(record,this);
                addEditRentalRecords.MdiParent=this.MdiParent;
                addEditRentalRecords.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Please select a row to Edit : "+ex.Message);
            }
        }

        private void btnDeleteVehicleRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //Select Id of the Selected Row
                var id = (int)dgvRentalRecord.SelectedRows[0].Cells["Id"].Value;
                //Search the above Id in the database Table (CarRentalRecords)
                var record = _db.CarRentalRecord.FirstOrDefault(q => q.ID == id);
                DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete This Record?",
                        "Delete", MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    _db.CarRentalRecord.Remove(record);
                    _db.SaveChanges();
                    PopulateGrid();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: "+ex.Message);
            }
            
            
        }

       


    }
}
