using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Models.Dealer
{
    public partial class WalletHistoryDto
    {
        public int UserID { get; set; }
        public Nullable<byte> UserType { get; set; }
        public string UserCode { get; set; }
        public System.DateTime Date { get; set; }
        public string ModelNo { get; set; }
        public string SerialNo { get; set; }
        public string InvoiceNo { get; set; }
        public int InvoiceDetailID { get; set; }
        public bool ActivateStatus { get; set; }
        public Nullable<decimal> BonusValue { get; set; }
    }
}
