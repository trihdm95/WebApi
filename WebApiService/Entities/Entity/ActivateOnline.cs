using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Entities.Entity
{
    [Table("War_ActivateOnline")]
    public partial class ActivateOnline
    {
        public ActivateOnline()
        {
            ActivateOnlineDetail = new List<ActivateOnlineDetail>();
        }

        [Key]
        public int ActivateOnlineID { get; set; }
        public Nullable<byte> CustomerType { get; set; }
        public Nullable<int> CityID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> Agent_StartDate { get; set; }
        public string Agent_InvoiceImageFile { get; set; }
        public string Agent_InvoiceTempNo { get; set; }
        public string Agent_InvoiceSerial { get; set; }
        public string Agent_InvoiceNo { get; set; }
        public string Agent_Remark { get; set; }
        public string ModelNoSerialNo { get; set; }
        public string CreatedUser { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> ActivatedStatus { get; set; }
        public virtual ICollection<ActivateOnlineDetail> ActivateOnlineDetail { get; set; }
    }
}
