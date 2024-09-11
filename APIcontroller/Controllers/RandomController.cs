using APIcontroller.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace APIcontroller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        private IValueService _valueService;
        public RandomController(IValueService valueService)
        {
            _valueService = valueService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_valueService.Value);
        }

       [HttpPost]
        public IActionResult Post(int input)
        {
            _valueService.SetValue(input);
            return Ok(_valueService.Value);
        }
    }
}
