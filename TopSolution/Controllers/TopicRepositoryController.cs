using Microsoft.AspNetCore.Mvc;
using TopSolution.Data;
using TopSolution.Models;

namespace TopSolution.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopicRepositoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TopicRepositoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Topic> GetTopics()
        {
            return _context.Topics;
        }
    }
}
