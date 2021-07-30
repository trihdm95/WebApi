using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Helpers
{
    public class CacheKeys
    {
        public static string Entry => "_Entry";
        public static string Cities => "_Cities";

        public static TimeSpan CacheHour { get { return TimeSpan.FromHours(24); } }
    }
}
