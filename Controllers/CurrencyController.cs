using azure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace azure.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CurrencyController : Controller
    {
        private readonly InventoryDbContext _InventoryDbContext;
        private readonly IConfiguration _configuration;



        public CurrencyController(InventoryDbContext InventoryDbContext, IConfiguration configuration)
        {
            _InventoryDbContext = InventoryDbContext;
            _configuration = configuration;
        }


        [HttpGet]
        public async Task<IActionResult> GetalCurrencyl()
        {
            var emp = await _InventoryDbContext.Currencies.ToListAsync();
            return Ok(emp);
        }
    }
}
