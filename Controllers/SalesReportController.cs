using azure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace azure.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalesReportController : Controller
    {
        private readonly InventoryDbContext _InventoryDbContext;
        private readonly IConfiguration _configuration;



        public SalesReportController(InventoryDbContext InventoryDbContext, IConfiguration configuration)
        {
            _InventoryDbContext = InventoryDbContext;
            _configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> Getallsoldreport()
        {
            var emp = await _InventoryDbContext.ItemsSoldInfo.ToListAsync();
            return Ok(emp);
        }
    }
}
