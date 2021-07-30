using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApiService.Entities;
using WebApiService.Enums;
using WebApiService.Services;

namespace WebApiService.Models.Dealer
{
    public class ActiveInput
    {
        [Display(Name = "DealerCode"), Required]
        public string DealerCode { get; set; }

        [Display(Name = "Password"), Required]
        public string Password { get; set; }

        [CustomListRequiredAttribute(ErrorMessage = "The Products field is required.")]
        public List<Product> Products { get; set; }
   
        [CustomCustomerTypeAttribute(ErrorMessage = "The {0} field is required and must be 1 or 2.")]
        public int CustomerType { get; set; }

        [Display(Name = "Address"), Required]
        public string Address { get; set; }

        [Display(Name = "CustomerName"), Required]
        public string CustomerName { get; set; }

        [CustomCityAttribute]
        public int CityID { get; set; }

        [Display(Name = "Phone"), Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[0-9]{10,11}$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }

        [EmailAddressAttribute]
        public string Email { get; set; }          
    }

    public class Product
    {
        [Display(Name = "PosCode"), Required]
        public string PosCode { get; set; }
        [Display(Name = "SerialNr"), Required]
        public string SerialNr { get; set; }
    }

    #region Attribute
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class CustomListRequiredAttribute : RequiredAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            var list = value as List<Product>;
            if (list == null)
            {
                this.ErrorMessage = "The Products field is required.";
                return new ValidationResult(ErrorMessage);
            }
            list = list.GroupBy(x => new { x.PosCode, x.SerialNr })
                                      .Select(x => new Product { PosCode = x.Key.PosCode, SerialNr = x.Key.SerialNr }).ToList();

            if(list.Count > 20)
            {
                this.ErrorMessage = "No more than 20 Products.";
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class CustomCustomerTypeAttribute : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            if ((int)value != (int)CustomerTypeEnum.Incorporation && (int)value != (int)CustomerTypeEnum.Individual)
                return false;

            return true;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class CustomCityAttribute : RequiredAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            if ((int)value == 0)
            {
                this.ErrorMessage = "The CityID field is required.";
                return new ValidationResult(ErrorMessage);
            }

            using (var scope = context.CreateScope())
            {
                var cityService = scope.ServiceProvider.GetService<ICityService>();
                var flag = cityService.CheckCity((int)value);
                if (!flag)
                {
                    this.ErrorMessage = "The CityID is invalid.";
                    return new ValidationResult(ErrorMessage);
                }
            }

            return ValidationResult.Success;
        }
    }
    #endregion
}
