using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiService.Entities.Entity
{
    [Table("War_BonusConfig")]
    public class BonusConfig
    {
        public int Id { get; set; }
        public byte UserType { get; set; }
        public string CurrencyType { get; set; }
        public decimal BonusValue { get; set; }
        public bool Active { get; set; }
        public string UpdatedUser { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
