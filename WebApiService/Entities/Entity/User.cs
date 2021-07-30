using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Entities.Entity
{
    [Table("AM_User")]
    public partial class User
    {
        public int UserID { get; set; }
        public string CustID { get; set; }
        public byte? UserType { get; set; }
        public bool IsActive { get; set; }
        public string ServicePassword { get; set; }
        public string UserName { get; set; }
    }
}
