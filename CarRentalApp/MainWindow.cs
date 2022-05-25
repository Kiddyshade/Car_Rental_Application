using Microsoft.VisualBasic.CompilerServices;
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
    public partial class MainWindow : Form
    {
        private Login _login;
        public string _rolesName;
        public Users _users;
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Login login,Users users)
        {
            InitializeComponent();
            _login = login; // go to formloading event
            _users=users;
            _rolesName= users.UserRoles.FirstOrDefault().Roles.ShortNames;
        }

        private void manageRenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormisOpen("AddEditRentalRecords"))
            {
                var rentalRecords = new AddEditRentalRecords();

                // rentalRecords.ShowDialog();//showdialog shows only the active window and Mainwindow will be inaccessible unless active window is closed
                rentalRecords.MdiParent = this;
                rentalRecords.Show(); 
            }
        }

        private void manageVechicleListingToolStripMenuItem_Click(object sender, EventArgs e) //Manage Vechicle list window will appear on the 
            // button click event on MainWindow menu
        {
            
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ManageVehicleListing");//if ManageVehiclelisting window is already open - don't open again

            if (!isOpen)                                                      //if ManageVehiclelisting window is not open - then open this window
            {
                var vechicleListing = new ManageVehicleListing(); //Creating object for the Managevechicle list window form class
                vechicleListing.MdiParent = this; //MDIParent represents that the Manage Vechile list datagrid view will appear only inside the Main Window
                vechicleListing.Show();
            }
            

        }

        private void viewArchivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormisOpen("ManageRentalRecord")) //go to utils.cs to check this function code
            {
                var manageRentalRecord = new ManageRentalRecord();
                manageRentalRecord.MdiParent = this;
                manageRentalRecord.Show();
            }

           
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();// whenever the mainwindow closes .you. login form also will close.
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormisOpen("ManageUsers"))
            {
                var manageUsers = new ManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.Show(); 
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (_users.Password==Utils.DefaultHashed_password())
            {
                var resetpassword = new ResetPassword(_users);
                resetpassword.ShowDialog();
                 
            }

            var username = _users.UserName;
            tsvFormUserLogginAs.Text ="Logged in as : "+ username; 
            if (_rolesName != "admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
            }
        }
    }
}
