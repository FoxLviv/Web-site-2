using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class StoreController : Controller
    {
        public ActionResult Index()
        {
            var category = new List<Category>
            {
                new Category {Name = "Electronics"},
                new Category {Name = "Furniture"},
                new Category {Name = "Accessories"}
            };
            return View(category);
            //return "Hello from index";
        }

        public ActionResult Browse(string category)
        {
            var categoryModel = new Category { Name = category };
            return View(categoryModel);
        }

        public IActionResult Details(int id)
        {
            var item = new Item { Title = "Item" + id };
            return View(item);
        }
    }
}