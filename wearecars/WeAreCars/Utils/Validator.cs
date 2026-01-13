using System;
using System.Text.RegularExpressions;

namespace WeAreCars.Utils
{
    /// <summary>
    /// Provides validation methods for user inputs
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Validates that a text input is not empty
        /// </summary>
        /// <param name="input">The input to validate</param>
        /// <param name="fieldName">The name of the field being validated</param>
        /// <returns>Error message if invalid, null if valid</returns>
        public static string ValidateRequiredField(string input, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return $"{fieldName} is required.";
            }
            return null;
        }
        
        /// <summary>
        /// Validates that an age input is a valid number within an acceptable range
        /// </summary>
        /// <param name="ageText">The age input as text</param>
        /// <returns>Error message if invalid, null if valid</returns>
        public static string ValidateAge(string ageText)
        {
            if (string.IsNullOrWhiteSpace(ageText))
            {
                return "Age is required.";
            }
            
            if (!int.TryParse(ageText, out int age))
            {
                return "Age must be a valid number.";
            }
            
            if (age < 17)
            {
                return "Customers must be at least 17 years old to rent a vehicle.";
            }
            
            if (age > 120)
            {
                return "Please enter a valid age.";
            }
            
            return null;
        }
        
        /// <summary>
        /// Validates that the number of days is within the allowed range
        /// </summary>
        /// <param name="daysText">The days input as text</param>
        /// <returns>Error message if invalid, null if valid</returns>
        public static string ValidateDays(string daysText)
        {
            if (string.IsNullOrWhiteSpace(daysText))
            {
                return "Number of days is required.";
            }
            
            if (!int.TryParse(daysText, out int days))
            {
                return "Number of days must be a valid number.";
            }
            
            if (days < 1 || days > 28)
            {
                return "Number of days must be between 1 and 28.";
            }
            
            return null;
        }
        
        /// <summary>
        /// Validates login credentials
        /// </summary>
        /// <param name="username">The username to validate</param>
        /// <param name="password">The password to validate</param>
        /// <returns>Error message if invalid, null if valid</returns>
        public static string ValidateLogin(string username, string password)
        {
            const string VALID_USERNAME = "sta001";
            const string VALID_PASSWORD = "givemethekeys123";
            
            if (string.IsNullOrWhiteSpace(username))
            {
                return "Username is required.";
            }
            
            if (string.IsNullOrWhiteSpace(password))
            {
                return "Password is required.";
            }
            
            if (username != VALID_USERNAME || password != VALID_PASSWORD)
            {
                return "Invalid username or password.";
            }
            
            return null;
        }
    }
} 