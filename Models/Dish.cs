using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public Int32 dish_id{get;set;}

        [Required]
        [MinLength(2,ErrorMessage="Dish Name should be greater than 2 characters")]
        [Display(Name="Name of Dish")]
        public string name{get;set;}

        [Required]
        [Display(Name="Amount of Calories")]
        public Int32 calories{get;set;}

        [Required]
        [Display(Name="Tastiness")]
        [Range(1,5)]
        public Int32 tastiness{get;set;}


        [Required]
        [MinLength(5,ErrorMessage="Dish Description should be greater than 5 characters")]
        [Display(Name="Description")]
        public string description{get;set;}

        [Required]
        [Display(Name="Chef")]
        public Int32 chef_id{get;set;}
        public Chef theChef{get;set;}
    }
}