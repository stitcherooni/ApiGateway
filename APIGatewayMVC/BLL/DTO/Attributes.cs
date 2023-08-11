using BLL.DTO.Organisation;
using BLL.DTO.Statistic.Reports;
using System;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO
{
    public class ReportTypeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && value.GetType() == typeof(string))
            {
                string lowercaseValue = ((string)value).ToLower();

                if (Enum.TryParse<ReportTypes>(lowercaseValue, true, out _))
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult("Type should be a valid ReportTypes.");
        }
    }

    public class RoleAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && value.GetType() == typeof(string))
            {
                string lowercaseValue = ((string)value).ToLower();

                if (Enum.TryParse<Roles>(lowercaseValue, true, out _))
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult("Invalid Role value.");
        }
    }

    public class MinimumDataTime : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && value is DateTime erasureDate)
            {
                if (erasureDate < DateTime.Now)
                {
                    return new ValidationResult("ErasureDate must not be earlier than the current date and time.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
