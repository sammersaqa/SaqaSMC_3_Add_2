using Microsoft.AspNetCore.Mvc;

namespace SaqaSMC_2_AddNumbers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddNumberApiController : ControllerBase
    {
        [HttpGet("Add/{num1}/{num2}")]
        public string AddTwoNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            return $"The sum of {num1} and {num2} is {sum}.";
        }
    }
}