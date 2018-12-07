using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public Int32 chef_id{get;set;}

        [Required]
        [MinLength(2,ErrorMessage="First name should be greater than 2 characters")]
        [Display(Name="First Name")]
        public string firstname{get;set;}

        [Required]
        [MinLength(2,ErrorMessage="Last name should be greater than 2 characters")]
        [Display(Name="Last Name")]
        public string lastname{get;set;}

        [Required]
        [Display(Name="Date of Birth")]
        // regex
        public string birthdate{get;set;}
        public Int16 age{get;set;}
        public DateTime created_at{get;set;}=DateTime.Now;
        public DateTime updated_at{get;set;}=DateTime.Now;

        public List<Dish> dishes{get;set;}


    }
    public class chefInfoPackage
    {
        public Chef chef{get;set;}=new Chef();
        public List<Chef> allChefs{get;set;}
    }
}