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
    public partial class FrmAddEditVehicles : Form
    {
        //creating instance of CarRentalEntities from ERD diagram
        private readonly CarRentalSystemEntities1 _db; // see the constructors(both) it will be instanciated their
        private ManageVehicleListing _manageVehicleListing; //object instanciated for auto refresh in ManageVehicleListing Datagrid(see both constructors here)
 

        //Introducing a Boolean Flag to switch between Add and Edit Action
        private bool iseditmode;

        //Constructor for Add Vechicle
        public FrmAddEditVehicles(ManageVehicleListing manageVehicleListing =null)
        {
            InitializeComponent(); //initiates all the components in the Current form.(by the way it is default method here.) 
            //when this Constructor is called the Label text will automatically show the following
            Text = "Add New Vehicle";
            lblTitle.Text = "Add Vehicle";
            iseditmode = false; //if add constructor is in add mode then iseditmode is set to false. followed by SaveChanges button.
            _manageVehicleListing = manageVehicleListing;
            _db = new CarRentalSystemEntities1();
        }

        //Overloaded-Constructor for Edit Vechicle
        public FrmAddEditVehicles(TypesOfCars editcar, ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent(); //initiates all the components in the Current form.(by the way it is default method here.) 
                                   //when this Constructor is called the Label text will automatically show the following
            Text = "Edit Vehicle";
            lblTitle.Text = "Edit Vehicle";
            _manageVehicleListing = manageVehicleListing;
            
                if (editcar==null)
                {
                    MessageBox.Show("Please Ensure that you selected a valid record to edit");
                    Close();
                }

            else
            {
                _db = new CarRentalSystemEntities1();
                iseditmode = true;    //if edit constructor is in add mode then iseditmode is set to true. followed by SaveChanges button.

                //Assigning Populate() method so that the Textbox in the TablepanelLayout will be filled with relevant datas from the Database table
                //TypesofCars
                PopulateFields(editcar); 
            }
            

            
        }
        private void PopulateFields(TypesOfCars car)//assigning this method and passing same Object type 'TypesofCars' as argument
        {
            lblId.Text = car.Id.ToString(); // setting Id of the Car in the label text while populating
            //now relating all the datas from the database table 'Typesofcars' to the textbox of TablelpanelLayout of 'AddEditVehicle'
            tbMake.Text = car.Make;
            tbModel.Text = car.Model;
            tbVIN.Text = car.VIN;
            tbYear.Text = car.Year.ToString(); //since we assign them to .Text property we should convert them.
            tbLisencePlateNumber.Text = car.LisencePlateNumber;
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)//making this button to check wether it is for Edit action or Add action
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbMake.Text) || string.IsNullOrWhiteSpace(tbModel.Text))
                {
                    MessageBox.Show("Please Ensure that you Provide a Make and a model");
                }
                else
                {
                    //if(isEditmode=true) or
                    if (iseditmode)
                    {

                        //edit action is done and saved.
                        var id = int.Parse(lblId.Text);//id from textbox of the populated field
                        var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);
                        car.Model = tbModel.Text;
                        car.Make = tbMake.Text;
                        car.VIN = tbVIN.Text;
                        car.Year = int.Parse(tbYear.Text);
                        car.LisencePlateNumber = tbLisencePlateNumber.Text;      
                        //var dgv = new ManageVehicleListing();
                        //dgv.Refresh();
                    }
                    else
                    {

                        //add action is done and saved.
                        var newcar = new TypesOfCars
                        {
                            LisencePlateNumber = tbLisencePlateNumber.Text,
                            Make = tbMake.Text,
                            Model = tbModel.Text,
                            VIN = tbVIN.Text,
                            Year = int.Parse(tbYear.Text)
                        };
                        _db.TypesOfCars.Add(newcar);// add new items to the database table
                        //var dgv = new ManageVehicleListing();
                        //dgv.Refresh();
                    }
                    _db.SaveChanges();
                    _manageVehicleListing.PopulateGrid();
                    MessageBox.Show("The Action is Completed. Please review the Changes in DataGrid View. Thanks.");// Generic Message for Add/Edit Operation
                    Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Occure please check the Following : "+ex.Message);
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.close() or 
            Close();    //close the current AddeditVehicle windowform
        }
    }
}

      
    
