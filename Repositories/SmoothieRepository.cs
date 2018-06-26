using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using food_shack.Models;

namespace food_shack.Repositories
{
    public class SmoothieRepository
    {

        private readonly IDbConnection _db;

        public SmoothieRepository(IDbConnection db)
        {
            _db = db;
        }
        public IEnumerable<Smoothie> GetAll()
        {
            return _db.Query<Smoothie>("SELECT * FROM smoothies");
        }


        public Smoothie GetById(int id)
        {
            return _db.Query<Smoothie>("SELECT * FROM smoothies WHERE id=@id", new { id }).FirstOrDefault();
        }

        public Smoothie AddSmoothie(Smoothie newSmoothie)
        {
            int id = _db.ExecuteScalar<int>(@"
        INSERT INTO smoothies (name, price, description) 
        VALUES(@Name, @Price, @Description); 
        SELECT LAST_INSERT_ID()", newSmoothie);
            newSmoothie.Id = id;
            return newSmoothie;
        }
    }
    
}