using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void ValidateEmail()
        {
            // -- Send an email receipt --
            // If the user requested a receipt
            // Get the customer data
            // Ensure a valid email address was provided.
            // If not,
            // request an email address from the user.
        }

        public decimal CalculatePercentOfGoalSteps(string goalStepCount, string actualStepCount)
        {
            decimal goalSteps = 0;
            decimal actualSteps = 0;

            if (string.IsNullOrWhiteSpace(goalStepCount)) throw new ArgumentException("Goal must be entered", "goalSteps");
            if (string.IsNullOrWhiteSpace(actualStepCount)) throw new ArgumentException("Actual steps count must be entered", "actualSteps");

            if (!decimal.TryParse(goalStepCount, out goalSteps)) throw new ArgumentException("Goal must be numeric", "goalSteps");
            if (!decimal.TryParse(actualStepCount, out actualSteps)) throw new ArgumentException("Actual steps must be numeric", "actualSteps");

            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0) throw new ArgumentException("Goal must be greater than 0", "goalSteps");
            return (actualStepCount / goalStepCount) * 100;
        }
    }
}
