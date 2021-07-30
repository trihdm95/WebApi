using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Enums
{
    public class EnumCommons
    {
        public enum ErrorType
        {
            LogitemService = 1,
            AX2012 = 2,
        };

        public enum ErrorCode
        {
            ErrorSendRequest = 1,
            CannotGetData = 2,
            NoData = 3,
            CannotLogin = 4,
            DuplicateRecord = 5
        };
    }
}
