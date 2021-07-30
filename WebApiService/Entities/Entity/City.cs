using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Entities.Entity
{
    [Table("MD_OtherList")]
    public class City
    {
        [Key]
        public int OtherListID { get; set; }
        public bool IsActive { get; set; }
        public bool IsDisplay { get; set; }
        public string OtherType { get; set; }
    }
}
