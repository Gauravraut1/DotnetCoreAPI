using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreApipractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitAPIController : ControllerBase
    {
        public List<string> fruits = new List<string>()
        {
            "Apple",
            "Banana",
            "Cherry",
            "Date",
            "Elderberry",
            "Mango",
            "strawberry"
        };

        [HttpGet]
        public List<string> Get()
        {
            Console.WriteLine("Get method called");
            return fruits;
        }
    }
}
