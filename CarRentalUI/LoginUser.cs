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

namespace CarRentalUI
{
    public partial class LoginUser : Form
    {
        private readonly CarRentalSystemEntities _dbcar;
        public LoginUser()
        {
            InitializeComponent();
            _dbcar = new CarRentalSystemEntities();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();

                var username = txtUserName.Text.Trim();
                var password = txtPassword.Text;



                var Hashed_password = utils.HashPassword(password);

                //Check for matching username,password,Active or not
                var users = _dbcar.userLogins.FirstOrDefault(q => q.username == username && q.password == Hashed_password 
                        && q.isActive == true);

                if (users == null)
                {
                    MessageBox.Show("Please Provide Valid Crodentials.");
                }
                else
                {
                    var role = users.UserRoles.FirstOrDefault();
                    var roleShortName = role.Role.ShortName;
                    //get1 _users
                    var _users = users.id;
                    
                    //49 line
                    var mainwindow = new MainWindow(this, roleShortName, _users); //get2 _users.. next MainWindow 
                    mainwindow.Show();

                    //Hide the Login. Not close. 
                    Hide(); 
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Something Went Wrong. Please Try Again.");
            }
        }
    }
}
