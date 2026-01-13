using System;

namespace WeAreCars.Models
{
    /// <summary>
    /// Represents a car rental booking in the WeAreCars Rental System
    /// </summary>
    public class Booking
    {
        // Customer details
        public string FirstName { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int Age { get; set; }
        public bool HasValidLicense { get; set; }
        
        // Booking details
        public int NumberOfDays { get; set; }
        public CarType SelectedCarType { get; set; }
        public FuelType SelectedFuelType { get; set; }
        
        // Optional extras
        public bool HasUnlimitedMileage { get; set; }
        public bool HasBreakdownCover { get; set; }
        
        // Calculated fields
        public decimal TotalCost { get; set; }
        public DateTime BookingDate { get; set; }
        
        // Unique ID for the booking
        public Guid BookingId { get; set; } = Guid.NewGuid();
    }
    
    /// <summary>
    /// Represents the available car types and their price premiums
    /// </summary>
    public enum CarType
    {
        CityCar = 0,      // Base price
        FamilyCar = 50,   // +£50
        SportsCar = 75,   // +£75
        SUV = 65          // +£65
    }
    
    /// <summary>
    /// Represents the available fuel types and their price premiums
    /// </summary>
    public enum FuelType
    {
        Petrol = 0,     // Base price
        Diesel = 0,     // Base price
        Hybrid = 30,    // +£30
        Electric = 50   // +£50
    }
} 