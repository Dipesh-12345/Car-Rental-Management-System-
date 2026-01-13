using System;

namespace WeAreCars.Models
{
    public class Booking
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public bool HasValidLicense { get; set; }
        public int RentalDays { get; set; }
        public CarType CarType { get; set; }
        public FuelType FuelType { get; set; }
        public bool HasUnlimitedMileage { get; set; }
        public bool HasBreakdownCover { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime BookingDate { get; set; }

        public Booking()
        {
            BookingDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{FirstName} {Surname} - {CarType} ({RentalDays} days) - £{TotalCost:F2}";
        }
    }

    public enum CarType
    {
        CityCar,
        FamilyCar,
        SportsCar,
        SUV
    }

    public enum FuelType
    {
        PetrolDiesel,
        Hybrid,
        Electric
    }
}