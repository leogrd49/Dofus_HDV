using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Dofus_HDV.Data;

namespace Dofus_HDV.Controllers 
{
    public class ItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetItems()
        {
            var items = _context.Items.ToList();
            return Ok(items);
        }
    }
}
