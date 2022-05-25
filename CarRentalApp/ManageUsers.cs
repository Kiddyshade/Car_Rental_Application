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
    public partial class ManageUsers : Form
    {
        private readonly CarRentalSystemEntities1 _db;
        public ManageUsers()
        {
            InitializeComponent();
            Text = "Manage Users";
            lblManageUser.Text = "Manage Users";
            _db = new CarRentalSystemEntities1();
            
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (!Utils.FormisOpen("AddUser"))
            {
                var adduser = new AddUser(this);
                adduser.MdiParent = this.MdiParent; 
                adduser.Show();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvUserList.SelectedRows[0].Cells["Id"].Value; //select the row form datagird and select the Id
                var user = _db.Users.FirstOrDefault(q => q.Id == id);//search id from the table   
                var hashed_password = Utils.DefaultHashed_password();
                user.Password=hashed_password;
                _db.SaveChanges();

                MessageBox.Show($"{user.UserName}'s password is reset !");
                PopulateGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : "+ex.Message);
            }
        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        { 
            try
            {
                var id = (int)dgvUserList.SelectedRows[0].Cells["Id"].Value; //select the row form datagird and select the Id
                var user = _db.Users.FirstOrDefault(q => q.Id == id);//search id from the table

                //if(user.isActiver == true)
                //user.isActive=false;
                //else(user.isActive==false)
                //user.isActive=true;

                DialogResult dr = MessageBox.Show("Do you want to Deactivate/Active this User?","Deactivate/Active", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                { 
                    if (user.IsActive == true)
                       user.IsActive = false;
                    else if(user.IsActive == false)
                        user.IsActive = true;

                   // _user.IsActive = user.IsActive == true ? false : true; //ternery operator 
                    _db.SaveChanges();
                }
                

                MessageBox.Show($"{user.UserName}'s Active Status Changed !");
                PopulateGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : "+ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            try
            {

                PopulateGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : "+ex.Message);
            }
        }

        public void PopulateGrid()
        {
            var users = _db.Users.Select(q => new 
            { 
              q.Id,
              q.UserName,
              q.UserRoles.FirstOrDefault().Roles.Name,
              q.IsActive
            }).ToList();
            dgvUserList.DataSource = users;
            dgvUserList.Columns["Id"].Visible = false;

            dgvUserList.Columns["Name"].HeaderText = "Role Name";
            dgvUserList.Columns["IsActive"].HeaderText = "Active Status";
        }
    }
}
