using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefDish.Models {
    public class CatChef {
        [Key]
        public int CatId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string CatType { get; set; }

        [FutureDate]
        [Required]
        public DateTime Birthday { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int DishId {get;set;}
        public List<Dish> Recipes { get; set; }

    }
}