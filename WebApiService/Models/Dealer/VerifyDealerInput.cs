using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Models.Dealer
{
    public class VerifyDealerInput
    {
        [Display(Name = "DealerCode"), Required]
        public string DealerCode { get; set; }
    }
}
