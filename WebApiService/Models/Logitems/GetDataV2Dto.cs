using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Models.Logitems
{
    public partial class GetDataV2Dto
    {
        public string ProductName { get; set; }
        public string ModelNumber { get; set; }
        public string SerialNumber { get; set; }
        public string ProductType { get; set; }
        public string DealerCode { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? IssuedDate { get; set; }
    }
}
