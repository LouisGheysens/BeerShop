using Business.Enums;
using Business.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces {
    public interface IBeerRepository {
        bool ExistsBeer(Beer beer);
        Beer AddBeer(Beer beer, Country country);
        Beer GetBeer(int id);
        void UpdateBeer(Beer beer);
        IEnumerable<Beer> ShowBeers(int id, string name, bool alcoholFree, double alcoholPercentage
            , Color color, Shop shop, decimal price);
        Dictionary<Beer, Country> ShowBeersWithCountry(Beer beer, Country country);
        void RemoveBeer(int id);
        bool HasCountry(Beer beer, Country country);
    }
}
