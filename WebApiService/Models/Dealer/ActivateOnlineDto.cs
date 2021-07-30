using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Models.Dealer
{
    public partial class ActivateOnlineDto
    {
        public Nullable<byte> CustomerType { get; set; }
        public Nullable<int> CityID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }        
        public string CreatedUser { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> ActivatedStatus { get; set; }
    }
}
