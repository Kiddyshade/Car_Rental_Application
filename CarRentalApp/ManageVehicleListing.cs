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
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalSystemEntities1 _db; //1.naming database entities as _db 
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalSystemEntities1();  // 2.calling _db inside the Constructor
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e) //3.when this form loads the database tables from SQL server will appear
            //inside the data grid view
        {
            //SELECT * FROM TypesOfCars                      /        
            // var cars = _db.TypesOfCars.ToList();         /         .... this happend (1)

            //SELECT * id as CarID,Name as CarName from TypesofCar                                           /
            //using LINQ in c# for the above Query as below                                                 /  
            //4.Select ID,Name Column alone from TypesOFcars table                                         /
            //var cars = _db.TypesOfCars.Select(q => new { CarId = q.ID, CarName = q.Name }).ToList();    /
            // by using CarID,CarName Alias and adding it to list.                                       /    ... then this happend (2)

            //Selecting the Modified Columns from the database                                                                             /
            //var cars = _db.TypesOfCars.Select(q => new                                                                                   /
            //{                                                                                                                            /
            //    Make = q.Make,                                                                                                           /
            //    Model = q.Model,                                                                                                         /
            //    VIN = q.VIN,                                                                                                             /
            //    Year = q.Year,                                                                                                           /
            //    LisencePlateNumber = q.LisencePlateNumber,                                                                               /
            //    q.Id // Instead of Id = q.Id , we can assign simply q.Id itself since both side have same Name.                          /
            //}).ToList();                                                                                                                 /
            //                                                                                                                             /
            //dgvVechicleList.DataSource = cars; //5.now cars become the datasource for the datagridview named as 'dgvVechiclelist'        /
            //dgvVechicleList.Columns[4].HeaderText = "Lisence Plate Number";                                                              /
            //dgvVechicleList.Columns[5].Visible = false;                                                                                  /
            //dgvVechicleList.Columns[0].HeaderText = "ID";                                                                                /
            //dgvVechicleList.Columns[1].HeaderText = "NAME"; //6.just calling the column header and changing it's Name to uppercase.      /...then this happend (3)

            try
            {
                PopulateGrid(); // the above query method is used in some events so it is made as a method and inserted here.
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error "+ex.InnerException.Message);
            }
            
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            var addEditVehicles = new FrmAddEditVehicles(this);
            addEditVehicles.MdiParent = this.MdiParent; // the parent of addEditvehicle form is the parent of ManageVehicleListing form
                  //is your parent    =  my parent      // (ie. the Mainwindow form)
            addEditVehicles.Show();
        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Three actions to be performed here

                //get Id of the Selected Row
                var id = (int)dgvVechicleList.SelectedRows[0].Cells["Id"].Value;
                //get CarId by querying records of the database
                var carId = _db.TypesOfCars.FirstOrDefault(q => q.Id == id); //FirsorDefault represent wether it bring the first selected item from
                                                                             // the database table or it return default(NULL) value.
                                                                             //launch AddEditVehicle form with data
                var addEditVehicles = new FrmAddEditVehicles(carId,this);
                addEditVehicles.MdiParent = this.MdiParent; // the parent of addEditvehicle form is the parent of ManageVehicleListing form
                                                            //is your parent    =  my parent      // (ie. the Mainwindow form)
                addEditVehicles.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please Select a row to Edit " + ex.Message) ;
            }
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                //Three actions to be performed here

                //get Id of the Selected Row
                var id = (int)dgvVechicleList.SelectedRows[0].Cells["Id"].Value;
                //get CarId by querying records of the database
                var carId = _db.TypesOfCars.FirstOrDefault(q => q.Id == id); //FirsorDefault represent wether it bring the first selected item from
                                                                             // the database table or it return default(NULL) value

                //Dialog box shows when you want to delete a record with some validations
                DialogResult dr = MessageBox.Show("Do you want to Delete the Record?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    _db.TypesOfCars.Remove(carId);
                    _db.SaveChanges();
                }
                PopulateGrid();
                ////delete vehicle from the table
                // _db.TypesOfCars.Remove(carId);
                // _db.SaveChanges();
                // dgvVechicleList.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("You cannot delete the record which match the record in Manage Rental Records : "+ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Simple Refresh Option
            PopulateGrid(); 
        }

        public void PopulateGrid()
        {
            var cars = _db.TypesOfCars.Select(q => new
            {
                Make = q.Make,
                Model = q.Model,
                VIN = q.VIN,
                Year = q.Year,
                LisencePlateNumber = q.LisencePlateNumber,
                q.Id // Instead of Id = q.Id , we can assign simply q.Id itself since both side have same Name. 
            }).ToList();

            dgvVechicleList.DataSource = cars; //5.now cars become the datasource for the datagridview named as 'dgvVechiclelist'
            dgvVechicleList.Columns[4].HeaderText = "Lisence Plate Number";
            dgvVechicleList.Columns["Id"].Visible = false;
        }
    }
}
