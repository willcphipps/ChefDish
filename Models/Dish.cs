using System;
using System.ComponentModel.DataAnnotations;

namespace ChefDish.Models {
    public class Dish {
        [Key]
        public int DishId { get; set; }

        [Required]
        public string DishName { get; set; }

        [Required]
        public int Tastiness { get; set; }

        [Required]
        public int Calories { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int CatId {get;set;}
        public CatChef Creator { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}