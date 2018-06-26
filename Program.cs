using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using food_shack.Models;
using food_shack.Interface;
namespace food_shack
{
    public class Program
    {
        // public static List<Smoothie> Smoothies = new List<Smoothie>(){
        //     new Smoothie("Mango", 3.99m),

        // };
        // public static List<Salad> Salads = new List<Salad>(){
        //     new Salad("Italian", 2.99m),

        // };
        // public static List<Sandwich> Sandwiches = new List<Sandwich>(){
        //     new Sandwich("BLT", 4.99m),

        // };
        // public static List<IPurchasable> MenuItems = new List<IPurchasable>();

        // public static void Menu(){
          
        //     for(var i = 0; i < Smoothies.Count; i++){
        //         MenuItems.Add(Smoothies[i]);
        //     }
        //     for(var i = 0; i < Salads.Count; i++){
        //         MenuItems.Add(Salads[i]);
        //     }
        //     for(var i = 0; i < Sandwiches.Count; i++){
        //         MenuItems.Add(Sandwiches[i]);
        //     }
        //     //MenuItems.Add(Smoothies)
        //    // return MenuItems;
        // }

        public static void Main(string[] args)
        {
            // Menu();
                   
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
