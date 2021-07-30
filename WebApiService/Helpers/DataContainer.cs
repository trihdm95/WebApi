using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebApiService.Helpers
{
    public class DataContainer
    {
        public static CookieContainer CookieContainer { get; set; }
        public static string userAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:36.0) Gecko/20100101 Firefox/36.0";
        public static string accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
        public static string urlHost = "https://wms.logitem2.com.vn";
        public static string host = "wms.logitem2.com.vn";
        public static string contentType = "application/x-www-form-urlencoded";
        public static string scheduleMinute = "";
        //User login

        public static Dictionary<int, string> ErrorMessage = new Dictionary<int, string>()
        {
            {1, "[Auto get data E-Warranty - Error 001 - Cannot send request to Logitem] - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")},
            {2, "[Auto get data E-Warranty - Error 002 - Cannot get data from Logitem] - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")},
            {3, "[Auto get data E-Warranty - Error 003 - No data exists from Logitem] - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")},
            {4, "[Auto get data E-Warranty - Error 004 - Cannot login to Logitem] - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")},
            {5, "[Auto get data E-Warranty - Error 005 - Duplicate imported record] - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")},

        };

        //Error for get data from AX
        public static Dictionary<int, string> ErrorAXMessage = new Dictionary<int, string>()
        {
           {1, "[Auto get data E-Warranty - Error 006 - Cannot get data from AX 2012 System] - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")},
           {2, "[Auto get data E-Warranty - Error 007 - Cannot login to AX 2012 System] - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")}
        };
    }
}
