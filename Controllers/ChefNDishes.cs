using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ChefsNDishes.Models;
namespace ChefsNDishes
{
    public class ChefNDishesController:Controller
    {
        private ChefDishContext dbContext;
        public ChefNDishesController(ChefDishContext context)
        {
            dbContext=context;
        }


        [HttpGet("")]
        [HttpGet("allChefs")]
        public IActionResult allChefs()
        {
            var modelInfo=new chefInfoPackage();
            modelInfo.allChefs=dbContext.Chefs.Include(c=>c.dishes).ToList();
            // modelInfo.chef=new Chef();
            return View("allChefs",modelInfo);
        }

        [HttpGet("allDishes")]
        public IActionResult AllDishes()
        {
            var modelInfo=new dishInfoPackage();
            modelInfo.allDishes=dbContext.Dishes.Include(d=>d.theChef).ToList();
            modelInfo.allChefs=dbContext.Chefs.ToList();
            return View("allDishes",modelInfo);
        }
        





        // ----------Forms Proccesses----------

        [HttpPost("addChef")]
        public IActionResult AddChef(chefInfoPackage InfoPackage)
        {
            var chef=InfoPackage.chef;
            if (ModelState.IsValid)
            {
                DateTime dateValue;
                if (DateTime.TryParse(chef.birthdate,out dateValue))
                {
                    if(dateValue>DateTime.Now)
                    {
                        ModelState.AddModelError("chef.birthdate",errorMessage:"Birth Date is invalid");
                    }
                    else
                    {
                        var days=(DateTime.Now-dateValue).Days;
                        chef.age=Convert.ToInt16(days/365);
                        if (chef.age>18)
                        {
                            dbContext.Chefs.Add(chef);
                            dbContext.SaveChanges();
                            return RedirectToAction("allChefs"); 
                        }
                        ModelState.AddModelError("chef.birthdate",errorMessage:"You are too young. Should be 18 years old or above");
                    }
                   
                }
                else{
                    ModelState.AddModelError("chef.birthdate",errorMessage:"Invalid birth date format");
                }
                
            }
            var modelInfo=new chefInfoPackage();
            modelInfo.allChefs=dbContext.Chefs.Include(c=>c.dishes).ToList();
            return View("allChefs",modelInfo);
        }

        [HttpPost("addDish")]
        public IActionResult AddDish(Dish dish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Dishes.Add(dish);
                dbContext.SaveChanges();
                return RedirectToAction("AllDishes");
            }



            var modelInfo=new dishInfoPackage();
            modelInfo.allDishes=dbContext.Dishes.Include(d=>d.theChef).ToList();
            modelInfo.allChefs=dbContext.Chefs.ToList();
            return View("allDishes",modelInfo);
        }
    }
}