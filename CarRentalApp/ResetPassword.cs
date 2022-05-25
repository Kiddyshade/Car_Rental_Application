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
    public partial class ResetPassword : Form
    {
        private readonly CarRentalSystemEntities1 _db;
        private Users _user;
        public ResetPassword(Users user)
        {
            InitializeComponent();
            _db = new CarRentalSystemEntities1();
            _user = user;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {

                var password = tbNewPassword.Text;
                var confirmpassword = tbConfirmPassword.Text;
                var user = _db.Users.FirstOrDefault(q => q.Id == _user.Id);
                if (password != confirmpassword)
                {
                    MessageBox.Show("Password Mismatch : Please Try Again");
                }
                user.Password = Utils.hashed_password(password);
                _db.SaveChanges();
                MessageBox.Show("New Password has been changed");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Some Error has been Occured please try again later");
            }
        }
    }
}
