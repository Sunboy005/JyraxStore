using JyraxStore.Data;
using JyraxStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JyraxStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly JyraxDBContext _context;

        public CategoryController(JyraxDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> categories = _context.Categories;
            return View(categories);
        }
    }
}
