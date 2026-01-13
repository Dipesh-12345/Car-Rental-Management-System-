using System;
using System.Drawing;
using System.Windows.Forms;
using WeAreCars.Models;

namespace WeAreCars.Forms
{
    /// <summary>
    /// Form for displaying a summary of the booking before confirming
    /// </summary>
    public partial class BookingSummaryForm : Form
    {
        private readonly Booking _booking;
        
        // Event to notify that the booking has been confirmed
        public event EventHandler BookingConfirmed;
        
        public BookingSummaryForm(Booking booking)
        {
            InitializeComponent();
            _booking = booking;
        }
        
        private void BookingSummaryForm_Load(object sender, EventArgs e)
        {
            // Set the form title
            this.Text = $"Booking Summary - {_booking.FirstName} {_booking.Surname}";
            
            // Populate the summary text box with booking details
            txtSummary.Text = GetBookingSummaryText();
            
            // Display the total cost
            lblTotalCost.Text = $"Total Cost: £{_booking.TotalCost:F2}";
        }
        
        /// <summary>
        /// Generates a formatted summary of the booking details
        /// </summary>
        private string GetBookingSummaryText()
        {
            string carType = _booking.SelectedCarType.ToString();
            string fuelType = _booking.SelectedFuelType.ToString();
            
            return $"BOOKING SUMMARY\r\n" +
                   $"==============\r\n\r\n" +
                   $"Customer Details:\r\n" +
                   $"----------------\r\n" +
                   $"Name: {_booking.FirstName} {_booking.Surname}\r\n" +
                   $"Address: {_booking.Address}\r\n" +
                   $"Age: {_booking.Age}\r\n" +
                   $"Valid License: {(_booking.HasValidLicense ? "Yes" : "No")}\r\n\r\n" +
                   $"Booking Details:\r\n" +
                   $"----------------\r\n" +
                   $"Number of Days: {_booking.NumberOfDays}\r\n" +
                   $"Car Type: {carType}\r\n" +
                   $"Fuel Type: {fuelType}\r\n\r\n" +
                   $"Optional Extras:\r\n" +
                   $"----------------\r\n" +
                   $"Unlimited Mileage: {(_booking.HasUnlimitedMileage ? "Yes (+£10/day)" : "No")}\r\n" +
                   $"Breakdown Cover: {(_booking.HasBreakdownCover ? "Yes (+£2/day)" : "No")}\r\n\r\n" +
                   $"Base Rate: £25 per day\r\n" +
                   $"Car Type Premium: £{(int)_booking.SelectedCarType}\r\n" +
                   $"Fuel Type Premium: £{(int)_booking.SelectedFuelType}\r\n" +
                   $"Unlimited Mileage: {(_booking.HasUnlimitedMileage ? $"£{10 * _booking.NumberOfDays}" : "£0")}\r\n" +
                   $"Breakdown Cover: {(_booking.HasBreakdownCover ? $"£{2 * _booking.NumberOfDays}" : "£0")}\r\n";
        }
        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Add the booking to the manager
            BookingManager.AddBooking(_booking);
            
            // Raise the booking confirmed event
            BookingConfirmed?.Invoke(this, EventArgs.Empty);
            
            // Show confirmation message
            MessageBox.Show("Booking confirmed successfully!", "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Close the form
            this.Close();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form without confirming the booking
            this.Close();
        }
        
        #region Windows Form Designer generated code
        
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(460, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Booking Summary";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSummary
            // 
            this.txtSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSummary.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSummary.Location = new System.Drawing.Point(12, 48);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSummary.Size = new System.Drawing.Size(460, 352);
            this.txtSummary.TabIndex = 1;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCost.Location = new System.Drawing.Point(12, 403);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(460, 25);
            this.lblTotalCost.TabIndex = 2;
            this.lblTotalCost.Text = "Total Cost: £0.00";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(372, 446);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 33);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(266, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 33);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BookingSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 491);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookingSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Booking Summary";
            this.Load += new System.EventHandler(this.BookingSummaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        
        #endregion
        
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
} 