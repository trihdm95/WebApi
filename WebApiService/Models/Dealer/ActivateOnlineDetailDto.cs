using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Models.Dealer
{
    public partial class ActivateOnlineDetailDto
    {
        public Nullable<int> ActivateOnlineID { get; set; }
        public Nullable<int> InvoiceDetailID { get; set; }
        public Nullable<bool> ActivatedStatus { get; set; }
        public string ActivatedCode { get; set; }
        public Nullable<System.DateTime> ActivatedDate { get; set; }
        public Nullable<System.DateTime> WarExpiredDate { get; set; }
        public Nullable<int> ActivatedByUserID { get; set; }
        public int? SourceType { get; set; }
    }
}
