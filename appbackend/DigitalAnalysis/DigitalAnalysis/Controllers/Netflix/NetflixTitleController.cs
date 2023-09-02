using DigitalAnalysis.Configures;
using DigitalAnalysis.Models.Netflix;
using DigitalAnalysis.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DigitalAnalysis.Controllers.netflix
{
    [Route("api/[controller]")]
    [ApiController]
    public class NetflixTitleController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public NetflixTitleController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult CreateNetflixTitle([FromBody] NetflixTitle netflixTitle)
        {
            if (ModelState.IsValid)
            {
                _dbContext.NetflixTitles.Add(netflixTitle);
                _dbContext.SaveChanges();
                return Ok(netflixTitle);
            }

            return BadRequest("Invalid netflix title data.");
        }

        [HttpGet]
        [Route("/get-netflix-titles/{page}/{page_size}")]
        public async Task<IActionResult> GetNetflixTitles([FromRoute(Name = "page")] int page, [FromRoute(Name = "page_size")] int pageSize)
        {
            var totalCount = await _dbContext.NetflixTitles.CountAsync();

            var netflixTitles = await _dbContext.NetflixTitles
           .OrderBy(p => p.Id)
           .Skip((page - 1) * pageSize)
           .Take(pageSize)
           .ToListAsync();

            var pageResult = new PageResult<NetflixTitle>(netflixTitles, totalCount, pageSize, page);

            return Ok(pageResult);
        }
    }
}
