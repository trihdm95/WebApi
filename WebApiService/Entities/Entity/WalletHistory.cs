using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Entities.Entity
{
    [Table("War_WalletHistory")]
    public partial class WalletHistory
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public Nullable<byte> UserType { get; set; }
        public string UserCode { get; set; }
        public System.DateTime Date { get; set; }
        public string ModelNo { get; set; }
        public string SerialNo { get; set; }
        public string InvoiceNo { get; set; }
        public int InvoiceDetailID { get; set; }
        public string CardType { get; set; }
        public string CategoryType { get; set; }
        public bool ActivateStatus { get; set; }
        public Nullable<decimal> PointValue { get; set; }
        public Nullable<decimal> BonusValue { get; set; }
        public virtual User User { get; set; }
    }
}
