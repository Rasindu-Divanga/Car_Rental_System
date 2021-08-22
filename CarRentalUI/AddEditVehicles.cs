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
    public partial class AddEditVehicles : Form
    {
        private bool EditMode;

        //close Form And Auto refresh Step 1
        private ManageVehicleListing _manageVehicleListing;


        //DataBase Connection Line
        private readonly CarRentalSystemEntities _dbcar;

        //Line1 & Line2, We can code this way. 2 lines = 1 line
        //private readonly CarRentalSystemEntities _dbcar = new CarRentalSystemEntities();

        public AddEditVehicles(ManageVehicleListing manageVehicleListing = null) //close Form And Auto refresh Step 2, Add >> ManageVehicleListing manageVehicleListing = null
        {
            InitializeComponent();
            LbTitle.Text = "Add New Vehicle";
            Text = "Add New Vehicle";
            EditMode = false;
            //close Form And Auto refresh Step 3
            _manageVehicleListing = manageVehicleListing;

            //DataBase Connection Line 2
            _dbcar = new CarRentalSystemEntities();
        }

        public AddEditVehicles(TypeOfCar EditCar, ManageVehicleListing manageVehicleListing = null) //Constructor   //close Form And Auto refresh Step 2, Add >> ManageVehicleListing manageVehicleListing = null
        {
            InitializeComponent();
            LbTitle.Text = "Edit Vehicle";
            this.Text = "Edit Vehicle";

            //close Form And Auto refresh Step 3
            _manageVehicleListing = manageVehicleListing;

            if (EditCar == null)
            {
                MessageBox.Show("Please Ensure That You Selected a Value Record To Edit.");
                Close();
            }
            else
            {
                EditMode = true;

                //DataBase Connection Line 2
                _dbcar = new CarRentalSystemEntities();

                populateFields(EditCar);
            }

           
        }

        private void populateFields(TypeOfCar Car)
        {
            //Get the id to Invisible Lable
            lblID.Text = Car.id.ToString();

            txtMake.Text = Car.Make;
            txtModel.Text = Car.Model;
            txtVIN.Text = Car.VIN;
            txtYear.Text = Car.Year.ToString();
            txtPlateNumber.Text = Car.LicencePlateNumber;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (EditMode)
                {

                    //"Edit" Code Here
                    // 1) find the column
                    var Id = int.Parse(lblID.Text);
                    var car = _dbcar.TypeOfCars.FirstOrDefault(q => q.id == Id);

                    // 2) Save the Data
                    car.Make = txtMake.Text;
                    car.Model = txtModel.Text;
                    car.VIN = txtVIN.Text;
                    car.Year = int.Parse(txtYear.Text);
                    car.LicencePlateNumber = txtPlateNumber.Text;

                    _dbcar.SaveChanges();

                    //close Form And Auto refresh Step 5, Add the Populategrid();
                    _manageVehicleListing.PopulateGrid();

                    MessageBox.Show("Data save successfully completed.");
                    this.Close();
                   

                }
                else
                {
                    //"Add" Code Here
                    var newcar = new TypeOfCar
                    {
                        Make = txtMake.Text,
                        Model = txtModel.Text,
                        VIN = txtVIN.Text,
                        Year = int.Parse(txtYear.Text),
                        LicencePlateNumber = txtPlateNumber.Text
                    };
                    _dbcar.TypeOfCars.Add(newcar);
                    _dbcar.SaveChanges();

                    //close Form And Auto refresh Step 5, Add the Populategrid();
                    _manageVehicleListing.PopulateGrid();

                    MessageBox.Show("Data save successfully completed.");
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
              //  throw;
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.close();   is equal    close(); .... we can use both. Visual studio can understand the Close();

            this.Close();
        }
    }
}
