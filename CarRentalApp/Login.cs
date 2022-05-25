using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Login : Form
    {
        private readonly CarRentalSystemEntities1 _db;
        public Login()
        {
            InitializeComponent();
            _db = new CarRentalSystemEntities1();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create(); // Algorithm for encryption.

                var userName = tbUserName.Text.Trim();
                var password = tbPassword.Text;

                var hashed_password = Utils.hashed_password(password);

                var user = _db.Users.FirstOrDefault(q => q.UserName == userName && q.Password == hashed_password && q.IsActive==true);
                if (user==null)
                {
                    MessageBox.Show("Please provide valid Credentials");
                }
                else
                {
                   // var Role=user.UserRoles.FirstOrDefault();
                   // var roleshortname = Role.Roles.ShortNames;
                    var mainWindow = new MainWindow(this, user);
                    mainWindow.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : "+ex.Message);
            }
        }
    }
}
