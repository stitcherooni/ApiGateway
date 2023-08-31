using BLL.DTO.Organisation;
using BLL.DTO.Statistic.Reports;
using BLL.DTO.Statistic.Reports.ProductQuestion.ForEventIdAndProductId;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO
{
    public class ReportTypeAttribute : ValidationAttribute
    {
    
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var serviceProvider = validationContext.GetService(typeof(IServiceProvider)) as IServiceProvider;
            var logger = serviceProvider.GetService(typeof(ILogger<ReportTypeAttribute>)) as ILogger<ReportTypeAttribute>;

            if (value != null && value.GetType() == typeof(string))
            {
                string lowercaseValue = ((string)value).ToLower();

                if (Enum.TryParse<ReportTypes>(lowercaseValue, true, out _))
                {
                    return ValidationResult.Success;
                }
            }

            logger.LogWarning($"Type {value} doesn't exist");
            return new ValidationResult("Type should be a valid ReportTypes.");
        }
    }

    public class RoleAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var serviceProvider = validationContext.GetService(typeof(IServiceProvider)) as IServiceProvider;
            var logger = serviceProvider.GetService(typeof(ILogger<RoleAttribute>)) as ILogger<RoleAttribute>;

            if (value != null && value.GetType() == typeof(string))
            {
                string lowercaseValue = ((string)value).ToLower();

                if (Enum.TryParse<Roles>(lowercaseValue, true, out _))
                {
                    return ValidationResult.Success;
                }
            }

            logger.LogWarning($"Role {value} doesn't exist");
            return new ValidationResult("Invalid Role value.");
        }
    }

    public class MinimumDataTime : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var serviceProvider = validationContext.GetService(typeof(IServiceProvider)) as IServiceProvider;
            var logger = serviceProvider.GetService(typeof(ILogger<MinimumDataTime>)) as ILogger<MinimumDataTime>;

            if (value != null && value is DateTime erasureDate)
            {
                if (erasureDate < DateTime.Now)
                {
                    logger.LogWarning("ErasureDate must not be earlier than the current date and time.");
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
            var serviceProvider = validationContext.GetService(typeof(IServiceProvider)) as IServiceProvider;
            var logger = serviceProvider.GetService(typeof(ILogger<AnswerTypesAttribute>)) as ILogger<AnswerTypesAttribute>;

            if (value != null && value.GetType() == typeof(string))
            {
                if (Enum.TryParse<AnswerType>((string)value, true, out _))
                {
                    return ValidationResult.Success;
                }
            }
            logger.LogWarning($"AnswerTypes {value} doesn't exist");
            return new ValidationResult("Type should be a valid AnswerTypes.");
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ValidAnswerTypeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var serviceProvider = validationContext.GetService(typeof(IServiceProvider)) as IServiceProvider;
            var logger = serviceProvider.GetService(typeof(ILogger<AnswerTypesAttribute>)) as ILogger<AnswerTypesAttribute>;

            if (value == null)
                return ValidationResult.Success;

            Type validTypes = typeof(int); // Assuming number means integer

            Type valueType = value.GetType();

            if (validTypes.IsAssignableFrom(valueType) ||
                valueType == typeof(string) ||
                valueType == typeof(DateTime) ||
                valueType == typeof(byte[]) ||
                valueType == typeof(bool))
            {
                return ValidationResult.Success;
            }
            logger.LogWarning("The 'answer' property must have a valid type: number, string, Date, Blob, or boolean.");
            return new ValidationResult("The 'answer' property must have a valid type: number, string, Date, Blob, or boolean.");
        }
    }
}
