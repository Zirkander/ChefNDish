using System;
using System.ComponentModel.DataAnnotations;

namespace ChefNDish.Models
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Chef Name")]
        public string ChefName { get; set; }
        [Required(ErrorMessage = "is required")]
        [Display(Name = "Chef Age")]
        public int ChefAge { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}