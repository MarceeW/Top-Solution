#nullable disable
using System.ComponentModel.DataAnnotations;

namespace TopSolution.Models
{
    public class DateRangeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dt = (DateTime)value;
            if (dt < DateTime.UtcNow)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage ?? "You can't pass date that is greater than now!");
        }

    }
}
