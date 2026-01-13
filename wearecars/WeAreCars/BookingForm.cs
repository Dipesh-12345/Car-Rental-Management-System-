using System;
using System.Drawing;
using System.Windows.Forms;
using WeAreCars.Models;
using WeAreCars.Services;

namespace WeAreCars.Forms
{
    public class BookingForm : Form
    {
        private TextBox _firstNameTextBox;
        private TextBox _surnameTextBox;
        private TextBox _addressTextBox;
        private NumericUpDown _ageNumericUpDown;
        private RadioButton _licenseYesRadioButton;
        private RadioButton _licenseNoRadioButton;
        private NumericUpDown _rentalDaysNumericUpDown;
        private ComboBox _carTypeComboBox;
        private ComboBox _fuelTypeComboBox;
        private CheckBox _unlimitedMileageCheckBox;
        private CheckBox _breakdownCoverCheckBox;
        private Button _nextButton;
        private Button _viewBookingsButton;
        private Label _validationLabel;

        public BookingForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Initialize form properties
            this.Text = "WeAreCars - New Booking";
            this.Size = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.AutoScroll = true; // Enable scrolling if content exceeds form height

            // Create title label
            Label titleLabel = new Label
            {
                Text = "New Car Rental Booking",
                Font = new Font("Arial", 18, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Size = new Size(800, 40),
                Location = new Point(0, 20),
                Dock = DockStyle.Top
            };

            // Create panel for booking content (with scroll capability)
            Panel contentPanel = new Panel
            {
                AutoScroll = true,
                Dock = DockStyle.Fill,
                Padding = new Padding(50, 10, 50, 10)
            };

            // Create required field note
            Label requiredNoteLabel = new Label
            {
                Text = "* Required fields",
                Font = new Font("Arial", 9, FontStyle.Italic),
                Size = new Size(150, 20),
                Location = new Point(0, 0)
            };
            contentPanel.Controls.Add(requiredNoteLabel);

            int currentY = 30; // Start position after the note
            int labelX = 0;
            int controlX = 170;
            int controlWidth = 250;
            int spacing = 35; // Slightly reduced spacing

            // Customer First Name
            Label firstNameLabel = new Label
            {
                Text = "Customer First Name*:",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(150, 20),
                Location = new Point(labelX, currentY)
            };
            contentPanel.Controls.Add(firstNameLabel);

            _firstNameTextBox = new TextBox
            {
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(controlWidth, 25),
                Location = new Point(controlX, currentY - 2)
            };
            contentPanel.Controls.Add(_firstNameTextBox);

            currentY += spacing;

            // Customer Surname
            Label surnameLabel = new Label
            {
                Text = "Customer Surname*:",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(150, 20),
                Location = new Point(labelX, currentY)
            };
            contentPanel.Controls.Add(surnameLabel);

            _surnameTextBox = new TextBox
            {
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(controlWidth, 25),
                Location = new Point(controlX, currentY - 2)
            };
            contentPanel.Controls.Add(_surnameTextBox);

            currentY += spacing;

            // Customer Address
            Label addressLabel = new Label
            {
                Text = "Customer Address*:",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(150, 20),
                Location = new Point(labelX, currentY)
            };
            contentPanel.Controls.Add(addressLabel);

            _addressTextBox = new TextBox
            {
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(controlWidth, 25),
                Location = new Point(controlX, currentY - 2)
            };
            contentPanel.Controls.Add(_addressTextBox);

            currentY += spacing;

            // Customer Age
            Label ageLabel = new Label
            {
                Text = "Customer Age*:",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(150, 20),
                Location = new Point(labelX, currentY)
            };
            contentPanel.Controls.Add(ageLabel);

            _ageNumericUpDown = new NumericUpDown
            {
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(80, 25),
                Location = new Point(controlX, currentY - 2),
                Minimum = 18,
                Maximum = 100,
                Value = 25
            };
            contentPanel.Controls.Add(_ageNumericUpDown);

            currentY += spacing;

            // Valid Driving License
            Label licenseLabel = new Label
            {
                Text = "Valid Driving License*:",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(150, 20),
                Location = new Point(labelX, currentY)
            };
            contentPanel.Controls.Add(licenseLabel);

            Panel licensePanel = new Panel
            {
                Size = new Size(controlWidth, 30),
                Location = new Point(controlX, currentY - 5)
            };

            _licenseYesRadioButton = new RadioButton
            {
                Text = "Yes",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(60, 20),
                Location = new Point(0, 0),
                Checked = true
            };
            _licenseYesRadioButton.CheckedChanged += LicenseRadioButton_CheckedChanged;

            _licenseNoRadioButton = new RadioButton
            {
                Text = "No",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(60, 20),
                Location = new Point(70, 0)
            };
            _licenseNoRadioButton.CheckedChanged += LicenseRadioButton_CheckedChanged;

            licensePanel.Controls.Add(_licenseYesRadioButton);
            licensePanel.Controls.Add(_licenseNoRadioButton);
            contentPanel.Controls.Add(licensePanel);

            currentY += spacing;

            // Rental Days
            Label rentalDaysLabel = new Label
            {
                Text = "Rental Days* (£25/day):",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(150, 20),
                Location = new Point(labelX, currentY)
            };
            contentPanel.Controls.Add(rentalDaysLabel);

            _rentalDaysNumericUpDown = new NumericUpDown
            {
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(80, 25),
                Location = new Point(controlX, currentY - 2),
                Minimum = 1,
                Maximum = 28,
                Value = 1
            };
            contentPanel.Controls.Add(_rentalDaysNumericUpDown);

            currentY += spacing;

            // Car Type
            Label carTypeLabel = new Label
            {
                Text = "Car Type*:",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(150, 20),
                Location = new Point(labelX, currentY)
            };
            contentPanel.Controls.Add(carTypeLabel);

            _carTypeComboBox = new ComboBox
            {
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(controlWidth, 25),
                Location = new Point(controlX, currentY - 2),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            _carTypeComboBox.Items.Add("City Car (no charge)");
            _carTypeComboBox.Items.Add("Family Car (+£50)");
            _carTypeComboBox.Items.Add("Sports Car (+£75)");
            _carTypeComboBox.Items.Add("SUV (+£65)");
            _carTypeComboBox.SelectedIndex = 0;
            contentPanel.Controls.Add(_carTypeComboBox);

            currentY += spacing;

            // Fuel Type
            Label fuelTypeLabel = new Label
            {
                Text = "Fuel Type*:",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(150, 20),
                Location = new Point(labelX, currentY)
            };
            contentPanel.Controls.Add(fuelTypeLabel);

            _fuelTypeComboBox = new ComboBox
            {
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(controlWidth, 25),
                Location = new Point(controlX, currentY - 2),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            _fuelTypeComboBox.Items.Add("Petrol / Diesel (no charge)");
            _fuelTypeComboBox.Items.Add("Hybrid (+£30)");
            _fuelTypeComboBox.Items.Add("Electric (+£50)");
            _fuelTypeComboBox.SelectedIndex = 0;
            contentPanel.Controls.Add(_fuelTypeComboBox);

            currentY += spacing;

            // Optional Extras Section
            Label optionalExtrasLabel = new Label
            {
                Text = "Optional Extras:",
                Font = new Font("Arial", 10, FontStyle.Bold),
                Size = new Size(150, 20),
                Location = new Point(labelX, currentY)
            };
            contentPanel.Controls.Add(optionalExtrasLabel);

            currentY += 25;

            // Unlimited Mileage
            _unlimitedMileageCheckBox = new CheckBox
            {
                Text = "Unlimited Mileage (+£10/day)",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(200, 20),
                Location = new Point(controlX, currentY - 2)
            };
            contentPanel.Controls.Add(_unlimitedMileageCheckBox);

            currentY += 25;

            // Breakdown Cover
            _breakdownCoverCheckBox = new CheckBox
            {
                Text = "Breakdown Cover (+£2/day)",
                Font = new Font("Arial", 10, FontStyle.Regular),
                Size = new Size(200, 20),
                Location = new Point(controlX, currentY - 2)
            };
            contentPanel.Controls.Add(_breakdownCoverCheckBox);

            currentY += 40;

            // Validation label
            _validationLabel = new Label
            {
                Text = "",
                Font = new Font("Arial", 10, FontStyle.Regular),
                ForeColor = Color.Red,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Size = new Size(500, 20),
                Location = new Point(50, currentY)
            };
            contentPanel.Controls.Add(_validationLabel);

            currentY += 30;

            // Button panel (fixed at bottom)
            Panel buttonPanel = new Panel
            {
                Height = 60,
                Dock = DockStyle.Bottom,
                BackColor = Color.WhiteSmoke
            };

            // Buttons
            _nextButton = new Button
            {
                Text = "Next",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Size = new Size(120, 35),
                Location = new Point(230, 12),
                BackColor = Color.LightGreen
            };
            _nextButton.Click += NextButton_Click;
            buttonPanel.Controls.Add(_nextButton);

            _viewBookingsButton = new Button
            {
                Text = "View Bookings",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Size = new Size(150, 35),
                Location = new Point(400, 12),
                BackColor = Color.LightBlue
            };
            _viewBookingsButton.Click += ViewBookingsButton_Click;
            buttonPanel.Controls.Add(_viewBookingsButton);

            // Add panels to form
            this.Controls.Add(buttonPanel);
            this.Controls.Add(contentPanel);
            this.Controls.Add(titleLabel);
        }

        private void LicenseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Disable the Next button if the customer doesn't have a valid license
            _nextButton.Enabled = _licenseYesRadioButton.Checked;

            if (!_licenseYesRadioButton.Checked)
            {
                _validationLabel.Text = "Customer must have a valid driving license to proceed.";
            }
            else
            {
                _validationLabel.Text = "";
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(_firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(_surnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(_addressTextBox.Text))
            {
                _validationLabel.Text = "Please fill in all required fields marked with an asterisk (*).";
                return;
            }

            if (!_licenseYesRadioButton.Checked)
            {
                _validationLabel.Text = "Customer must have a valid driving license to proceed.";
                return;
            }

            // Create a new booking object
            Booking booking = new Booking
            {
                FirstName = _firstNameTextBox.Text.Trim(),
                Surname = _surnameTextBox.Text.Trim(),
                Address = _addressTextBox.Text.Trim(),
                Age = (int)_ageNumericUpDown.Value,
                HasValidLicense = _licenseYesRadioButton.Checked,
                RentalDays = (int)_rentalDaysNumericUpDown.Value,
                CarType = GetSelectedCarType(),
                FuelType = GetSelectedFuelType(),
                HasUnlimitedMileage = _unlimitedMileageCheckBox.Checked,
                HasBreakdownCover = _breakdownCoverCheckBox.Checked
            };

            // Calculate the total cost
            booking.TotalCost = BookingService.Instance.CalculateTotalCost(booking);

            // Show the booking summary form
            var summaryForm = new BookingSummaryForm(booking);
            summaryForm.Show();

            // Hide this form
            this.Hide();
        }

        private void ViewBookingsButton_Click(object sender, EventArgs e)
        {
            var bookingListForm = new BookingListForm();
            bookingListForm.Show();
        }

        private CarType GetSelectedCarType()
        {
            switch (_carTypeComboBox.SelectedIndex)
            {
                case 0: return CarType.CityCar;
                case 1: return CarType.FamilyCar;
                case 2: return CarType.SportsCar;
                case 3: return CarType.SUV;
                default: return CarType.CityCar;
            }
        }

        private FuelType GetSelectedFuelType()
        {
            switch (_fuelTypeComboBox.SelectedIndex)
            {
                case 0: return FuelType.PetrolDiesel;
                case 1: return FuelType.Hybrid;
                case 2: return FuelType.Electric;
                default: return FuelType.PetrolDiesel;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // Close the entire application if this form is closed
            if (Application.OpenForms.Count <= 1)
            {
                Application.Exit();
            }
        }
    }
}