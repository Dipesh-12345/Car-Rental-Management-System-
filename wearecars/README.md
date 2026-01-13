# WeAreCars Rental System

A Windows Forms-based car rental application built with C#.

## Description

WeAreCars Rental System is a complete car rental management application that allows staff to create and manage car rental bookings for customers. The application includes various features such as customer validation, pricing calculation based on rental duration and car type, and a comprehensive booking management system.

## Features

- **User Authentication**: Secure staff login system.
- **Customer Information Management**: Collect and validate customer details.
- **Car Selection**: Choose from different car types (City Car, Family Car, Sports Car, SUV) and fuel types (Petrol, Diesel, Hybrid, Electric).
- **Optional Extras**: Add additional services like unlimited mileage and breakdown cover.
- **Cost Calculation**: Automatic calculation of total rental cost based on selections.
- **Booking Summary**: View all booking details before confirmation.
- **Booking List**: View all confirmed bookings in a list format.

## Getting Started

### Prerequisites

- .NET 5.0 or later
- Windows operating system

### Installation

1. Clone the repository
2. Open the solution file in Visual Studio
3. Build the solution
4. Run the application

### Usage

1. Login with the following credentials:
   - Username: sta001
   - Password: givemethekeys123
2. Create a new booking by filling in the customer details and selecting rental options
3. View the booking summary and confirm
4. View all bookings in the list view

## System Requirements

- **Valid Login Credentials**:
  - Username: sta001
  - Password: givemethekeys123

- **Required Fields**:
  - Customer First Name
  - Customer Surname
  - Customer Address
  - Customer Age (must be 17 or older)
  - Valid Driving License
  - Number of Days (range 1-28, £25/day base rate)
  - Car Type and Fuel Type

- **Optional Extras**:
  - Unlimited Mileage (£10/day)
  - Breakdown Cover (£2/day)

- **Car Types and Pricing**:
  - City Car (base price)
  - Family Car (+£50)
  - Sports Car (+£75)
  - SUV (+£65)

- **Fuel Types and Pricing**:
  - Petrol/Diesel (no additional cost)
  - Hybrid (+£30)
  - Full Electric (+£50)

## License

This project is for educational purposes only.

## Acknowledgments

- Developed for academic submission
- Built with C# and Windows Forms 