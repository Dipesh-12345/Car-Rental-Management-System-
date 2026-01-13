using System;
using System.Windows.Forms;

namespace WeAreCars.Forms
{
    partial class BookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbCustomerDetails;
        private System.Windows.Forms.Label lblLicenseError;
        private System.Windows.Forms.Label lblAgeError;
        private System.Windows.Forms.Label lblAddressError;
        private System.Windows.Forms.Label lblSurnameError;
        private System.Windows.Forms.Label lblFirstNameError;
        private System.Windows.Forms.RadioButton rbNoLicense;
        private System.Windows.Forms.RadioButton rbYesLicense;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox gbBookingDetails;
        private System.Windows.Forms.Label lblDaysError;
        private System.Windows.Forms.CheckBox chkBreakdownCover;
        private System.Windows.Forms.CheckBox chkUnlimitedMileage;
        private System.Windows.Forms.ComboBox cmbFuelType;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.ComboBox cmbCarType;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Button btnViewBookings;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbCustomerDetails = new System.Windows.Forms.GroupBox();
            this.lblLicenseError = new System.Windows.Forms.Label();
            this.lblAgeError = new System.Windows.Forms.Label();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.lblSurnameError = new System.Windows.Forms.Label();
            this.lblFirstNameError = new System.Windows.Forms.Label();
            this.rbNoLicense = new System.Windows.Forms.RadioButton();
            this.rbYesLicense = new System.Windows.Forms.RadioButton();
            this.lblLicense = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbBookingDetails = new System.Windows.Forms.GroupBox();
            this.lblDaysError = new System.Windows.Forms.Label();
            this.chkBreakdownCover = new System.Windows.Forms.CheckBox();
            this.chkUnlimitedMileage = new System.Windows.Forms.CheckBox();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.cmbCarType = new System.Windows.Forms.ComboBox();
            this.lblCarType = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.btnViewBookings = new System.Windows.Forms.Button();
            this.gbCustomerDetails.SuspendLayout();
            this.gbBookingDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(776, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WeAreCars Booking System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbCustomerDetails
            // 
            this.gbCustomerDetails.Controls.Add(this.lblLicenseError);
            this.gbCustomerDetails.Controls.Add(this.lblAgeError);
            this.gbCustomerDetails.Controls.Add(this.lblAddressError);
            this.gbCustomerDetails.Controls.Add(this.lblSurnameError);
            this.gbCustomerDetails.Controls.Add(this.lblFirstNameError);
            this.gbCustomerDetails.Controls.Add(this.rbNoLicense);
            this.gbCustomerDetails.Controls.Add(this.rbYesLicense);
            this.gbCustomerDetails.Controls.Add(this.lblLicense);
            this.gbCustomerDetails.Controls.Add(this.txtAge);
            this.gbCustomerDetails.Controls.Add(this.lblAge);
            this.gbCustomerDetails.Controls.Add(this.txtAddress);
            this.gbCustomerDetails.Controls.Add(this.lblAddress);
            this.gbCustomerDetails.Controls.Add(this.txtSurname);
            this.gbCustomerDetails.Controls.Add(this.lblSurname);
            this.gbCustomerDetails.Controls.Add(this.txtFirstName);
            this.gbCustomerDetails.Controls.Add(this.lblFirstName);
            this.gbCustomerDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbCustomerDetails.Location = new System.Drawing.Point(12, 60);
            this.gbCustomerDetails.Name = "gbCustomerDetails";
            this.gbCustomerDetails.Size = new System.Drawing.Size(379, 352);
            this.gbCustomerDetails.TabIndex = 1;
            this.gbCustomerDetails.TabStop = false;
            this.gbCustomerDetails.Text = "Customer Details";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(21, 70);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(71, 17);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(106, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(254, 25);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(21, 127);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(61, 17);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(106, 124);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(254, 25);
            this.txtSurname.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(21, 184);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 17);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(106, 181);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(254, 25);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(21, 240);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 17);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(106, 237);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(254, 25);
            this.txtAge.TabIndex = 7;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new System.Drawing.Point(21, 294);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(79, 17);
            this.lblLicense.TabIndex = 8;
            this.lblLicense.Text = "Valid License";
            // 
            // rbYesLicense
            // 
            this.rbYesLicense.AutoSize = true;
            this.rbYesLicense.Location = new System.Drawing.Point(106, 294);
            this.rbYesLicense.Name = "rbYesLicense";
            this.rbYesLicense.Size = new System.Drawing.Size(44, 21);
            this.rbYesLicense.TabIndex = 9;
            this.rbYesLicense.TabStop = true;
            this.rbYesLicense.Text = "Yes";
            this.rbYesLicense.UseVisualStyleBackColor = true;
            // 
            // rbNoLicense
            // 
            this.rbNoLicense.AutoSize = true;
            this.rbNoLicense.Location = new System.Drawing.Point(156, 294);
            this.rbNoLicense.Name = "rbNoLicense";
            this.rbNoLicense.Size = new System.Drawing.Size(44, 21);
            this.rbNoLicense.TabIndex = 10;
            this.rbNoLicense.TabStop = true;
            this.rbNoLicense.Text = "No";
            this.rbNoLicense.UseVisualStyleBackColor = true;
            this.rbNoLicense.CheckedChanged += new System.EventHandler(this.rbNoLicense_CheckedChanged);
            // 
            // lblFirstNameError
            // 
            this.lblFirstNameError.ForeColor = System.Drawing.Color.Red;
            this.lblFirstNameError.Location = new System.Drawing.Point(21, 95);
            this.lblFirstNameError.Name = "lblFirstNameError";
            this.lblFirstNameError.Size = new System.Drawing.Size(339, 19);
            this.lblFirstNameError.TabIndex = 11;
            this.lblFirstNameError.Text = "Error Message";
            // 
            // lblSurnameError
            // 
            this.lblSurnameError.ForeColor = System.Drawing.Color.Red;
            this.lblSurnameError.Location = new System.Drawing.Point(21, 152);
            this.lblSurnameError.Name = "lblSurnameError";
            this.lblSurnameError.Size = new System.Drawing.Size(339, 19);
            this.lblSurnameError.TabIndex = 12;
            this.lblSurnameError.Text = "Error Message";
            // 
            // lblAddressError
            // 
            this.lblAddressError.ForeColor = System.Drawing.Color.Red;
            this.lblAddressError.Location = new System.Drawing.Point(21, 209);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(339, 19);
            this.lblAddressError.TabIndex = 13;
            this.lblAddressError.Text = "Error Message";
            // 
            // lblAgeError
            // 
            this.lblAgeError.ForeColor = System.Drawing.Color.Red;
            this.lblAgeError.Location = new System.Drawing.Point(21, 265);
            this.lblAgeError.Name = "lblAgeError";
            this.lblAgeError.Size = new System.Drawing.Size(339, 19);
            this.lblAgeError.TabIndex = 14;
            this.lblAgeError.Text = "Error Message";
            // 
            // lblLicenseError
            // 
            this.lblLicenseError.ForeColor = System.Drawing.Color.Red;
            this.lblLicenseError.Location = new System.Drawing.Point(21, 322);
            this.lblLicenseError.Name = "lblLicenseError";
            this.lblLicenseError.Size = new System.Drawing.Size(339, 19);
            this.lblLicenseError.TabIndex = 15;
            this.lblLicenseError.Text = "Error Message";
            // 
            // gbBookingDetails
            // 
            this.gbBookingDetails.Controls.Add(this.lblDaysError);
            this.gbBookingDetails.Controls.Add(this.chkBreakdownCover);
            this.gbBookingDetails.Controls.Add(this.chkUnlimitedMileage);
            this.gbBookingDetails.Controls.Add(this.cmbFuelType);
            this.gbBookingDetails.Controls.Add(this.lblFuelType);
            this.gbBookingDetails.Controls.Add(this.cmbCarType);
            this.gbBookingDetails.Controls.Add(this.lblCarType);
            this.gbBookingDetails.Controls.Add(this.txtDays);
            this.gbBookingDetails.Controls.Add(this.lblDays);
            this.gbBookingDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbBookingDetails.Location = new System.Drawing.Point(409, 60);
            this.gbBookingDetails.Name = "gbBookingDetails";
            this.gbBookingDetails.Size = new System.Drawing.Size(379, 352);
            this.gbBookingDetails.TabIndex = 2;
            this.gbBookingDetails.TabStop = false;
            this.gbBookingDetails.Text = "Booking Details";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(21, 70);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(79, 17);
            this.lblDays.TabIndex = 1;
            this.lblDays.Text = "No. of Days";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(106, 67);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(254, 25);
            this.txtDays.TabIndex = 2;
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Location = new System.Drawing.Point(21, 127);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(60, 17);
            this.lblCarType.TabIndex = 3;
            this.lblCarType.Text = "Car Type";
            // 
            // cmbCarType
            // 
            this.cmbCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarType.FormattingEnabled = true;
            this.cmbCarType.Location = new System.Drawing.Point(106, 124);
            this.cmbCarType.Name = "cmbCarType";
            this.cmbCarType.Size = new System.Drawing.Size(254, 25);
            this.cmbCarType.TabIndex = 4;
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new System.Drawing.Point(21, 184);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(65, 17);
            this.lblFuelType.TabIndex = 5;
            this.lblFuelType.Text = "Fuel Type";
            // 
            // cmbFuelType
            // 
            this.cmbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuelType.FormattingEnabled = true;
            this.cmbFuelType.Location = new System.Drawing.Point(106, 181);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new System.Drawing.Size(254, 25);
            this.cmbFuelType.TabIndex = 6;
            // 
            // chkUnlimitedMileage
            // 
            this.chkUnlimitedMileage.AutoSize = true;
            this.chkUnlimitedMileage.Location = new System.Drawing.Point(21, 240);
            this.chkUnlimitedMileage.Name = "chkUnlimitedMileage";
            this.chkUnlimitedMileage.Size = new System.Drawing.Size(190, 21);
            this.chkUnlimitedMileage.TabIndex = 7;
            this.chkUnlimitedMileage.Text = "Unlimited Mileage (+£10/day)";
            this.chkUnlimitedMileage.UseVisualStyleBackColor = true;
            // 
            // chkBreakdownCover
            // 
            this.chkBreakdownCover.AutoSize = true;
            this.chkBreakdownCover.Location = new System.Drawing.Point(21, 267);
            this.chkBreakdownCover.Name = "chkBreakdownCover";
            this.chkBreakdownCover.Size = new System.Drawing.Size(178, 21);
            this.chkBreakdownCover.TabIndex = 8;
            this.chkBreakdownCover.Text = "Breakdown Cover (+£2/day)";
            this.chkBreakdownCover.UseVisualStyleBackColor = true;
            // 
            // lblDaysError
            // 
            this.lblDaysError.ForeColor = System.Drawing.Color.Red;
            this.lblDaysError.Location = new System.Drawing.Point(21, 95);
            this.lblDaysError.Name = "lblDaysError";
            this.lblDaysError.Size = new System.Drawing.Size(339, 19);
            this.lblDaysError.TabIndex = 16;
            this.lblDaysError.Text = "Error Message";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(12, 428);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 34);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCreateBooking.FlatAppearance.BorderSize = 0;
            this.btnCreateBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBooking.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateBooking.ForeColor = System.Drawing.Color.White;
            this.btnCreateBooking.Location = new System.Drawing.Point(168, 428);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(150, 34);
            this.btnCreateBooking.TabIndex = 4;
            this.btnCreateBooking.Text = "Create Booking";
            this.btnCreateBooking.UseVisualStyleBackColor = false;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // btnViewBookings
            // 
            this.btnViewBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnViewBookings.FlatAppearance.BorderSize = 0;
            this.btnViewBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBookings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewBookings.ForeColor = System.Drawing.Color.White;
            this.btnViewBookings.Location = new System.Drawing.Point(638, 428);
            this.btnViewBookings.Name = "btnViewBookings";
            this.btnViewBookings.Size = new System.Drawing.Size(150, 34);
            this.btnViewBookings.TabIndex = 5;
            this.btnViewBookings.Text = "View Bookings";
            this.btnViewBookings.UseVisualStyleBackColor = false;
            this.btnViewBookings.Click += new System.EventHandler(this.btnViewBookings_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.btnViewBookings);
            this.Controls.Add(this.btnCreateBooking);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbBookingDetails);
            this.Controls.Add(this.gbCustomerDetails);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeAreCars - New Booking";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.gbCustomerDetails.ResumeLayout(false);
            this.gbCustomerDetails.PerformLayout();
            this.gbBookingDetails.ResumeLayout(false);
            this.gbBookingDetails.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
} 