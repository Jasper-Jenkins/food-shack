using food_shack.Interface;

namespace food_shack.Models
{
    public class Smoothie : IPurchasable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Smoothie(string name, decimal price){
            Name = name;
            Price = price;
        }

      
    }
}