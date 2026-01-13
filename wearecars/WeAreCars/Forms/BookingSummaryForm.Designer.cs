using System;
using System.Windows.Forms;

namespace WeAreCars.Forms
{
    partial class BookingSummaryForm
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

        private Label lblTitle;
        private GroupBox gbCustomerDetails;
        private Label lblCustomerName;
        private Label lblCustomerNameValue;
        private Label lblAddress;
        private Label lblAddressValue;
        private Label lblAge;
        private Label lblAgeValue;
        private Label lblLicense;
        private Label lblLicenseValue;
        
        private GroupBox gbRentalDetails;
        private Label lblDays;
        private Label lblDaysValue;
        private Label lblCarType;
        private Label lblCarTypeValue;
        private Label lblFuelType;
        private Label lblFuelTypeValue;
        
        private GroupBox gbExtras;
        private Label lblMileage;
        private Label lblMileageValue;
        private Label lblBreakdown;
        private Label lblBreakdownValue;
        
        private GroupBox gbCostSummary;
        private Label lblBaseCost;
        private Label lblBaseCostValue;
        private Label lblCarPremium;
        private Label lblCarPremiumValue;
        private Label lblFuelPremium;
        private Label lblFuelPremiumValue;
        private Label lblExtrasCost;
        private Label lblExtrasCostValue;
        private Label lblTotalCost;
        private Label lblTotalCostValue;
        
        private Button btnConfirm;
        private Button btnCancel;
        
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.gbCustomerDetails = new GroupBox();
            this.lblLicenseValue = new Label();
            this.lblLicense = new Label();
            this.lblAgeValue = new Label();
            this.lblAge = new Label();
            this.lblAddressValue = new Label();
            this.lblAddress = new Label();
            this.lblCustomerNameValue = new Label();
            this.lblCustomerName = new Label();
            
            this.gbRentalDetails = new GroupBox();
            this.lblFuelTypeValue = new Label();
            this.lblFuelType = new Label();
            this.lblCarTypeValue = new Label();
            this.lblCarType = new Label();
            this.lblDaysValue = new Label();
            this.lblDays = new Label();
            
            this.gbExtras = new GroupBox();
            this.lblBreakdownValue = new Label();
            this.lblBreakdown = new Label();
            this.lblMileageValue = new Label();
            this.lblMileage = new Label();
            
            this.gbCostSummary = new GroupBox();
            this.lblTotalCostValue = new Label();
            this.lblTotalCost = new Label();
            this.lblExtrasCostValue = new Label();
            this.lblExtrasCost = new Label();
            this.lblFuelPremiumValue = new Label();
            this.lblFuelPremium = new Label();
            this.lblCarPremiumValue = new Label();
            this.lblCarPremium = new Label();
            this.lblBaseCostValue = new Label();
            this.lblBaseCost = new Label();
            
            this.btnConfirm = new Button();
            this.btnCancel = new Button();
            
            this.gbCustomerDetails.SuspendLayout();
            this.gbRentalDetails.SuspendLayout();
            this.gbExtras.SuspendLayout();
            this.gbCostSummary.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(560, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Booking Summary";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // gbCustomerDetails
            // 
            this.gbCustomerDetails.Controls.Add(this.lblLicenseValue);
            this.gbCustomerDetails.Controls.Add(this.lblLicense);
            this.gbCustomerDetails.Controls.Add(this.lblAgeValue);
            this.gbCustomerDetails.Controls.Add(this.lblAge);
            this.gbCustomerDetails.Controls.Add(this.lblAddressValue);
            this.gbCustomerDetails.Controls.Add(this.lblAddress);
            this.gbCustomerDetails.Controls.Add(this.lblCustomerNameValue);
            this.gbCustomerDetails.Controls.Add(this.lblCustomerName);
            this.gbCustomerDetails.Location = new System.Drawing.Point(12, 48);
            this.gbCustomerDetails.Name = "gbCustomerDetails";
            this.gbCustomerDetails.Size = new System.Drawing.Size(275, 160);
            this.gbCustomerDetails.TabIndex = 1;
            this.gbCustomerDetails.TabStop = false;
            this.gbCustomerDetails.Text = "Customer Details";
            
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerName.Location = new System.Drawing.Point(15, 25);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(45, 15);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Name:";
            
            // 
            // lblCustomerNameValue
            // 
            this.lblCustomerNameValue.AutoSize = true;
            this.lblCustomerNameValue.Location = new System.Drawing.Point(120, 25);
            this.lblCustomerNameValue.Name = "lblCustomerNameValue";
            this.lblCustomerNameValue.Size = new System.Drawing.Size(88, 15);
            this.lblCustomerNameValue.TabIndex = 1;
            this.lblCustomerNameValue.Text = "[Customer Name]";
            
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(15, 50);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 15);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.Location = new System.Drawing.Point(120, 50);
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(149, 50);
            this.lblAddressValue.TabIndex = 3;
            this.lblAddressValue.Text = "[Address]";
            
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAge.Location = new System.Drawing.Point(15, 100);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 15);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age:";
            
            // 
            // lblAgeValue
            // 
            this.lblAgeValue.AutoSize = true;
            this.lblAgeValue.Location = new System.Drawing.Point(120, 100);
            this.lblAgeValue.Name = "lblAgeValue";
            this.lblAgeValue.Size = new System.Drawing.Size(33, 15);
            this.lblAgeValue.TabIndex = 5;
            this.lblAgeValue.Text = "[Age]";
            
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLicense.Location = new System.Drawing.Point(15, 125);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(82, 15);
            this.lblLicense.TabIndex = 6;
            this.lblLicense.Text = "Valid License:";
            
            // 
            // lblLicenseValue
            // 
            this.lblLicenseValue.AutoSize = true;
            this.lblLicenseValue.Location = new System.Drawing.Point(120, 125);
            this.lblLicenseValue.Name = "lblLicenseValue";
            this.lblLicenseValue.Size = new System.Drawing.Size(56, 15);
            this.lblLicenseValue.TabIndex = 7;
            this.lblLicenseValue.Text = "[Yes/No]";
            
            // 
            // gbRentalDetails
            // 
            this.gbRentalDetails.Controls.Add(this.lblFuelTypeValue);
            this.gbRentalDetails.Controls.Add(this.lblFuelType);
            this.gbRentalDetails.Controls.Add(this.lblCarTypeValue);
            this.gbRentalDetails.Controls.Add(this.lblCarType);
            this.gbRentalDetails.Controls.Add(this.lblDaysValue);
            this.gbRentalDetails.Controls.Add(this.lblDays);
            this.gbRentalDetails.Location = new System.Drawing.Point(293, 48);
            this.gbRentalDetails.Name = "gbRentalDetails";
            this.gbRentalDetails.Size = new System.Drawing.Size(275, 100);
            this.gbRentalDetails.TabIndex = 2;
            this.gbRentalDetails.TabStop = false;
            this.gbRentalDetails.Text = "Rental Details";
            
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDays.Location = new System.Drawing.Point(15, 25);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(37, 15);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Days:";
            
            // 
            // lblDaysValue
            // 
            this.lblDaysValue.AutoSize = true;
            this.lblDaysValue.Location = new System.Drawing.Point(120, 25);
            this.lblDaysValue.Name = "lblDaysValue";
            this.lblDaysValue.Size = new System.Drawing.Size(39, 15);
            this.lblDaysValue.TabIndex = 1;
            this.lblDaysValue.Text = "[Days]";
            
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarType.Location = new System.Drawing.Point(15, 50);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(59, 15);
            this.lblCarType.TabIndex = 2;
            this.lblCarType.Text = "Car Type:";
            
            // 
            // lblCarTypeValue
            // 
            this.lblCarTypeValue.AutoSize = true;
            this.lblCarTypeValue.Location = new System.Drawing.Point(120, 50);
            this.lblCarTypeValue.Name = "lblCarTypeValue";
            this.lblCarTypeValue.Size = new System.Drawing.Size(60, 15);
            this.lblCarTypeValue.TabIndex = 3;
            this.lblCarTypeValue.Text = "[Car Type]";
            
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFuelType.Location = new System.Drawing.Point(15, 75);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(65, 15);
            this.lblFuelType.TabIndex = 4;
            this.lblFuelType.Text = "Fuel Type:";
            
            // 
            // lblFuelTypeValue
            // 
            this.lblFuelTypeValue.AutoSize = true;
            this.lblFuelTypeValue.Location = new System.Drawing.Point(120, 75);
            this.lblFuelTypeValue.Name = "lblFuelTypeValue";
            this.lblFuelTypeValue.Size = new System.Drawing.Size(62, 15);
            this.lblFuelTypeValue.TabIndex = 5;
            this.lblFuelTypeValue.Text = "[Fuel Type]";
            
            // 
            // gbExtras
            // 
            this.gbExtras.Controls.Add(this.lblBreakdownValue);
            this.gbExtras.Controls.Add(this.lblBreakdown);
            this.gbExtras.Controls.Add(this.lblMileageValue);
            this.gbExtras.Controls.Add(this.lblMileage);
            this.gbExtras.Location = new System.Drawing.Point(293, 154);
            this.gbExtras.Name = "gbExtras";
            this.gbExtras.Size = new System.Drawing.Size(275, 54);
            this.gbExtras.TabIndex = 3;
            this.gbExtras.TabStop = false;
            this.gbExtras.Text = "Optional Extras";
            
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMileage.Location = new System.Drawing.Point(15, 24);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(55, 15);
            this.lblMileage.TabIndex = 0;
            this.lblMileage.Text = "Mileage:";
            
            // 
            // lblMileageValue
            // 
            this.lblMileageValue.AutoSize = true;
            this.lblMileageValue.Location = new System.Drawing.Point(79, 24);
            this.lblMileageValue.Name = "lblMileageValue";
            this.lblMileageValue.Size = new System.Drawing.Size(56, 15);
            this.lblMileageValue.TabIndex = 1;
            this.lblMileageValue.Text = "[Yes/No]";
            
            // 
            // lblBreakdown
            // 
            this.lblBreakdown.AutoSize = true;
            this.lblBreakdown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBreakdown.Location = new System.Drawing.Point(141, 24);
            this.lblBreakdown.Name = "lblBreakdown";
            this.lblBreakdown.Size = new System.Drawing.Size(73, 15);
            this.lblBreakdown.TabIndex = 2;
            this.lblBreakdown.Text = "Breakdown:";
            
            // 
            // lblBreakdownValue
            // 
            this.lblBreakdownValue.AutoSize = true;
            this.lblBreakdownValue.Location = new System.Drawing.Point(214, 24);
            this.lblBreakdownValue.Name = "lblBreakdownValue";
            this.lblBreakdownValue.Size = new System.Drawing.Size(56, 15);
            this.lblBreakdownValue.TabIndex = 3;
            this.lblBreakdownValue.Text = "[Yes/No]";
            
            // 
            // gbCostSummary
            // 
            this.gbCostSummary.Controls.Add(this.lblTotalCostValue);
            this.gbCostSummary.Controls.Add(this.lblTotalCost);
            this.gbCostSummary.Controls.Add(this.lblExtrasCostValue);
            this.gbCostSummary.Controls.Add(this.lblExtrasCost);
            this.gbCostSummary.Controls.Add(this.lblFuelPremiumValue);
            this.gbCostSummary.Controls.Add(this.lblFuelPremium);
            this.gbCostSummary.Controls.Add(this.lblCarPremiumValue);
            this.gbCostSummary.Controls.Add(this.lblCarPremium);
            this.gbCostSummary.Controls.Add(this.lblBaseCostValue);
            this.gbCostSummary.Controls.Add(this.lblBaseCost);
            this.gbCostSummary.Location = new System.Drawing.Point(12, 214);
            this.gbCostSummary.Name = "gbCostSummary";
            this.gbCostSummary.Size = new System.Drawing.Size(556, 130);
            this.gbCostSummary.TabIndex = 4;
            this.gbCostSummary.TabStop = false;
            this.gbCostSummary.Text = "Cost Summary";
            
            // 
            // lblBaseCost
            // 
            this.lblBaseCost.AutoSize = true;
            this.lblBaseCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBaseCost.Location = new System.Drawing.Point(15, 25);
            this.lblBaseCost.Name = "lblBaseCost";
            this.lblBaseCost.Size = new System.Drawing.Size(165, 15);
            this.lblBaseCost.TabIndex = 0;
            this.lblBaseCost.Text = "Base Cost (£25 per day × Days):";
            
            // 
            // lblBaseCostValue
            // 
            this.lblBaseCostValue.AutoSize = true;
            this.lblBaseCostValue.Location = new System.Drawing.Point(450, 25);
            this.lblBaseCostValue.Name = "lblBaseCostValue";
            this.lblBaseCostValue.Size = new System.Drawing.Size(38, 15);
            this.lblBaseCostValue.TabIndex = 1;
            this.lblBaseCostValue.Text = "[Cost]";
            
            // 
            // lblCarPremium
            // 
            this.lblCarPremium.AutoSize = true;
            this.lblCarPremium.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarPremium.Location = new System.Drawing.Point(15, 45);
            this.lblCarPremium.Name = "lblCarPremium";
            this.lblCarPremium.Size = new System.Drawing.Size(83, 15);
            this.lblCarPremium.TabIndex = 2;
            this.lblCarPremium.Text = "Car Premium:";
            
            // 
            // lblCarPremiumValue
            // 
            this.lblCarPremiumValue.AutoSize = true;
            this.lblCarPremiumValue.Location = new System.Drawing.Point(450, 45);
            this.lblCarPremiumValue.Name = "lblCarPremiumValue";
            this.lblCarPremiumValue.Size = new System.Drawing.Size(38, 15);
            this.lblCarPremiumValue.TabIndex = 3;
            this.lblCarPremiumValue.Text = "[Cost]";
            
            // 
            // lblFuelPremium
            // 
            this.lblFuelPremium.AutoSize = true;
            this.lblFuelPremium.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFuelPremium.Location = new System.Drawing.Point(15, 65);
            this.lblFuelPremium.Name = "lblFuelPremium";
            this.lblFuelPremium.Size = new System.Drawing.Size(86, 15);
            this.lblFuelPremium.TabIndex = 4;
            this.lblFuelPremium.Text = "Fuel Premium:";
            
            // 
            // lblFuelPremiumValue
            // 
            this.lblFuelPremiumValue.AutoSize = true;
            this.lblFuelPremiumValue.Location = new System.Drawing.Point(450, 65);
            this.lblFuelPremiumValue.Name = "lblFuelPremiumValue";
            this.lblFuelPremiumValue.Size = new System.Drawing.Size(38, 15);
            this.lblFuelPremiumValue.TabIndex = 5;
            this.lblFuelPremiumValue.Text = "[Cost]";
            
            // 
            // lblExtrasCost
            // 
            this.lblExtrasCost.AutoSize = true;
            this.lblExtrasCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExtrasCost.Location = new System.Drawing.Point(15, 85);
            this.lblExtrasCost.Name = "lblExtrasCost";
            this.lblExtrasCost.Size = new System.Drawing.Size(90, 15);
            this.lblExtrasCost.TabIndex = 6;
            this.lblExtrasCost.Text = "Optional Extras:";
            
            // 
            // lblExtrasCostValue
            // 
            this.lblExtrasCostValue.AutoSize = true;
            this.lblExtrasCostValue.Location = new System.Drawing.Point(450, 85);
            this.lblExtrasCostValue.Name = "lblExtrasCostValue";
            this.lblExtrasCostValue.Size = new System.Drawing.Size(38, 15);
            this.lblExtrasCostValue.TabIndex = 7;
            this.lblExtrasCostValue.Text = "[Cost]";
            
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCost.Location = new System.Drawing.Point(15, 105);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(81, 17);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.Text = "TOTAL COST";
            
            // 
            // lblTotalCostValue
            // 
            this.lblTotalCostValue.AutoSize = true;
            this.lblTotalCostValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCostValue.Location = new System.Drawing.Point(450, 105);
            this.lblTotalCostValue.Name = "lblTotalCostValue";
            this.lblTotalCostValue.Size = new System.Drawing.Size(49, 17);
            this.lblTotalCostValue.TabIndex = 9;
            this.lblTotalCostValue.Text = "[Total]";
            
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(120, 350);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 35);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm Booking";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(315, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            
            // 
            // BookingSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 400);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbCostSummary);
            this.Controls.Add(this.gbExtras);
            this.Controls.Add(this.gbRentalDetails);
            this.Controls.Add(this.gbCustomerDetails);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BookingSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeAreCars - Booking Summary";
            this.Load += new System.EventHandler(this.BookingSummaryForm_Load);
            this.gbCustomerDetails.ResumeLayout(false);
            this.gbCustomerDetails.PerformLayout();
            this.gbRentalDetails.ResumeLayout(false);
            this.gbRentalDetails.PerformLayout();
            this.gbExtras.ResumeLayout(false);
            this.gbExtras.PerformLayout();
            this.gbCostSummary.ResumeLayout(false);
            this.gbCostSummary.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
} 