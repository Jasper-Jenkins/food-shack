using food_shack.Interface;

namespace food_shack.Models
{
    public class MenuItems : IPurchasable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public MenuItems(string name, decimal price){
            Name = name;
            Price = price;
        }
    }
}