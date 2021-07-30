using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Models.Logitems
{
    public class GetLogitemInput
    {
        [CustomDateRequiredAttribute]
        public string From { get; set; }

        [CustomDateRequiredAttribute]
        public string To { get; set; }
        public int Length { get; set; } = 10;
        public int Page { get; set; } = 1;
        public string CreatedAt { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class CustomDateRequiredAttribute : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            var val = value as string;

            if (!string.IsNullOrEmpty(val))
            {
                DateTime date;
                if (DateTime.TryParseExact(val, "dd'/'MM'/'yyyy HH':'mm",
                                           CultureInfo.InvariantCulture,
                                           DateTimeStyles.None,
                                           out date))
                {
                    return true;
                }
                else
                {
                    this.ErrorMessage = "Format invalid date (DD/MM/YYYY HH:mm)";
                    return false;
                }
            }

            return false;
        }
    }
}
