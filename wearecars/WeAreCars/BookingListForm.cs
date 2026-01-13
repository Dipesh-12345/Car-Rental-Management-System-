using System;
using System.Drawing;
using System.Windows.Forms;
using WeAreCars.Models;
using WeAreCars.Services;

namespace WeAreCars.Forms
{
    public class BookingListForm : Form
    {
        private ListBox _bookingsListBox;
        private Button _closeButton;
        private Panel _detailsPanel;
        private Label _detailsLabel;

        public BookingListForm()
        {
            InitializeComponent();
            LoadBookings();
        }

        private void InitializeComponent()
        {
            // Initialize form properties
            this.Text = "WeAreCars - Booking List";
            this.Size = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // Create title label
            Label titleLabel = new Label
            {
                Text = "All Bookings",
                Font = new Font("Arial", 18, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Size = new Size(800, 40),
                Location = new Point(0, 20),
                Dock = DockStyle.Top
            };

            // Create main content panel
            Panel contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20, 10, 20, 10)
            };

            // Create bookings listbox with border
            Panel listBoxBorderPanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(720, 260),
                Location = new Point(30, 10),
                Padding = new Padding(1)
            };

            _bookingsListBox = new ListBox
            {
                Font = new Font("Arial", 12, FontStyle.Regular),
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.None
            };
            _bookingsListBox.SelectedIndexChanged += BookingsListBox_SelectedIndexChanged;

            listBoxBorderPanel.Controls.Add(_bookingsListBox);
            contentPanel.Controls.Add(listBoxBorderPanel);

            // Create details panel with better spacing
            _detailsPanel = new Panel
            {
                Size = new Size(720, 180),
                Location = new Point(30, 290),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.WhiteSmoke
            };
            contentPanel.Controls.Add(_detailsPanel);

            // Create details label
            _detailsLabel = new Label
            {
                Text = "Select a booking to view details",
                Font = new Font("Arial", 12, FontStyle.Regular),
                TextAlign = ContentAlignment.TopLeft,
                AutoSize = false,
                Size = new Size(700, 160),
                Location = new Point(10, 10)
            };
            _detailsPanel.Controls.Add(_detailsLabel);

            // Create button panel at bottom
            Panel buttonPanel = new Panel
            {
                Height = 60,
                Dock = DockStyle.Bottom,
                BackColor = Color.WhiteSmoke
            };

            // Create close button in center
            _closeButton = new Button
            {
                Text = "Close",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Size = new Size(120, 40),
                Location = new Point(340, 10),
                BackColor = Color.LightBlue
            };
            _closeButton.Click += CloseButton_Click;
            buttonPanel.Controls.Add(_closeButton);

            // Add panels to form
            this.Controls.Add(buttonPanel);
            this.Controls.Add(contentPanel);
            this.Controls.Add(titleLabel);
        }

        private void LoadBookings()
        {
            // Clear the current list
            _bookingsListBox.Items.Clear();

            // Get all bookings from the service
            var bookings = BookingService.Instance.GetAllBookings();

            if (bookings.Count == 0)
            {
                _bookingsListBox.Items.Add("No bookings available");
                _bookingsListBox.Enabled = false;
            }
            else
            {
                foreach (var booking in bookings)
                {
                    _bookingsListBox.Items.Add(booking);
                }
                _bookingsListBox.Enabled = true;
            }
        }

        private void BookingsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_bookingsListBox.SelectedItem != null && _bookingsListBox.SelectedItem is Booking selectedBooking)
            {
                DisplayBookingDetails(selectedBooking);
            }
            else
            {
                _detailsLabel.Text = "Select a booking to view details";
            }
        }

        private void DisplayBookingDetails(Booking booking)
        {
            // Format the details string
            string details = $"Booking Details:\n\n" +
                             $"Customer: {booking.FirstName} {booking.Surname}\n" +
                             $"Address: {booking.Address}\n" +
                             $"Age: {booking.Age}\n" +
                             $"Valid License: {(booking.HasValidLicense ? "Yes" : "No")}\n\n" +
                             $"Rental Days: {booking.RentalDays}\n" +
                             $"Car Type: {booking.CarType}\n" +
                             $"Fuel Type: {booking.FuelType}\n" +
                             $"Unlimited Mileage: {(booking.HasUnlimitedMileage ? "Yes" : "No")}\n" +
                             $"Breakdown Cover: {(booking.HasBreakdownCover ? "Yes" : "No")}\n\n" +
                             $"Total Cost: £{booking.TotalCost:F2}\n" +
                             $"Booking Date: {booking.BookingDate}";

            _detailsLabel.Text = details;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}