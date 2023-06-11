using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TopSolution.Data;
using TopSolution.Models;

namespace TopSolution.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProgLangRepositoryController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> GetHashtags()
        {
            return ProgrammingLanguageValues.Values;
        }
    }
}
