using System;
using System.Collections.Generic;
using System.Linq;

namespace WeAreCars.Models
{
    /// <summary>
    /// Manages the collection of bookings and provides methods for calculating costs
    /// </summary>
    public class BookingManager
    {
        // Collection to store all bookings
        private static List<Booking> _bookings = new List<Booking>();
        
        // Base rate per day for car rental
        private const decimal BASE_RATE_PER_DAY = 25.0m;
        
        // Additional rates for optional extras
        private const decimal UNLIMITED_MILEAGE_RATE = 10.0m;
        private const decimal BREAKDOWN_COVER_RATE = 2.0m;
        
        /// <summary>
        /// Adds a new booking to the collection
        /// </summary>
        /// <param name="booking">The booking to add</param>
        public static void AddBooking(Booking booking)
        {
            booking.BookingDate = DateTime.Now;
            booking.TotalCost = CalculateTotalCost(booking);
            _bookings.Add(booking);
        }
        
        /// <summary>
        /// Retrieves all bookings
        /// </summary>
        /// <returns>A list of all bookings</returns>
        public static List<Booking> GetAllBookings()
        {
            return _bookings;
        }
        
        /// <summary>
        /// Calculates the total cost of a booking
        /// </summary>
        /// <param name="booking">The booking to calculate the cost for</param>
        /// <returns>The total cost of the booking</returns>
        public static decimal CalculateTotalCost(Booking booking)
        {
            // Base cost calculation (£25 per day)
            decimal totalCost = BASE_RATE_PER_DAY * booking.NumberOfDays;
            
            // Add car type premium
            totalCost += (int)booking.SelectedCarType;
            
            // Add fuel type premium
            totalCost += (int)booking.SelectedFuelType;
            
            // Add optional extras
            if (booking.HasUnlimitedMileage)
            {
                totalCost += UNLIMITED_MILEAGE_RATE * booking.NumberOfDays;
            }
            
            if (booking.HasBreakdownCover)
            {
                totalCost += BREAKDOWN_COVER_RATE * booking.NumberOfDays;
            }
            
            return totalCost;
        }
    }
} 