using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebApiService.Models.Dealer;
using WebApiService.Services;

namespace WebApiService.Controllers
{
    [ApiController]
    [Route("[controller]/api")]
    [Authorize]
    public class DealerController : ControllerBase
    {
        private readonly ILogger<LogitemController> _logger;
        private readonly IDealerService _dealer;

        public DealerController(ILogger<LogitemController> logger, IDealerService dealer)
        {
            _logger = logger;
            _dealer = dealer;
        }

        [HttpPost]
        [Route("VerifyDealer")]
        public async Task<IActionResult> VerifyDealer(VerifyDealerInput input)
        {
            try
            {
                var rs = await _dealer.VerifyDealer(input);
                if (rs.StatusCode != StatusCodes.Status200OK)
                    return StatusCode(rs.StatusCode, new { errors = rs.Message });

                return Ok(new { Password = rs.Message });
            }
            catch(Exception ex)
            {
                _logger.LogError($"Controler VerifyDealer {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, new { errors = "Lỗi hệ thống!" });
            }        
        }

        [HttpPost]
        [Route("ActivateWarrantyForDealer")]
        public async Task<IActionResult> ActivateWarrantyForDealer(ActiveInput input)
        {
            input.Products = input.Products.GroupBy(x => new { x.PosCode, x.SerialNr })
                                      .Select(x => new Product { PosCode = x.Key.PosCode, SerialNr = x.Key.SerialNr }).ToList();
            try
            {
                var rs = await _dealer.Active(input);
                if (rs.StatusCode == StatusCodes.Status401Unauthorized)
                    return StatusCode(rs.StatusCode, new { Message = "Unauthorized!" });
                else if(rs.StatusCode == StatusCodes.Status500InternalServerError)
                    return StatusCode(rs.StatusCode, new { Message = "Not found bonus!" });
                else if(rs.StatusCode != StatusCodes.Status200OK)
                    return StatusCode(rs.StatusCode, new { errors = rs.Errors });

                return Ok(new { Message = "Success!"});
            }
            catch(Exception ex)
            {
                _logger.LogError($"Controler VerifyDealer {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, new { errors = "Lỗi hệ thống!" });
            }
        }
    }
}
