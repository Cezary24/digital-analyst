using DigitalAnalysis.Configures;
using DigitalAnalysis.Models.Netflix;
using DigitalAnalysis.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace DigitalAnalysis.Controllers.Netflix
{
    [Route("api/[controller]")]
    [ApiController]
    public class NetflixRevenueController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public NetflixRevenueController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("/get-netflix-revenues/{page}/{page_size}")]
        public async Task<IActionResult> GetNetflixRevenue([FromRoute(Name = "page")] int page, [FromRoute(Name = "page_size")] int pageSize)
        {
            var totalCount = await _dbContext.NetflixRevenues.CountAsync();

            var netflixRevenues = await _dbContext.NetflixRevenues
           .OrderBy(p => p.Id)
           .Skip((page - 1) * pageSize)
           .Take(pageSize)
           .ToListAsync();

            var pageResult = new PageResult<NetflixRevenue>(netflixRevenues, totalCount, pageSize, page);

            return Ok(pageResult);
        }
    }
}
