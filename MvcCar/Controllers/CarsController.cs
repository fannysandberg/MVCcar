﻿using System;
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
        MvcCarContext context;

        public CarsController(MvcCarContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.ListCars());
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

            context.AddCar(car);
            return RedirectToAction(nameof(Index));


        }
    }
}
