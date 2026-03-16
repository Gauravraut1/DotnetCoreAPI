using DotnetCoreApipractice.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreApipractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitAPIController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FruitAPIController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var fruits = _context.Fruits.ToList();
            return Ok(fruits);
        }
    }
}
