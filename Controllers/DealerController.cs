using Cardekho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cardekho.Controllers
{
    public class DealerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // GET: Dealer/companies
        public IActionResult Companies(String Name)
        {
            if (Name == null)
            {
                return RedirectToAction("Index");
            }


            // use fake model for the inventory to show the list of cars
            var Inventory = new List<Inventory>();

            for (var i = 1; i < 15; i++)
            {
                Inventory.Add(new Inventory { InventoryId = i, Name = "Inventory" + i.ToString(), Make = "Inventory" + i.ToString(), price = 10 + i });
            }
            ViewData["Name"] = Name;
            return View(Inventory);
        }
    }
}

