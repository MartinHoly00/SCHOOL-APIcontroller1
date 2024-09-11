using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIcontroller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test : ControllerBase
    {
        [HttpPost]
        [Route("send")]

        public IActionResult Post(Dato input)
        {
            return Ok(input);
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult Delete(int id)
        {
            if (id == 1)
            {
                return NoContent();
            }
            else return NotFound();
        }

        [HttpPut]
        [Route("put")]

        public IActionResult Put(Dato input)
        {
            input.Name = "Karel";
            return Ok(input);
        }

        [HttpPut]
        [Route("put-change")]

        public IActionResult PutChange(Dato input, string name = "Zoltán") //zoltan je deefault value, lze prepsat
        {
            input.Name = name;
            return Ok(input);
        }

        public class Dato
        {
            public string? Name { get; set; }
        }
    }
}
