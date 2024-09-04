using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace APIcontroller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public int Get()
        {
            return Random.Shared.Next(0, 100);
        }
        [HttpGet("max")]
        public int GetMax()
        {
            return Random.Shared.Next(10, 30);
        }

        [HttpGet("name")]
        public Date GetName()
        {
            Date x = new Date { FirstName = "Alice" };
            return x;
        }
        [HttpGet("err")]
        public IActionResult GetErr()
        {
            Date x = new Date { FirstName = "Alice" };
            return StatusCode(413, "whats happening");
        }
        public class Date
        {
            public string FirstName { get; set; }
        }
    }
}