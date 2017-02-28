using OdeToFood.Entities;
using System.Collections.Generic;
using System;
using System.Linq;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        // we only use List temporarily before we create a DB
        // List is not thread safe so should be avoided for webb projects
        // that need to handle multiple users
        List<Restaurant> _restaurants;

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "The House of Kobe" },
                new Restaurant {Id = 2, Name = "LJ's and the Kat" },
                new Restaurant { Id = 3, Name = "King's Contrival" }
              
            };

        }
    }
}
