using Business.Enums;
using Business.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces {
    public interface ICountryRepository {
        bool ExistsCountry(Country country);
        Country AddCountry(Country country);
        void RemoveCountry(int id);
        void UpdateCountry(Country country);
        bool HasBeer(Country country, Beer beer);
        Country GetCountry(int id);
        IEnumerable<Country> GetCountries(int id, string name, Shop shop, Beer beer);
    }
}
