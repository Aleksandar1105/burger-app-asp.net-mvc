namespace BurgerApp.ViewModels.BurgerViewModels
{
    public class BurgerListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public string ImgUrl { get; set; }= string.Empty;
    }
}
