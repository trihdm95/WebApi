using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiService.Entities.Entity
{
    [Table("War_ExtendActivation")]
    public class ExtendActivation
    {
        public int Id { get; set; }
        public int InvoiceDetailId { get; set; }
        public int ActiveOnlineDetail { get; set; }
        public int ActiveOnlineDetailSub { get; set; }
        public string ModelNo { get; set; }
        public string SerialNo { get; set; }
        public string OderId { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int ExtendDays { get; set; }
        public DateTime ExpiredDateExtend { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
