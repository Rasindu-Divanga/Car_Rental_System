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
    public partial class AddEditRentalRecords : Form
    {
        private bool EditMode;

        //close Form And Auto refresh Step 1.b
        private ManageRentalRecords _manageRentalRecords;

        private readonly CarRentalSystemEntities _dbcar;
        public AddEditRentalRecords(ManageRentalRecords manageRentalRecords = null) //close Form And Auto refresh Step 2.b, Add >> ManageVehicleListing manageVehicleListing = null
        {
            InitializeComponent();
            label1.Text = "Add New Rental Record";
            this.Text = "Add New Rental Record";
            EditMode = false;

            //close Form And Auto refresh Step 3.b
            _manageRentalRecords = manageRentalRecords;

            //DataBase Connection Line 2
            _dbcar = new CarRentalSystemEntities();
        }

        public AddEditRentalRecords(CarRentedRecord recordToEdit, ManageRentalRecords manageRentalRecords = null) //close Form And Auto refresh Step 2.b, Add >> ManageVehicleListing manageVehicleListing = null
        {
            InitializeComponent();
            label1.Text = "Edit Rental Records";
            this.Text = "Edit Rental Records";
            //close Form And Auto refresh Step 3.b
            _manageRentalRecords = manageRentalRecords;

            if (recordToEdit == null)
            {
                MessageBox.Show("Please Ensure That You Selected a Value Record To Edit.");
                Close();
            }
            else
            {
                EditMode = true;

                //DataBase Connection Line 2
                _dbcar = new CarRentalSystemEntities();

                populateFields(recordToEdit);
            }
        }

        private void populateFields(CarRentedRecord recordToEdit)
        {
            txtname.Text = recordToEdit.CustomerName;
            DtRented.Value = (DateTime)recordToEdit.DateRented;
            DtReturned.Value = (DateTime)recordToEdit.DateReturned;
            txtCost.Text = recordToEdit.Cost.ToString();
            lblRecordId.Text = recordToEdit.id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string CustomerName = txtname.Text;
                var DateOut = DtRented.Value;
                var DateIn = DtReturned.Value;
                Double Cost = Convert.ToDouble(txtCost.Text);

                var CarType = cmbCarType.Text;
                var isValid = true;
                var error = "";

                if (String.IsNullOrWhiteSpace(CustomerName) || String.IsNullOrWhiteSpace(CarType))
                {
                    isValid = false;
                    error += "Error : Please Enter missing data.\n\r";
                }

                if (DateOut > DateIn)
                {
                    isValid = false;
                   error += "Error : Date selection is wrong.\n\r" ;
                }

                if (isValid)    //if(isValid == true)Bcs, Boolien.....
                {
                    if (EditMode)
                    {
                        var id = int.Parse(lblRecordId.Text);
                        var record = _dbcar.CarRentedRecords.FirstOrDefault(q => q.id == id);
                        record.CustomerName = CustomerName;
                        record.DateRented = DateOut;
                        record.DateReturned = DateIn;
                        record.Cost = (decimal)Cost;
                        record.TypeOfCar = (int)cmbCarType.SelectedValue;

                        _dbcar.SaveChanges();

                        //close Form And Auto refresh Step 5.b, Add the Populategrid();
                        _manageRentalRecords.PopulateGrid();

                        MessageBox.Show($"Customer Name : {CustomerName}\n\r" + 
                            $"Date Rented : {DateOut}\n\r" + 
                            $"Date Returned : {DateIn}\n\r" + 
                            $"Cost : Rs.{Cost}\n\r" + $"Thanks For using Our Service Mr.{CustomerName}\n\r");
                    }
                    else
                    {
                        var CarRental = new CarRentedRecord();
                        CarRental.CustomerName = CustomerName;
                        CarRental.DateRented = DateOut;
                        CarRental.DateReturned = DateIn;
                        CarRental.Cost = (decimal)Cost;
                        CarRental.TypeOfCar = (int)cmbCarType.SelectedValue;

                        _dbcar.CarRentedRecords.Add(CarRental);
                        _dbcar.SaveChanges();

                        //close Form And Auto refresh Step 5.b, Add the Populategrid();
                        _manageRentalRecords.PopulateGrid();

                        MessageBox.Show($"Customer Name : {CustomerName}\n\r" +
                       $"Date Rented : {DateOut}\n\r" +
                       $"Date Car Back : {DateIn}\n\r" +
                       $"Car Type : {CarType}\n\r" +
                       $"Cost : Rs.{Cost}\n\r" +
                       $"Thanks for Using Our Service Mr.{CustomerName}");
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show(error);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // var cars = carRentalEntities.TypeOfCars.ToList();

            var cars = _dbcar.TypeOfCars.Select(q => new { ID = q.id, Name = q.Make + " " + q.Model }).ToList();
            cmbCarType.DisplayMember = "Name";
            cmbCarType.ValueMember = "id";
            cmbCarType.DataSource = cars;
        }

       
    }
}
