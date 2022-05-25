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
    public partial class AddEditRentalRecords : Form
    {
        private bool iseditmode;

        private ManageRentalRecord _manageRentalRecord;
        #region part-2 After Importing DB using ADO.NET framework/ Implementing the Object field here and Instanciation it in the Constructot of this class


        private readonly CarRentalSystemEntities1 _db;
        public AddEditRentalRecords(ManageRentalRecord manageRentalRecord=null)
        {
            InitializeComponent();
            lblCarRentalSystem.Text = "Add New Rental";
            this.Text = "Add New Rental Record";
            iseditmode = false;
            _manageRentalRecord = manageRentalRecord;
            _db = new CarRentalSystemEntities1();
            
        }

        public AddEditRentalRecords(CarRentalRecord recordtoEdit,ManageRentalRecord manageRentalRecord=null)
        {
            InitializeComponent();
            lblCarRentalSystem.Text = "Edit Rental Record";
            this.Text = "Edit Rental Record";
            _manageRentalRecord = manageRentalRecord;
            
            if (recordtoEdit == null)
            {
                MessageBox.Show("Please ensure you have selected a valid record to Edit");
                Close();
            }

            else
            {
                iseditmode = true;
                _db = new CarRentalSystemEntities1();
                populateField(recordtoEdit);

            }
            
        }
        private void populateField(CarRentalRecord recordtoEdit)
        {
             tbCustomerName.Text=recordtoEdit.CustomerName;
             dtpDateRented.Value = (DateTime)recordtoEdit.DateRented;
             dtpDateofReturn.Value = (DateTime)recordtoEdit.DateReturned;
             tbCost.Text = recordtoEdit.Cost.ToString();
             lblRecordId.Text = recordtoEdit.ID.ToString();//important line video-46(34:29)
        }

        #endregion

        #region part-1 - Creation of Form and Setting some Functions to Submit Button using-Click Event
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string CustomerName = tbCustomerName.Text; //(*)
                var OutDate = dtpDateRented.Value;
                var InDate = dtpDateofReturn.Value;
                double Cost = Convert.ToDouble(tbCost.Text);

                var CarModel = cmbCarModel.Text;
                var isValid = true;
                string ErrorMessage = "";   //local Variables

                if(string.IsNullOrWhiteSpace(CustomerName) || string.IsNullOrWhiteSpace(CarModel))
                {
                    isValid = false;
                    ErrorMessage += "Please Enter details on Customer name and Car Model \n\r";
                }

                if (OutDate>InDate)
                {
                    isValid = false;
                    ErrorMessage += "Illegal Date Selection \n\r";
                }

                #endregion

                #region part-3 Submit to Database from form

                #region Before ReFactoring (46.video (37:13))
                //if(isvalid == true) or
                //if (isValid)
                //{
                //            if (iseditmode)
                //            {
                //                var id = int.Parse(lblRecordId.Text);//select Id from the form (invisible lable)
                // /*if scope*/   var rentalRecords = _db.CarRentalRecord.FirstOrDefault(q => q.ID == id); // retrieve the id from database        
                //                rentalRecords.ID = id;   
                //                rentalRecords.CustomerName = CustomerName;
                //                rentalRecords.DateRented = OutDate;
                //                rentalRecords.DateReturned = InDate;
                //                rentalRecords.Cost = (Decimal)Cost;
                //                rentalRecords.TypeofCarId = (int)cmbCarModel.SelectedValue;

                //                MessageBox.Show($"Hi {CustomerName} \n\r" +
                //                    $"Car Rented Date : {OutDate} \n\r" +
                //                    $"Car Return Date : {InDate} \n\r" +
                //                    $"Car Cost : {Cost} \n\r" +
                //                    $"Selected Car : {CarModel} \n\r" +
                //                    $"THANK YOU FOR HAVING BUSINESS.");
                //            }
                //            else
                //            {
                //                ////creation of Instance(Object) for the data table (RentalRecords) in our DB(see entity Diagram(CarRentalDB.edmx))
                ///*else scope*/  var RentalRecords = new CarRentalRecord();
                //                ////Assiging the Columns of the DB to the local variable assigned here (*)
                //                RentalRecords.CustomerName = CustomerName;
                //                RentalRecords.DateRented = OutDate;
                //                RentalRecords.DateReturned = InDate;
                //                RentalRecords.Cost = (Decimal)Cost;
                //                RentalRecords.TypeofCarId = (int)cmbCarModel.SelectedValue;

                //                ////Calling the whole Enitity (CarRentalSystemEntities) and adding data to its object table (CarRentalRecord)
                //                _db.CarRentalRecord.Add(RentalRecords);
                //                _db.SaveChanges();
                //            }
                //            #endregion

                //            MessageBox.Show($"Hi {CustomerName} \n\r" +
                //                        $"Car Rented Date : {OutDate} \n\r" +
                //                        $"Car Return Date : {InDate} \n\r" +
                //                        $"Car Cost : {Cost} \n\r" +
                //                        $"Selected Car : {CarModel} \n\r" +
                //                        $"THANK YOU FOR HAVING BUSINESS."); 
                //        }
                //        else
                //        {
                //            MessageBox.Show(ErrorMessage);
                //        }
                #endregion

                #region After Refactoring (46.Video (39:34))

                if (isValid)
                {

                    //Declare an Object of the Record to be added
                    var RentalRecords = new CarRentalRecord();
                    if (iseditmode)
                    {


                        //If (ISEDITMODE) retrive the id from the form and search for the record in the table and place the result in 
                        //the record object
                        var id = int.Parse(lblRecordId.Text);
                        RentalRecords = _db.CarRentalRecord.FirstOrDefault(q => q.ID == id);

                    }

                    //populate record object with values from the form
                    RentalRecords.CustomerName = CustomerName;
                    RentalRecords.DateRented = OutDate;
                    RentalRecords.DateReturned = InDate;
                    RentalRecords.Cost = (decimal)Cost;
                    RentalRecords.TypeofCarId = (int)cmbCarModel.SelectedValue;

                    //if not edit mode add the record object to the database.
                    if (!iseditmode)
                        _db.CarRentalRecord.Add(RentalRecords);

                    //Save changes made to the entity
                    _db.SaveChanges();
                    _manageRentalRecord.PopulateGrid();


                    MessageBox.Show($"Hi {CustomerName} \n\r" +
                            $"Car Rented Date : {OutDate} \n\r" +
                            $"Car Return Date : {InDate} \n\r" +
                            $"Car Cost : {Cost} \n\r" +
                            $"Selected Car : {CarModel} \n\r" +
                            $"THANK YOU FOR HAVING BUSINESS.");
                    Close();

                }
                else
                {
                    MessageBox.Show(ErrorMessage);
                }

                
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                //throw;
            }

        }
        #endregion

        #region part-2.1 -continued- Creating form load event from form.design and assigning the data from DB TYPESOFCARS -- when the form loads now the datawill be shown
        private void Form1_Load(object sender, EventArgs e)
        {
            //getting whole table like SELECT * FROM TypesOfCars          /
            //  var cars = carRentalSystemEntities.TypesOfCars.ToList(); /    ......this happend (1)

            //same Query we used in managevehiclelisting load event - here to the combobox for the load event (NOTE: Name property here is only called below
            // of cmbcarmodel.displaymember="Name" )
            var cars = _db.TypesOfCars.Select(q => new {Id=q.Id,Name=q.Make+" "+q.Model }).ToList();    

            cmbCarModel.DisplayMember = "Name";//assigning the Name column of TypeOfCar DB to Combo box of the Form.design
            cmbCarModel.ValueMember = "id"; // Setting values {Id} column to the combo box since it cannot read names
            cmbCarModel.DataSource = cars; // assignig the DataSource as Car variable created.
            //now if the form loads.. it loads with the data in combo box directly from the DB.
        }

        #endregion

        
    }
}
