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
    public partial class ManageUsers : Form
    {
        private readonly CarRentalSystemEntities _dbcar;

        public ManageUsers()
        {
            InitializeComponent();
            _dbcar = new CarRentalSystemEntities();
        }

        //grid view connector......... data load..........
        public void PopulateGrid()
        {
            var users = _dbcar.userLogins.Select(q => new
            {
                q.id,
                q.username,
                q.UserRoles.FirstOrDefault().Role.name,
                q.isActive
            }).ToList();

            gvUserListing.DataSource = users;
            gvUserListing.Columns["username"].HeaderText = "User Name";
            gvUserListing.Columns["name"].HeaderText = "Role Name";
            gvUserListing.Columns["isActive"].HeaderText = "Active";
          
            gvUserListing.Columns["id"].Visible = false;

        }


        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            //Cant Open multi Windows.......... 3rd Method.
            //create Utils.cs, and use it here this way. 
            //look the Utils.cs class file. formisopen part.....
            if (!utils.FormIsOpen("AddUser"))
            {
                var adduser = new AddUser(this);//'this' key word conect to the adduser window step 1.. Look Adduser.cs
                adduser.MdiParent = this.MdiParent;
                adduser.Show();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                //Get id of selected Row
                //retrieve the user from database
                var Id = (int)gvUserListing.SelectedRows[0].Cells["id"].Value;

                //Query Database For Record
                var User = _dbcar.userLogins.FirstOrDefault(q => q.id == Id);

               
                //Set Default hashed password..... Look utils.cs DefaultHashPassword Part.
                var hashed_password = utils.DefaultHashPassword();

                User.password = hashed_password;
                _dbcar.SaveChanges();

                MessageBox.Show($"{User.username}'s Password Has been reset.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
                // throw;
            }
            PopulateGrid();
        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {

            try
            {
                //Get id of selected Row
                //retrieve the user from database
                var Id = (int)gvUserListing.SelectedRows[0].Cells["id"].Value;

                //Query Database For Record
                var User = _dbcar.userLogins.FirstOrDefault(q => q.id == Id);

                //user isActivate is true == false
                //user isActivate is false == true ,  1line two commands.........
                User.isActive = User.isActive == true ? false : true ;

                _dbcar.SaveChanges();

                MessageBox.Show($"{User.username}'s Activity Status Has been Changed.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
                // throw;
            }
            PopulateGrid();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid(); 
        }
    }
}
