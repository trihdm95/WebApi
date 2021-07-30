using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Enums
{
    public enum ErrorEnums
    {
        Success = -1,
        ActiveExist = 0,
        ActiveExistSubDealer = 12,
        ProductNotExist = 1,
        SBUNotExist = 2,
        MfgDateExpired = 3,
        DeliveryDateExpired = 4,
        BelongToDealer = 5,
        Blank = 6,
        CustIdNotExist = 7,
        ActivateFail = 8,
        Duplicated = 9,
        ProductNotSupport = 10,
        ExtendActivation = 11,
        NotFoundPosCode = 13,
    }
}
