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
    public partial class MainWindow : Form
    {
        private readonly CarRentalSystemEntities _dbcar;
        // 1) Login connected to the MainWindow. >>  var mainwindow = new MainWindow(this);  Look the "LoginUser" for This code.
        private LoginUser _Login;

        //LoginUser.cs Line 49 Is Connected to this Line.
        public string _RoleName;

        //get3 _users
        public int _users;

        // 2) Constructor
        public MainWindow(LoginUser login , string roleShortName, int user) // roleShortName get a LoginUser.cs Line 49. 
            //get4 'int user' to Constructor
        {
            InitializeComponent();
            _dbcar = new CarRentalSystemEntities();
            _Login = login;

            //LoginUser.cs Line 49 Is Connected to this Line.
            _RoleName = roleShortName;

            //get5 _users
            _users = user;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void addRentalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecords();

            //Can't Open Multi Windows........ 1st method.
            addRentalRecord.ShowDialog();

            addRentalRecord.MdiParent = this;
            
        }

        private void manageVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cant Open multi Windows.......... 2nd Method.
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isopen = OpenForms.Any(q => q.Name == "ManageVehicleListing");
            if(!isopen)
            {
                var VehicleListing = new ManageVehicleListing();
                VehicleListing.MdiParent = this;
                VehicleListing.Show();
            }
        }

        private void viewArchievToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cant Open multi Windows.......... 2nd Method.
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isopen = OpenForms.Any(q => q.Name == "ManageRentalRecords");
            if (!isopen)
            {
                var manageRentalRecords = new ManageRentalRecords();
                manageRentalRecords.MdiParent = this;
                manageRentalRecords.Show();
            }


                
        }

        // 3) mainWindow close >> LoginUser is close. FormClosing event.
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Login.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cant Open multi Windows.......... 2nd Method.
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isopen = OpenForms.Any(q => q.Name == "ManageUsers");
            if (!isopen)
            {
                var manageUsers = new ManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.Show();
            }
        }

        //LoginUser.cs Line 58 Is Connected to this Line.
        //Line 58 and other Lines can pass the user data to mainWindow.
        //Admin only can use the "manage USer" option.
        //Login User Is not a Admin, "manage user" option is hide
        private void MainWindow_Load(object sender, EventArgs e)
        {
            //default password is uqual the your password ResetPassword window is showing
            //we can use if statement for doing this....
            //get 6

            var ID = _users;
            var User1 = _dbcar.userLogins.FirstOrDefault(q => q.id == ID);

            if (User1.password == utils.DefaultHashPassword())
            {
                var resetPassword = new ResetPassword(User1);
                resetPassword.ShowDialog();
            }



            //status strip label code........... 1 code only.....
            ts1.Text = $"Logged In As: {_RoleName}";

            //hide code MaAnage user option..........
            if(_RoleName != "Admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
            }
        }
    }
}
