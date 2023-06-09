using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TopSolution.Data;
using TopSolution.Models;

namespace TopSolution.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HashtagRepository : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HashtagRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<string> GetHashtags()
        {
            var hashtags = _context.Topics.Select(t => t.HashTags.Split('#', StringSplitOptions.TrimEntries)).ToList().SelectMany(t => t).Distinct();
            return hashtags.Where(t => t != "");
        }
    }
}
