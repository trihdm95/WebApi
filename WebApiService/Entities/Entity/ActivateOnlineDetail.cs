using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiService.Entities.Entity
{
    [Table("War_ActivateOnlineDetail")]
    public partial class ActivateOnlineDetail
    {
        [Key]
        public int ActivateOnlineDetailID { get; set; }
        public Nullable<int> ActivateOnlineID { get; set; }
        public Nullable<int> InvoiceDetailID { get; set; }
        public Nullable<bool> ActivatedStatus { get; set; }
        public string ActivatedCode { get; set; }
        public Nullable<System.DateTime> ActivatedDate { get; set; }
        public Nullable<System.DateTime> WarExpiredDate { get; set; }
        public Nullable<int> ActivatedByUserID { get; set; }
        public Nullable<int> ActivatedByCenterID { get; set; }
        public string DeactivateBy { get; set; }
        public Nullable<System.DateTime> DeactivateDate { get; set; }
        public string AttachFile { get; set; }
        public virtual InvoiceDetail InvoiceDetail { get; set; }
        public virtual ActivateOnline ActivateOnline { get; set; }
        public int? SourceType { get; set; }
    }
}
