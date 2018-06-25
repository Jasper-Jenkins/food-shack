using food_shack.Interface;

namespace food_shack.Models
{
    public class Sandwich : IPurchasable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Sandwich(string name, decimal price){
            Name = name;
            Price = price;
        }
    }
}