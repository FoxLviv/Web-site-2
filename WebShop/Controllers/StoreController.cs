using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class StoreController : Controller
    {
        WebShopEntities shopDB = new WebShopEntities();

        public ActionResult Index()
        {
            var categories = shopDB.Categories.ToList();
            return View(categories);
            //return "Hello from index";
        }

        public ActionResult Browse(string category)
        {
            var categoryModel = shopDB.Categories.Include("Items")
                .Single(c=>c.Name==category);
            return View(categoryModel);
        }

        public ActionResult Details(int id)
        {
            var item = shopDB.Items.Find(id);
            return View(item);
        }
    }
}