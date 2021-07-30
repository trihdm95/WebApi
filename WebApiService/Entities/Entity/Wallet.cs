using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Entities.Entity
{
    [Table("War_Wallet")]
    public partial class Wallet
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string UserCode { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public Nullable<decimal> TotalBonusPoint { get; set; }
        public Nullable<decimal> TotalUsedPoint { get; set; }
        public Nullable<decimal> AvailablePoint { get; set; }
        public Nullable<decimal> TotalBonus { get; set; }
        public virtual User AM_User { get; set; }
    }
}
