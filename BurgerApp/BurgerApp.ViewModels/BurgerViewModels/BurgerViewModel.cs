using System.ComponentModel.DataAnnotations;

namespace BurgerApp.ViewModels.BurgerViewModels
{
    public class BurgerViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Burger Name")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Burger Price")]
        public double Price { get; set; }
        [Display(Name =("Vege Burger"))]
        public bool IsVegetarian { get; set; }
        [Display(Name=("Vegan Burger"))]
        public bool IsVegan { get; set; }
        [Display(Name=("With Fries"))]
        public bool HasFries { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }
}
