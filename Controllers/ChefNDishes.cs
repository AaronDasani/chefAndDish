using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ChefsNDishes.Models;
namespace ChefsNDishes
{
    public class DishNDishesController:Controller
    {
        private ChefDishContext dbContext;
        public DishNDishesController(ChefDishContext context)
        {
            dbContext=context;
        }


        [HttpGet("")]
        [HttpGet("allChefs")]
        public IActionResult allChefs()
        {
            var chefs=dbContext.Chefs.Include(c=>c.dishes).ToList();
            return View("allChefs",chefs);
        }

        





        // ----------Forms Proccesses----------

        [HttpPost("addDish")]
        public IActionResult AddDish()
        {

            return View("allChefs");
        }
    }
}