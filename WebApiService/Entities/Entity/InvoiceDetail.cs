using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Entities.Entity
{
    [Table("War_InvoiceDetail")]
    public partial class InvoiceDetail
    {
        public InvoiceDetail()
        {
            ActivateOnlineDetail = new List<ActivateOnlineDetail>();
        }

        [Key]
        public int InvoiceDetailID { get; set; }
        public string InvoiceNo { get; set; }
        public string ModelNo { get; set; }
        public string SerialNo { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string CreatedUser { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public string DeliveriedNote { get; set; }
        public string Category { get; set; }
        public Nullable<System.DateTime> MfgDate { get; set; }
        public Nullable<System.DateTime> EstExpireDate { get; set; }
        public string CustID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string DepartmentCode { get; set; }
        public string DealerName { get; set; }
        public virtual ICollection<ActivateOnlineDetail> ActivateOnlineDetail { get; set; }
    }
}
