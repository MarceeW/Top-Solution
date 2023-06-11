using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TopSolution.Data;
using TopSolution.Models;

namespace TopSolution.Controllers
{
    public class TopicsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<SiteUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public TopicsController(ILogger<HomeController> logger, UserManager<SiteUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        // GET: Topics
        public async Task<IActionResult> Index([FromQuery(Name = "query")] string query, [FromQuery(Name = "page")] int page)
        {
            const int singlePageElementCount = 15;
            int startPos = page == 1 ? 0 : page * singlePageElementCount;

            IQueryable<Topic>? list;

            if(query  == null)
                list = _context.Topics;
            else
            {
                var q = query.Split(':');
                if (q[0] == "proglang")
                {
                    var n = Enum.GetName(typeof(ProgrammingLanguage), (ProgrammingLanguage)Array.IndexOf(ProgrammingLanguageValues.Values, q[1]));
                    list = _context.Topics.Where(t => t.RelatedProgLanguages.StartsWith(n!));
                }
                else if (q[0] == "hashtag")
                {
                    list = _context.Topics.Where(t => t.HashTags.StartsWith(q[1]));
                }
                else
                {
                    list = _context.Topics.Where(t => t.Title.StartsWith(q[1]));
                }
            }

            ViewData["query"] = query;
            ViewData["page"] = page == 0 ? 1 : page;
            ViewData["topicPerPage"] = singlePageElementCount;
            ViewData["topicCount"] = await list.CountAsync();

            return View(await list.Skip(startPos).Take(singlePageElementCount).ToListAsync());
        }

        // GET: Topics/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Topics == null)
            {
                return NotFound();
            }

            var topic = await _context.Topics
                .FirstOrDefaultAsync(m => m.Id == id);
            if (topic == null)
            {
                return NotFound();
            }

            return View(topic);
        }

        // GET: Topics/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Topics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] Topic topic)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                topic.Owner = user;
                user!.OnPostingTopic();

                _context.Add(topic);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(topic);
        }

        // GET: Topics/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Topics == null)
            {
                return NotFound();
            }

            var topic = await _context.Topics.FindAsync(id);
            if (topic == null)
            {
                return NotFound();
            }
            return View(topic);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Title,Type")] Topic topic)
        {
            if (id != topic.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(topic);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TopicExists(topic.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(topic);
        }

        // GET: Topics/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Topics == null)
            {
                return NotFound();
            }

            var topic = await _context.Topics
                .FirstOrDefaultAsync(m => m.Id == id);
            if (topic == null)
            {
                return NotFound();
            }

            return View(topic);
        }

        // POST: Topics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Topics == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Topics'  is null.");
            }
            var topic = await _context.Topics.FindAsync(id);
            if (topic != null)
            {
                _context.Topics.Remove(topic);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TopicExists(string id)
        {
          return (_context.Topics?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
