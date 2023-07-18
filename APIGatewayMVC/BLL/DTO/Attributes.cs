using BLL.DTO.Organization;
using BLL.DTO.Statistic.Reports;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

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

    public class UrlValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string url = value as string;

            if (string.IsNullOrEmpty(url))
                return true;

            return Regex.IsMatch(url, "^[a-z0-9- ]+$", RegexOptions.IgnoreCase);
        }
    }
}
