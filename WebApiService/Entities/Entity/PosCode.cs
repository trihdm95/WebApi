using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiService.Entities.Entity
{
    [Table("War_PosCode")]
    public partial class PosCode
    {
        [Key]
        public string Code { get; set; }
        public string Model { get; set; }
    }
}
