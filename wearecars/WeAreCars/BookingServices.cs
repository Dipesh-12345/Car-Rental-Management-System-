using System;
using System.Collections.Generic;
using WeAreCars.Models;

namespace WeAreCars.Services
{
    public class BookingService
    {
        private static BookingService _instance;
        private readonly List<Booking> _bookings;

        // Singleton pattern
        public static BookingService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BookingService();
                }
                return _instance;
            }
        }

        private BookingService()
        {
            _bookings = new List<Booking>();
        }

        public List<Booking> GetAllBookings()
        {
            return _bookings;
        }

        public void AddBooking(Booking booking)
        {
            _bookings.Add(booking);
        }

        public decimal CalculateTotalCost(Booking booking)
        {
            // Base cost: £25 per day
            decimal baseCost = 25m * booking.RentalDays;

            // Additional cost based on car type
            decimal carTypeCost = 0;
            switch (booking.CarType)
            {
                case CarType.CityCar:
                    carTypeCost = 0;
                    break;
                case CarType.FamilyCar:
                    carTypeCost = 50;
                    break;
                case CarType.SportsCar:
                    carTypeCost = 75;
                    break;
                case CarType.SUV:
                    carTypeCost = 65;
                    break;
            }

            // Additional cost based on fuel type
            decimal fuelTypeCost = 0;
            switch (booking.FuelType)
            {
                case FuelType.PetrolDiesel:
                    fuelTypeCost = 0;
                    break;
                case FuelType.Hybrid:
                    fuelTypeCost = 30;
                    break;
                case FuelType.Electric:
                    fuelTypeCost = 50;
                    break;
            }

            // Optional extras
            decimal extrasTotal = 0;

            // Unlimited mileage: £10 per day
            if (booking.HasUnlimitedMileage)
            {
                extrasTotal += 10m * booking.RentalDays;
            }

            // Breakdown cover: £2 per day
            if (booking.HasBreakdownCover)
            {
                extrasTotal += 2m * booking.RentalDays;
            }

            return baseCost + carTypeCost + fuelTypeCost + extrasTotal;
        }
    }
}