using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberController : ControllerBase
    {

        [HttpPost("SumEven")]
        public IActionResult SumEvenNumbers([FromBody] List<int> numbers)
        {

            if (numbers == null || numbers.Count == 0) return BadRequest("Provide list of numbers");

            int sum = numbers.Where(x => x % 2 == 0).Sum();

            return Ok(new { Sum = sum });

        }
    }
}
