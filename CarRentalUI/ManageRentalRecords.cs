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
    public partial class ManageRentalRecords : Form
    {
        //DataBase Connection Line
        private readonly CarRentalSystemEntities _dbcar;
        public ManageRentalRecords()
        {
            InitializeComponent();
            _dbcar = new CarRentalSystemEntities();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecords(this)//close Form And Auto refresh Step 4.b from AddEditVehicle.cs, Add "this"
            {
                
                MdiParent = this.MdiParent
            };
            addRentalRecord.Show();
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {

            try
            {
                //Get id of selected Row
                var Id = (int)gvRecordListing.SelectedRows[0].Cells["id"].Value;

                //Query Database For Record
                var record = _dbcar.CarRentedRecords.FirstOrDefault(q => q.id == Id);

                //Launch AddEditVehicle Window with Data

                var addEditRentalRecords = new AddEditRentalRecords(record, this);//close Form And Auto refresh Step 4.b from AddEditVehicle.cs, Add "this"
                addEditRentalRecords.MdiParent = this.MdiParent;
                addEditRentalRecords.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
                // throw;
            }

        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {

            try
            {
                //Get id of selected Row
                var id = (int)gvRecordListing.SelectedRows[0].Cells["id"].Value;

                //Query Database For Record
                var record = _dbcar.CarRentedRecords.FirstOrDefault(q => q.id == id);

                //Ask "sure the delete dialog"
                DialogResult dr = MessageBox.Show("Are you sure to You want Delete this Record?", "Delete",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //Remove The Data
                    _dbcar.CarRentedRecords.Remove(record);
                    _dbcar.SaveChanges();
                }

                //Refresh The Grid View
                gvRecordListing.Refresh();
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
                //throw;
            }

        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
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

        public void PopulateGrid()
        {
            var records = _dbcar.CarRentedRecords.Select(q => new
            {
                customer = q.CustomerName,
                dateOut = q.DateRented,
                dateIn = q.DateReturned,
                ID = q.id,
                q.Cost,
                car = q.TypeOfCar1.Make + " " + q.TypeOfCar1.Model
            }).ToList();



            gvRecordListing.DataSource = records;
            gvRecordListing.Columns["customer"].HeaderText = "Customer Name";
            gvRecordListing.Columns["dateOut"].HeaderText = "Date Rented";
            gvRecordListing.Columns["dateIn"].HeaderText = "Date Returned";
            gvRecordListing.Columns["car"].HeaderText = "Car Type";
            gvRecordListing.Columns["ID"].Visible = false;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
