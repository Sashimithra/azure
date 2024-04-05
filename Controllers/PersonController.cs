using azure.Data;
using Microsoft.AspNetCore.Mvc;

namespace azure.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly InventoryDbContext _InventoryDbContext;
        private readonly IConfiguration _configuration;



        public PersonController(InventoryDbContext InventoryDbContext, IConfiguration configuration)
        {
            _InventoryDbContext = InventoryDbContext;
            _configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> GetallPerson()
        {
            var emp =  _InventoryDbContext.Person.ToList();
            return Ok(emp);
        }
    }
}
