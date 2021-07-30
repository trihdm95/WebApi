using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebApiService.Models.Logitems;
using WebApiService.Services;

namespace WebApiService.Controllers
{
    [ApiController]
    [Route("[controller]/api")]
    [Authorize]
    public class LogitemController : ControllerBase
    {
        private readonly ILogger<LogitemController> _logger;
        private readonly ILogitemService _logitem;

        public LogitemController(ILogger<LogitemController> logger, ILogitemService logitem)
        {
            _logger = logger;
            _logitem = logitem;
        }

        [HttpPost]
        [Route("GetData")]
        public async Task<GetLogitemV2Dto> Post(GetLogitemInput input)
        {
            try
            {
                return await _logitem.GetDataV2(input);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new GetLogitemV2Dto
                {
                    StatusDescription = ex.Message,
                    StatusCode = HttpStatusCode.BadRequest
                };
            }
        }
    }
}
