using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebApiService.Enums
{
    public enum CustomerTypeEnum
    {
        [EnumMember(Value = "0")]
        Incorporation = 1, // Tổ chức 

        [EnumMember(Value = "1")]
        Individual = 2 // Cá nhân
    }
}
