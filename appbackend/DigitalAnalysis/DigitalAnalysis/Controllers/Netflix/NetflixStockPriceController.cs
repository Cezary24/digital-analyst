using DigitalAnalysis.Configures;
using DigitalAnalysis.Models.Netflix;
using DigitalAnalysis.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace DigitalAnalysis.Controllers.Netflix
{
    [Route("api/[controller]")]
    [ApiController]
    public class NetflixStockPriceController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public NetflixStockPriceController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("/get-netflix-stock-price/{page}/{page_size}")]
        public async Task<IActionResult> GetNetflixStockPrice([FromRoute(Name = "page")] int page, [FromRoute(Name = "page_size")] int pageSize)
        {
            var totalCount = await _dbContext.NetflixStockPrices.CountAsync();

            var netflixStockPrices = await _dbContext.NetflixStockPrices
           .OrderBy(p => p.Id)
           .Skip((page - 1) * pageSize)
           .Take(pageSize)
           .ToListAsync();

            var pageResult = new PageResult<NetflixStockPrice>(netflixStockPrices, totalCount, pageSize, page);

            return Ok(pageResult);
        }
    }
}

