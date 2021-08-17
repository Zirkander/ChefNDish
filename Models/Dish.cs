using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ChefNDish.Models
{
    public class Dish
    {
        [Key]
        public int DishID { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Dish Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "is required")]
        [Display(Name = "Tastiness")]
        public int Tastiness { get; set; }

        [Required(ErrorMessage = "is required")]
        [Display(Name = "Calories")]
        public int Calories { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int ChefId { get; set; }
        public Chef DishChef { get; set; }
    }
}