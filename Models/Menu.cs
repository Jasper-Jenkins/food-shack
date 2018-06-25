using System;
using System.Collections.Generic;
using food_shack.Models;
using food_shack.Interface;
namespace food_shack.Models
{
    public class Menu
    {
        public string Title { get; set; }
        public List<Sandwich> Sandwiches {set; get;}
        public List<Smoothie> Smoothies {set; get;}
        public List<Salad> Salads {set; get;}
        
    //    public List<MenuItems> MenuItems {get;set;}
        public Menu(string title){
            Title = title;
            Sandwiches = new List<Sandwich>();
            Smoothies = new List<Smoothie>();
            Salads = new List<Salad>();
          //  MenuItems = new List<MenuItems>();


            // Sandwich italian = new Sandwich("Italian", 3.99m);
            // Smoothie mango = new Smoothie("Mango", 2.99m);
            // Salad cesear = new Salad("Cesear", 2.99m);


        }


        // public static List<Smoothie> Smoothiess = new List<Smoothie>(){
        //     new Smoothie("Mango", 4.99m),

        // };
        //  public static List<Salad> Saladss = new List<Salad>(){
        //     new Salad("Italian", 4.99m),

        // };
        // public static List<IPurchasable> MenuItems = new List<IPurchasable>();

        // public void MyMenu(){
          
        //     for(var i = 0; i < Smoothiess.Count; i++){
        //         MenuItems.Add(Smoothies[i]);
        //     }
        //     for(var i = 0; i < Saladss.Count; i++){
        //         MenuItems.Add(Salads[i]);
        //     }
        //     //MenuItems.Add(Smoothies)
        //    // return MenuItems;
        // }
        
        // public static List<Smoothie> SmoothiesAva = new List<Smoothie>(){
        //     new Smoothie("Mango", 4.99m),

        // };
        // public List<setup(){
        
        //     Menu FoodShack = new Menu("Food Shack");
        

        //     Sandwich italian = new Sandwich("Italian", 3.99m);
        //     Smoothie mango = new Smoothie("Mango", 2.99m);
        //     Salad cesear = new Salad("Cesear", 2.99m);

        //     FoodShack.Smoothies.Add(mango);
        // }
    }
}