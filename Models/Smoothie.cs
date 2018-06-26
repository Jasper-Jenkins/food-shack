using System.ComponentModel.DataAnnotations;
using food_shack.Interface;

namespace food_shack.Models
{
    public class Smoothie : IPurchasable
    {

        public int Id {get; set;}
        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Name { get; set; }
        
        [Required]
        [Range(1, 100)]
        public decimal Price { get; set; }

        public string Description {get;set;}
        // public Smoothie(string name, decimal price){
        //     Name = name;
        //     Price = price;
        // }

      
    }
}