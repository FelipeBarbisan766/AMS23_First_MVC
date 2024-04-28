using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMS23_First_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AMS23_First_MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public CategoryController(ILogger<HomeController> logger)
        {
             _logger = logger;
        }
        public IActionResult Category()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategoryPost(CategoryModel category)
        {
            int Id = category.Id; 
            string? Nome = category.Nome;
            return View();
        }
    }
}