using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Models.Dealer
{
    public class WalletDto
    {
        public int UserID { get; set; }
        public string UserCode { get; set; }
        public Nullable<decimal> TotalBonus { get; set; }
    }
}
