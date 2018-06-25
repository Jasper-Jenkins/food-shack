using food_shack.Interface;

namespace food_shack.Models
{
    public class Salad : IPurchasable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Salad(string name, decimal price){
            Name = name;
            Price = price;
        }
    }
}