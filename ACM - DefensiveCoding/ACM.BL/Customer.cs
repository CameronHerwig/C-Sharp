using ACM.Library;
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

        public OperationResult ValidateEmail()
        {
            var op = new OperationResult();

            if (string.IsNullOrWhiteSpace(this.EmailAddress))
            {
                op.Success = false;
                op.AddMessage("Email address is null");
            }

            if (op.Success)
            {
                var isValidFormat = true;
                // Code here that validates the format of the email
                // using Regular Expressions.
                if (!isValidFormat)
                {
                    op.Success = false;
                    op.AddMessage("Email address is not in a correct format");
                }
            }

            if (op.Success)
            {
                var isRealDomain = true;
                // Code here that confirms whether domain exists.
                if (!isRealDomain)
                {
                    op.Success = false;
                    op.AddMessage("Email address does not include a valid domain");
                }
            }
            return op;
        }

        public decimal CalculatePercentOfGoalSteps(string goalStepCount, string actualStepCount)
        {            
            if (string.IsNullOrWhiteSpace(goalStepCount)) throw new ArgumentException("Goal must be entered", "goalSteps");
            if (string.IsNullOrWhiteSpace(actualStepCount)) throw new ArgumentException("Actual steps count must be entered", "actualSteps");

            decimal goalSteps = 0;
            if (!decimal.TryParse(goalStepCount, out goalSteps)) throw new ArgumentException("Goal must be numeric");

            decimal actualSteps = 0;
            if (!decimal.TryParse(actualStepCount, out actualSteps)) throw new ArgumentException("Actual steps must be numeric", "actualSteps");

            return CalculatePercentOfGoalSteps(goalSteps, actualSteps);
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0) throw new ArgumentException("Goal must be greater than 0", "goalSteps");
            return Math.Round((actualStepCount / goalStepCount) * 100,2);
        }
    }
}
