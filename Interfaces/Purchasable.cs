using System.Collections.Generic;

namespace food_shack.Interface
{
    public interface IPurchasable
    {
        string Name {get; set;}
    
        decimal Price {get; set;}
        //string Description {get; set;}

    }
}