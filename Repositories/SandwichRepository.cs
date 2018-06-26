using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using food_shack.Models;

namespace food_shack.Repositories
{
    public class SandwichRepository
    {

        private readonly IDbConnection _db;

        public SandwichRepository(IDbConnection db)
        {
            _db = db;
        }
        public IEnumerable<Sandwich> GetAll()
        {
            return _db.Query<Sandwich>("SELECT * FROM sandwiches");
        }


        public Sandwich GetById(int id)
        {
            return _db.Query<Sandwich>("SELECT * FROM sandwiches WHERE id=@id", new { id }).FirstOrDefault();
        }

        public Sandwich AddSandwich(Sandwich newSandwich)
        {
            int id = _db.ExecuteScalar<int>(@"
        INSERT INTO sandwiches (name, price, description) 
        VALUES(@Name, @Price, @Description); 
        SELECT LAST_INSERT_ID()", newSandwich);
            newSandwich.Id = id;
            return newSandwich;
        }
    }
    
}