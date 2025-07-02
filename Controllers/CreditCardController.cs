using Microsoft.AspNetCore.Mvc;
using CweBankApi.Models;

namespace CweBankApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CreditCardController : ControllerBase
    {
        [HttpPost("inquiry")]
        [ProducesResponseType(typeof(CreditCardResponse), 200)]
        public ActionResult<CreditCardResponse> SubmitInquiry([FromBody] CreditCardRequest request)
        {
            Console.WriteLine($"Received credit card inquiry for: {request.CreditCardNumber}");
            if (!ModelState.IsValid)
            {
                return BadRequest(new CreditCardResponse { Message = "Invalid credit card format." });
            }

            return Ok(new CreditCardResponse
            {
                Message = $"Inquiry received for card ending in {request.CreditCardNumber[^4..]}"
            });
        }

        [HttpGet("ping")]
        [ProducesResponseType(typeof(CreditCardResponse), 200)]
        public ActionResult<CreditCardResponse> Ping()
        {
            return Ok(new CreditCardResponse { Message = "CWE Bank API is active." });
        }
    }
}