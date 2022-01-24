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

        //GET -Create
        public IActionResult CreateCategory()
        {

            return View();
        }
        //POST -Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateCategory(Category obj)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET -Edit
        public IActionResult EditCategory()
        {

            return View();
        }
        //POST -
        [HttpPatch]
        [ValidateAntiForgeryToken]
        public IActionResult EditCategory(Category obj)
        {
            _context.Categories.Update(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
