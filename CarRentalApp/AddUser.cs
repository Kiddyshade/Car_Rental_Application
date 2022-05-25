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
    public partial class AddUser : Form
    {
        private readonly CarRentalSystemEntities1 _db;
        private ManageUsers _manageUsers;
        public AddUser(ManageUsers manageUsers)
        {
            InitializeComponent();
            _db = new CarRentalSystemEntities1();
            _manageUsers = manageUsers;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = _db.Roles.ToList();
            cmbRole.DataSource = roles;
            cmbRole.ValueMember = "Id";
            cmbRole.DisplayMember = "Name";

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                var userName = tbUserName.Text;
                var RoleId = (int)cmbRole.SelectedValue;
                var password = Utils.DefaultHashed_password();
                var user = new Users
                {
                    UserName = userName,
                    Password = password,
                    IsActive = true
                };
                _db.Users.Add(user);
                _db.SaveChanges();

                var userId = user.Id;
                var userRole = new UserRoles
                {
                    UserId = userId,
                    RoleId = RoleId
                };
                _db.UserRoles.Add(userRole);
                _db.SaveChanges();
                MessageBox.Show("New User has been Added");
                _manageUsers.PopulateGrid();
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Occured : "+ex.Message);
            }

        }
    }
}
