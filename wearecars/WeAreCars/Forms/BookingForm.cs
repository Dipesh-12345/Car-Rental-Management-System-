using System;
using System.Drawing;
using System.Windows.Forms;
using WeAreCars.Models;
using WeAreCars.Utils;

namespace WeAreCars.Forms
{
    /// <summary>
    /// Main form for creating new bookings
    /// </summary>
    public partial class BookingForm : Form
    {
        // The booking being created
        private Booking _currentBooking;
        
        public BookingForm()
        {
            InitializeComponent();
            _currentBooking = new Booking();
        }
        
        private void BookingForm_Load(object sender, EventArgs e)
        {
            // Initialize car type combo box
            cmbCarType.Items.Add("City Car");
            cmbCarType.Items.Add("Family Car (+£50)");
            cmbCarType.Items.Add("Sports Car (+£75)");
            cmbCarType.Items.Add("SUV (+£65)");
            cmbCarType.SelectedIndex = 0;
            
            // Initialize fuel type combo box
            cmbFuelType.Items.Add("Petrol");
            cmbFuelType.Items.Add("Diesel");
            cmbFuelType.Items.Add("Hybrid (+£30)");
            cmbFuelType.Items.Add("Full Electric (+£50)");
            cmbFuelType.SelectedIndex = 0;
            
            // Initialize valid license radio buttons
            rbYesLicense.Checked = true;
            
            // Set up tooltips
            SetupTooltips();
            
            // Hide error labels initially
            HideAllErrorLabels();
        }
        
        private void SetupTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            
            toolTip.SetToolTip(txtFirstName, "Enter customer's first name");
            toolTip.SetToolTip(txtSurname, "Enter customer's surname");
            toolTip.SetToolTip(txtAddress, "Enter customer's full address");
            toolTip.SetToolTip(txtAge, "Enter customer's age (must be 17 or older)");
            toolTip.SetToolTip(rbYesLicense, "Customer must have a valid driving license to rent a car");
            toolTip.SetToolTip(txtDays, "Enter rental duration (1-28 days)");
            toolTip.SetToolTip(cmbCarType, "Select the type of car to rent");
            toolTip.SetToolTip(cmbFuelType, "Select the fuel type for the car");
            toolTip.SetToolTip(chkUnlimitedMileage, "Add unlimited mileage for £10 per day");
            toolTip.SetToolTip(chkBreakdownCover, "Add breakdown cover for £2 per day");
            toolTip.SetToolTip(btnCalculate, "Calculate the total cost of the booking");
            toolTip.SetToolTip(btnCreateBooking, "Create a new booking with the entered details");
            toolTip.SetToolTip(btnViewBookings, "View all existing bookings");
        }
        
        private void HideAllErrorLabels()
        {
            lblFirstNameError.Visible = false;
            lblSurnameError.Visible = false;
            lblAddressError.Visible = false;
            lblAgeError.Visible = false;
            lblDaysError.Visible = false;
            lblLicenseError.Visible = false;
        }
        
        private bool ValidateInputs()
        {
            bool isValid = true;
            
            // Validate first name
            string firstNameError = Validator.ValidateRequiredField(txtFirstName.Text, "First Name");
            if (firstNameError != null)
            {
                lblFirstNameError.Text = firstNameError;
                lblFirstNameError.Visible = true;
                isValid = false;
            }
            else
            {
                lblFirstNameError.Visible = false;
            }
            
            // Validate surname
            string surnameError = Validator.ValidateRequiredField(txtSurname.Text, "Surname");
            if (surnameError != null)
            {
                lblSurnameError.Text = surnameError;
                lblSurnameError.Visible = true;
                isValid = false;
            }
            else
            {
                lblSurnameError.Visible = false;
            }
            
            // Validate address
            string addressError = Validator.ValidateRequiredField(txtAddress.Text, "Address");
            if (addressError != null)
            {
                lblAddressError.Text = addressError;
                lblAddressError.Visible = true;
                isValid = false;
            }
            else
            {
                lblAddressError.Visible = false;
            }
            
            // Validate age
            string ageError = Validator.ValidateAge(txtAge.Text);
            if (ageError != null)
            {
                lblAgeError.Text = ageError;
                lblAgeError.Visible = true;
                isValid = false;
            }
            else
            {
                lblAgeError.Visible = false;
            }
            
            // Validate driving license
            if (!rbYesLicense.Checked)
            {
                lblLicenseError.Text = "A valid driving license is required to rent a car.";
                lblLicenseError.Visible = true;
                isValid = false;
            }
            else
            {
                lblLicenseError.Visible = false;
            }
            
            // Validate days
            string daysError = Validator.ValidateDays(txtDays.Text);
            if (daysError != null)
            {
                lblDaysError.Text = daysError;
                lblDaysError.Visible = true;
                isValid = false;
            }
            else
            {
                lblDaysError.Visible = false;
            }
            
            return isValid;
        }
        
        private void PopulateBookingFromInputs()
        {
            _currentBooking.FirstName = txtFirstName.Text.Trim();
            _currentBooking.Surname = txtSurname.Text.Trim();
            _currentBooking.Address = txtAddress.Text.Trim();
            _currentBooking.Age = int.Parse(txtAge.Text);
            _currentBooking.HasValidLicense = rbYesLicense.Checked;
            _currentBooking.NumberOfDays = int.Parse(txtDays.Text);
            
            // Set car type based on selection
            switch (cmbCarType.SelectedIndex)
            {
                case 0:
                    _currentBooking.SelectedCarType = CarType.CityCar;
                    break;
                case 1:
                    _currentBooking.SelectedCarType = CarType.FamilyCar;
                    break;
                case 2:
                    _currentBooking.SelectedCarType = CarType.SportsCar;
                    break;
                case 3:
                    _currentBooking.SelectedCarType = CarType.SUV;
                    break;
            }
            
            // Set fuel type based on selection
            switch (cmbFuelType.SelectedIndex)
            {
                case 0:
                    _currentBooking.SelectedFuelType = FuelType.Petrol;
                    break;
                case 1:
                    _currentBooking.SelectedFuelType = FuelType.Diesel;
                    break;
                case 2:
                    _currentBooking.SelectedFuelType = FuelType.Hybrid;
                    break;
                case 3:
                    _currentBooking.SelectedFuelType = FuelType.Electric;
                    break;
            }
            
            // Set optional extras
            _currentBooking.HasUnlimitedMileage = chkUnlimitedMileage.Checked;
            _currentBooking.HasBreakdownCover = chkBreakdownCover.Checked;
        }
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }
            
            // Populate the booking object with form inputs
            PopulateBookingFromInputs();
            
            // Calculate the total cost
            decimal totalCost = BookingManager.CalculateTotalCost(_currentBooking);
            
            // Display the total cost
            MessageBox.Show($"Total Cost: £{totalCost:F2}", "Booking Cost", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }
            
            // Populate the booking object with form inputs
            PopulateBookingFromInputs();
            
            // Calculate the total cost
            _currentBooking.TotalCost = BookingManager.CalculateTotalCost(_currentBooking);
            
            // Open booking summary form
            var summaryForm = new BookingSummaryForm(_currentBooking);
            summaryForm.BookingConfirmed += (s, args) => 
            {
                // Clear form inputs after booking is confirmed
                ClearInputs();
                _currentBooking = new Booking();
            };
            summaryForm.ShowDialog();
        }
        
        private void ClearInputs()
        {
            txtFirstName.Clear();
            txtSurname.Clear();
            txtAddress.Clear();
            txtAge.Clear();
            rbYesLicense.Checked = true;
            txtDays.Clear();
            cmbCarType.SelectedIndex = 0;
            cmbFuelType.SelectedIndex = 0;
            chkUnlimitedMileage.Checked = false;
            chkBreakdownCover.Checked = false;
            
            HideAllErrorLabels();
        }
        
        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            var bookingsListForm = new BookingsListForm();
            bookingsListForm.ShowDialog();
        }
        
        private void rbNoLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoLicense.Checked)
            {
                lblLicenseError.Text = "A valid driving license is required to rent a car.";
                lblLicenseError.Visible = true;
            }
            else
            {
                lblLicenseError.Visible = false;
            }
        }
    }
} 