using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcCar.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcCar.Controllers
{
    public class CarsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(DataManager.ListCars());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CarsCreateVMcs car)
        {
            if(!ModelState.IsValid)
            return View();

            DataManager.AddCar(car);
            return RedirectToAction(nameof(Index));


        }
    }
}
