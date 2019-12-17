using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Utils
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public sealed class TenYearsOldAttribute : ValidationAttribute, IClientModelValidator
    {
        public override bool IsValid(object value)
        {
            var message = value as string;
            return DateTime.Now.AddYears(-10).CompareTo(value) >= 0;
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            if (!context.Attributes.ContainsKey("data-val")) context.Attributes.Add("data-val", "true");
            var errorMessage = FormatErrorMessage(context.ModelMetadata.GetDisplayName());
            if (!context.Attributes.ContainsKey("data-val-range-max")) context.Attributes.Add("data-val-range-max", DateTime.Now.AddYears(-10).ToString("yyyy-MM-dd"));
            if (!context.Attributes.ContainsKey("data-val-range-min")) context.Attributes.Add("data-val-range-min", DateTime.MinValue.ToString("yyyy-MM-dd"));
            if (!context.Attributes.ContainsKey("data-val-range")) context.Attributes.Add("data-val-range", errorMessage);
        }
    }
}
