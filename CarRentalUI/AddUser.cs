using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalUI
{
    public partial class AddUser : Form
    {
        private readonly CarRentalSystemEntities _dbcar;

        //for part 1 look manageuser line 51......
        //this key word conect to the adduser window step 2..
        private ManageUsers _manageUsers;
        public AddUser(ManageUsers manageusers)//this key word conect to the adduser window step 3.. Add "ManageUsers manageusers" only..
        {
            InitializeComponent();
            _dbcar = new CarRentalSystemEntities();

            //this key word conect to the adduser window step 4..
            _manageUsers = manageusers;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            //load combobox rolenames from database.....
            var roles = _dbcar.Roles.ToList();
            cmbrole.DataSource = roles;
            cmbrole.ValueMember = "id";
            cmbrole.DisplayMember = "name";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                //Add values
                var username = txtusername.Text;
                var roleID = (int)cmbrole.SelectedValue;

                //Set Default hashed password..... Look utils.cs DefaultHashPassword Part.
                var password = utils.DefaultHashPassword();

                //Add data to database userlogin
                var user = new userLogin
                {
                    username = username,
                    password = password,
                    isActive = true
                };

                //save data
                _dbcar.userLogins.Add(user);
                _dbcar.SaveChanges();


                //Add data to database userroles
                var userid = user.id;

                var userrole = new UserRole
                {
                    userid = userid,
                    roleid = roleID
                };

                //save data
                _dbcar.UserRoles.Add(userrole);
                _dbcar.SaveChanges();


                MessageBox.Show("New User Added Successfully.....");
                _manageUsers.PopulateGrid();//this key word conect to the adduser window step 5..
                Close(); 

            }
            catch (Exception)
            {
                MessageBox.Show("An Error has occured");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
