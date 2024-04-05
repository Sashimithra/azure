using azure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace azure.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : Controller
    {
        private readonly InventoryDbContext _InventoryDbContext;
        private readonly IConfiguration _configuration;



        public InventoryController(InventoryDbContext InventoryDbContext, IConfiguration configuration)
        {
            _InventoryDbContext = InventoryDbContext;
            _configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> GetallInventory()
        {
            var emp = await _InventoryDbContext.InventoryItems.ToListAsync();
            return Ok(emp);
        }
    }

}
