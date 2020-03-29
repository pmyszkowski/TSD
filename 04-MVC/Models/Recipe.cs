using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _04_MVC.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        public int Difficulty { get; set; }
        [Display(Name = "Number of likes")]
        public int NumberOfLikes { get; set; }
        public string Ingredients { get; set; }
        public string Process { get; set; }
        [Display(Name = "Tips and tricks")]
        public string TipsAndTricks { get; set; }
    }
}