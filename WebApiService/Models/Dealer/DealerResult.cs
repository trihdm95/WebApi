using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Models.Dealer
{
    public partial class DealerResult
    {
        public int StatusCode { get; set; }
        public List<Error> Errors { get; set; }
    }
    public class Error
    {
        public string PosCode { get; set; }
        public string SerialNr { get; set; }
        public int ErrorCode { get; set; }
    }
}
