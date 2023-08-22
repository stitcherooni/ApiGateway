using BLL.DTO.Organisation;
using BLL.DTO.Statistic.Reports;
using BLL.DTO.Statistic.Reports.ProductQuestion.ForEventIdAndProductId;
using System;
using System.Collections;
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

    public class AnswerTypesAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && value.GetType() == typeof(string))
            {
                if (Enum.TryParse<AnswerType>((string)value, true, out _))
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult("Type should be a valid AnswerTypes.");
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ValidAnswerTypeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return true; // Allow null values

            Type validTypes = typeof(int); // Assuming number means integer

            Type valueType = value.GetType();

            if (validTypes.IsAssignableFrom(valueType) ||
                valueType == typeof(string) ||
                valueType == typeof(DateTime) ||
                valueType == typeof(byte[]) ||
                valueType == typeof(bool))
            {
                return true;
            }

            ErrorMessage = "The 'answer' property must have a valid type: number, string, Date, Blob, or boolean.";
            return false;
        }
    }
}
