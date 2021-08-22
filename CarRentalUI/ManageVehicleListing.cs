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
    public partial class ManageVehicleListing : Form
    {
        //DataBase Connection Line
        private readonly CarRentalSystemEntities _dbcar;

        public ManageVehicleListing()
        {
            InitializeComponent();
            _dbcar = new CarRentalSystemEntities();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
                // throw;
            }
        }

        public void PopulateGrid() //this can be refresh the grid
        {

            //Select All from TypeOfCars
            //var cars = _dbcar.TypeOfCars.ToList();


            //Select id as carID,Name as CarName of TypeOfCar
            //var cars = _dbcar.TypeOfCars.Select(q => new { CarID = q.id, CarName = q.Make }).ToList();


            var cars = _dbcar.TypeOfCars.Select(q => new { Make = q.Make, Model = q.Model, VIN = q.VIN, LicencePlateNumber = q.LicencePlateNumber, Year = q.Year, q.id }).ToList();

            gvVehicleListing.DataSource = cars;
            gvVehicleListing.Columns[3].HeaderText = "Licence Plate Number";
            gvVehicleListing.Columns[5].Visible = false;

            // gvVehicleListing.Columns[0].HeaderText = "ID";
            //  gvVehicleListing.Columns[1].HeaderText = "Name Of Car Type";
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
           var addEditVehicles = new AddEditVehicles(this); //close Form And Auto refresh Step 4 from AddEditVehicle.cs, Add "this"

            addEditVehicles.MdiParent = this.MdiParent;
           addEditVehicles.Show();

        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                //Get id of selected Row
                var Id = (int)gvVehicleListing.SelectedRows[0].Cells["id"].Value;

                //Query Database For Record
                var car = _dbcar.TypeOfCars.FirstOrDefault(q => q.id == Id);

                //Launch AddEditVehicle Window with Data
                var addEditVehicles = new AddEditVehicles(car, this);//close Form And Auto refresh Step 4 from AddEditVehicle.cs, Add "this"
                addEditVehicles.MdiParent = this.MdiParent;
                addEditVehicles.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
                // throw;
            }
           
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                //Get id of selected Row
                var id = (int)gvVehicleListing.SelectedRows[0].Cells["id"].Value;

                //Query Database For Record
                var car = _dbcar.TypeOfCars.FirstOrDefault(q => q.id == id);

                //Ask "sure the delete dialog"
                DialogResult dr = MessageBox.Show("Are you sure to You want Delete this Record?", "Delete", 
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //Remove The Data
                    _dbcar.TypeOfCars.Remove(car);
                    _dbcar.SaveChanges();
                }

                //Refresh The Grid View
                gvVehicleListing.Refresh();
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
                //throw;
            }
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
