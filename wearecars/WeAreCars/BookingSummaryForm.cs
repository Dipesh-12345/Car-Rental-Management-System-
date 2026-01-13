using System;
using System.Drawing;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WeAreCars.Models;
using WeAreCars.Services;

namespace WeAreCars.Forms
{
    public class BookingSummaryForm : Form
    {
        private readonly Booking _booking;
        private Button _confirmButton;
        private Button _backButton;

        public BookingSummaryForm(Booking booking)
        {
            _booking = booking;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Initialize form properties
            this.Text = "WeAreCars - Booking Summary";
            this.Size = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // Create title label
            Label titleLabel = new Label
            {
                Text = "Booking Summary",
                Font = new Font("Arial", 18, FontStyle.Bold),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                AutoSize = false,
                Size = new Size(800, 40),
                Location = new Point(0, 20)
            };

            // Create panel for booking details
            Panel summaryPanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(600, 400),
                Location = new Point(100, 70),
                BackColor = Color.WhiteSmoke
            };

            // Create details content
            int currentY = 20;
            int labelX = 30;
            int valueX = 220;
            int spacing = 30;
            Font detailFont = new Font("Arial", 11, FontStyle.Regular);

            // Customer information section
            Label customerSectionLabel = new Label
            {
                Text = "Customer Information",
                Font = new Font("Arial", 14, FontStyle.Bold),
                Size = new Size(300, 25),
                Location = new Point(labelX, currentY)
            };
            summaryPanel.Controls.Add(customerSectionLabel);

            currentY += 35;

            // Customer name
            Label nameLabel = new Label
            {
                Text = "Name:",
                Font = detailFont,
                Size = new Size(180, 20),
                Location = new Point(labelX, currentY)
            };
            summaryPanel.Controls.Add(nameLabel);

            Label nameValueLabel = new Label
            {
                Text = $"{_booking.FirstName} {_booking.Surname}",
                Font = detailFont,
                Size = new Size(300, 20),
                Location = new Point(valueX, currentY)
            };
            summaryPanel.Controls.Add(nameValueLabel);

            currentY += spacing;

            // Customer address
            Label addressLabel = new Label
            {
                Text = "Address:",
                Font = detailFont,
                Size = new Size(180, 20),
                Location = new Point(labelX, currentY)
            };
            summaryPanel.Controls.Add(addressLabel);

            Label addressValueLabel = new Label
            {
                Text = _booking.Address,
                Font = detailFont,
                Size = new Size(300, 20),
                Location = new Point(valueX, currentY)
            };
            summaryPanel.Controls.Add(addressValueLabel);

            currentY += spacing;

            // Customer age
            Label ageLabel = new Label
            {
                Text = "Age:",
                Font = detailFont,
                Size = new Size(180, 20),
                Location = new Point(labelX, currentY)
            };
            summaryPanel.Controls.Add(ageLabel);

            Label ageValueLabel = new Label
            {
                Text = _booking.Age.ToString(),
                Font = detailFont,
                Size = new Size(300, 20),
                Location = new Point(valueX, currentY)
            };
            summaryPanel.Controls.Add(ageValueLabel);

            currentY += spacing;

            // Valid license
            Label licenseLabel = new Label
            {
                Text = "Valid Driving License:",
                Font = detailFont,
                Size = new Size(180, 20),
                Location = new Point(labelX, currentY)
            };
            summaryPanel.Controls.Add(licenseLabel);

            Label licenseValueLabel = new Label
            {
                Text = _booking.HasValidLicense ? "Yes" : "No",
                Font = detailFont,
                Size = new Size(300, 20),
                Location = new Point(valueX, currentY)
            };
            summaryPanel.Controls.Add(licenseValueLabel);

            currentY += spacing + 15;

            // Booking details section
            Label bookingSectionLabel = new Label
            {
                Text = "Booking Details",
                Font = new Font("Arial", 14, FontStyle.Bold),
                Size = new Size(300, 25),
                Location = new Point(labelX, currentY)
            };
            summaryPanel.Controls.Add(bookingSectionLabel);

            currentY += 35;

            // Rental days
            Label daysLabel = new Label
            {
                Text = "Rental Days:",
                Font = detailFont,
                Size = new Size(180, 20),
                Location = new Point(labelX, currentY)
            };
            summaryPanel.Controls.Add(daysLabel);

            Label daysValueLabel = new Label
            {
                Text = $"{_booking.RentalDays} (£{25 * _booking.RentalDays})",
                Font = detailFont,
                Size = new Size(300, 20),
                Location = new Point(valueX, currentY)
            };
            summaryPanel.Controls.Add(daysValueLabel);

            currentY += spacing;

            // Car type
            Label carTypeLabel = new Label
            {
                Text = "Car Type:",
                Font = detailFont,
                Size = new Size(180, 20),
                Location = new Point(labelX, currentY)
            };
            summaryPanel.Controls.Add(carTypeLabel);

            string carTypeExtra = GetCarTypeExtraCost(_booking.CarType);
            Label carTypeValueLabel = new Label
            {
                Text = $"{_booking.CarType} {carTypeExtra}",
                Font = detailFont,
                Size = new Size(300, 20),
                Location = new Point(valueX, currentY)
            };
            summaryPanel.Controls.Add(carTypeValueLabel);

            currentY += spacing;

            // Fuel type
            Label fuelTypeLabel = new Label
            {
                Text = "Fuel Type:",
                Font = detailFont,
                Size = new Size(180, 20),
                Location = new Point(labelX, currentY)
            };
            summaryPanel.Controls.Add(fuelTypeLabel);

            string fuelTypeExtra = GetFuelTypeExtraCost(_booking.FuelType);
            Label fuelTypeValueLabel = new Label
            {
                Text = $"{_booking.FuelType} {fuelTypeExtra}",
                Font = detailFont,
                Size = new Size(300, 20),
                Location = new Point(valueX, currentY)
            };
            summaryPanel.Controls.Add(fuelTypeValueLabel);

            currentY += spacing;

            // Optional extras section
            Label optionalExtrasLabel = new Label
            {
                Text = "Optional Extras:",
                Font = detailFont,
                Size = new Size(180, 20),
                Location = new Point(labelX, currentY)
            };
            summaryPanel.Controls.Add(optionalExtrasLabel);

            currentY += spacing - 10;

            // Unlimited mileage
            if (_booking.HasUnlimitedMileage)
            {
                Label mileageLabel = new Label
                {
                    Text = "Unlimited Mileage:",
                    Font = detailFont,
                    Size = new Size(180, 20),
                    Location = new Point(labelX + 20, currentY)
                };
                summaryPanel.Controls.Add(mileageLabel);

                Label mileageValueLabel = new Label
                {
                    Text = $"£{10 * _booking.RentalDays} (£10/day)",
                    Font = detailFont,
                    Size = new Size(300, 20),
                    Location = new Point(valueX, currentY)
                };
                summaryPanel.Controls.Add(mileageValueLabel);

                currentY += spacing - 10;
            }

            // Breakdown cover
            if (_booking.HasBreakdownCover)
            {
                Label breakdownLabel = new Label
                {
                    Text = "Breakdown Cover:",
                    Font = detailFont,
                    Size = new Size(180, 20),
                    Location = new Point(labelX + 20, currentY)
                };
                summaryPanel.Controls.Add(breakdownLabel);

                Label breakdownValueLabel = new Label
                {
                    Text = $"£{2 * _booking.RentalDays} (£2/day)",
                    Font = detailFont,
                    Size = new Size(300, 20),
                    Location = new Point(valueX, currentY)
                };
                summaryPanel.Controls.Add(breakdownValueLabel);

                currentY += spacing - 10;
            }

            currentY += 15;

            // Total cost
            Label totalLabel = new Label
            {
                Text = "TOTAL COST:",
                Font = new Font("Arial", 14, FontStyle.Bold),
                Size = new Size(180, 30),
                Location = new Point(labelX, currentY)
            };
            summaryPanel.Controls.Add(totalLabel);

            Label totalValueLabel = new Label
            {
                Text = $"£{_booking.TotalCost:F2}",
                Font = new Font("Arial", 14, FontStyle.Bold),
                Size = new Size(300, 30),
                Location = new Point(valueX, currentY)
            };
            summaryPanel.Controls.Add(totalValueLabel);

            // Create buttons
            _confirmButton = new Button
            {
                Text = "Confirm Booking",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Size = new Size(150, 40),
                Location = new Point(230, 490),
                BackColor = Color.LightGreen
            };
            _confirmButton.Click += ConfirmButton_Click;

            _backButton = new Button
            {
                Text = "Back",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Size = new Size(120, 40),
                Location = new Point(420, 490),
                BackColor = Color.LightBlue
            };
            _backButton.Click += BackButton_Click;

            // Add controls to form
            this.Controls.Add(titleLabel);
            this.Controls.Add(summaryPanel);
            this.Controls.Add(_confirmButton);
            this.Controls.Add(_backButton);
        }

        private string GetCarTypeExtraCost(CarType carType)
        {
            switch (carType)
            {
                case CarType.FamilyCar:
                    return "(+£50)";
                case CarType.SportsCar:
                    return "(+£75)";
                case CarType.SUV:
                    return "(+£65)";
                default:
                    return "(no charge)";
            }
        }

        private string GetFuelTypeExtraCost(FuelType fuelType)
        {
            switch (fuelType)
            {
                case FuelType.Hybrid:
                    return "(+£30)";
                case FuelType.Electric:
                    return "(+£50)";
                default:
                    return "(no charge)";
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            // Add the booking to the booking service
            BookingService.Instance.AddBooking(_booking);

            MessageBox.Show("Booking confirmed successfully!", "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close this form and return to the booking form
            if (Application.OpenForms["BookingForm"] is BookingForm bookingForm)
            {
                // Clear the form for a new booking
                bookingForm.Show();
                this.Close();
            }
            else
            {
                // Create a new booking form if not found
                var newBookingForm = new BookingForm();
                newBookingForm.Show();
                this.Close();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Return to the booking form without saving
            if (Application.OpenForms["BookingForm"] is BookingForm bookingForm)
            {
                bookingForm.Show();
                this.Close();
            }
            else
            {
                var newBookingForm = new BookingForm();
                newBookingForm.Show();
                this.Close();
            }
        }
    }
}