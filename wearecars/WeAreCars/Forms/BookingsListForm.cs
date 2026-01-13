using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WeAreCars.Models;

namespace WeAreCars.Forms
{
    /// <summary>
    /// Form for displaying all bookings in a list view
    /// </summary>
    public partial class BookingsListForm : Form
    {
        public BookingsListForm()
        {
            InitializeComponent();
        }
        
        private void BookingsListForm_Load(object sender, EventArgs e)
        {
            // Set up columns
            lvBookings.Columns.Add("ID", 80);
            lvBookings.Columns.Add("Customer", 150);
            lvBookings.Columns.Add("Car Type", 100);
            lvBookings.Columns.Add("Fuel Type", 100);
            lvBookings.Columns.Add("Days", 50);
            lvBookings.Columns.Add("Total Cost", 100);
            lvBookings.Columns.Add("Booking Date", 150);

            // Load all bookings
            LoadBookings();
        }
        
        /// <summary>
        /// Loads all bookings from the booking manager into the list view
        /// </summary>
        private void LoadBookings()
        {
            // Clear existing items
            lvBookings.Items.Clear();
            
            // Get all bookings
            List<Booking> bookings = BookingManager.GetAllBookings();
            
            if (bookings.Count == 0)
            {
                // Show message if no bookings
                lblNoBookings.Visible = true;
                lvBookings.Visible = false;
                return;
            }
            
            // Hide message if there are bookings
            lblNoBookings.Visible = false;
            lvBookings.Visible = true;
            
            // Add each booking to the list view
            foreach (Booking booking in bookings)
            {
                ListViewItem item = new ListViewItem(booking.BookingId.ToString().Substring(0, 8));
                
                // Add subitems
                item.SubItems.Add($"{booking.FirstName} {booking.Surname}");
                item.SubItems.Add(booking.SelectedCarType.ToString());
                item.SubItems.Add(booking.SelectedFuelType.ToString());
                item.SubItems.Add(booking.NumberOfDays.ToString());
                item.SubItems.Add($"£{booking.TotalCost:F2}");
                item.SubItems.Add(booking.BookingDate.ToString("dd/MM/yyyy HH:mm"));
                
                // Store the booking in the tag for easy access
                item.Tag = booking;
                
                // Add to list view
                lvBookings.Items.Add(item);
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (lvBookings.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a booking to view details.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            // Get the selected booking
            var booking = (Booking)lvBookings.SelectedItems[0].Tag;
            
            // Show booking details in a summary form (read-only)
            var summaryForm = new BookingSummaryForm(booking);
            summaryForm.ShowDialog();
        }
        
        #region Windows Form Designer generated code
        
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lvBookings = new System.Windows.Forms.ListView();
            this.chId = new System.Windows.Forms.ColumnHeader();
            this.chCustomer = new System.Windows.Forms.ColumnHeader();
            this.chCarType = new System.Windows.Forms.ColumnHeader();
            this.chFuelType = new System.Windows.Forms.ColumnHeader();
            this.chDays = new System.Windows.Forms.ColumnHeader();
            this.chCost = new System.Windows.Forms.ColumnHeader();
            this.chDate = new System.Windows.Forms.ColumnHeader();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNoBookings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(776, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "All Bookings";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvBookings
            // 
            this.lvBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lvBookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chCustomer,
            this.chCarType,
            this.chFuelType,
            this.chDays,
            this.chCost,
            this.chDate});
            this.lvBookings.FullRowSelect = true;
            this.lvBookings.HideSelection = false;
            this.lvBookings.Location = new System.Drawing.Point(12, 48);
            this.lvBookings.MultiSelect = false;
            this.lvBookings.Name = "lvBookings";
            this.lvBookings.Size = new System.Drawing.Size(776, 352);
            this.lvBookings.TabIndex = 1;
            this.lvBookings.UseCompatibleStateImageBehavior = false;
            this.lvBookings.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 80;
            // 
            // chCustomer
            // 
            this.chCustomer.Text = "Customer";
            this.chCustomer.Width = 150;
            // 
            // chCarType
            // 
            this.chCarType.Text = "Car Type";
            this.chCarType.Width = 100;
            // 
            // chFuelType
            // 
            this.chFuelType.Text = "Fuel Type";
            this.chFuelType.Width = 100;
            // 
            // chDays
            // 
            this.chDays.Text = "Days";
            this.chDays.Width = 50;
            // 
            // chCost
            // 
            this.chCost.Text = "Total Cost";
            this.chCost.Width = 100;
            // 
            // chDate
            // 
            this.chDate.Text = "Booking Date";
            this.chDate.Width = 150;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(12, 406);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(150, 33);
            this.btnViewDetails.TabIndex = 2;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(638, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNoBookings
            // 
            this.lblNoBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoBookings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoBookings.ForeColor = System.Drawing.Color.Gray;
            this.lblNoBookings.Location = new System.Drawing.Point(12, 48);
            this.lblNoBookings.Name = "lblNoBookings";
            this.lblNoBookings.Size = new System.Drawing.Size(776, 352);
            this.lblNoBookings.TabIndex = 4;
            this.lblNoBookings.Text = "No bookings to display. Create a new booking first.";
            this.lblNoBookings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoBookings.Visible = false;
            // 
            // BookingsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.lblNoBookings);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.lvBookings);
            this.Controls.Add(this.lblTitle);
            this.Name = "BookingsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WeAreCars - All Bookings";
            this.Load += new System.EventHandler(this.BookingsListForm_Load);
            this.ResumeLayout(false);
        }
        
        #endregion
        
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lvBookings;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chCustomer;
        private System.Windows.Forms.ColumnHeader chCarType;
        private System.Windows.Forms.ColumnHeader chFuelType;
        private System.Windows.Forms.ColumnHeader chDays;
        private System.Windows.Forms.ColumnHeader chCost;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNoBookings;
    }
} 