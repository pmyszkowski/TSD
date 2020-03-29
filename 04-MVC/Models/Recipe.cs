using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _04_MVC.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(10, 50)]
        public int Time { get; set; }
        [Range(0,10)]
        public int Difficulty { get; set; }
        [Display(Name = "Number of likes")]
        [Range(0, Int16.MaxValue)]
        public int NumberOfLikes { get; set; }
        public string Ingredients { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Process { get; set; }
        [Display(Name = "Tips and tricks")]
        public string TipsAndTricks { get; set; }
    }
}