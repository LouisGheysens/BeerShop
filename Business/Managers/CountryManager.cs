using Business.Enums;
using Business.Exceptions;
using Business.Interfaces;
using Business.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers {
    public class CountryManager {

        private ICountryRepository _repo;

        public CountryManager(ICountryRepository repo) {
            this._repo = repo;
        }

        public Country AddCountry(Country country) {
            try {
                return AddCountry(country);
            }catch(Exception ex) {
                throw new CountryManagerException("CountryManager: AddCountry - failed", ex);
            }
        }

        public bool ExistsCountry(Country country) {
            try {
                return ExistsCountry(country);
            }
            catch (Exception ex) {
                throw new CountryManagerException("CountryManager: ExistsCountry - failed", ex);
            }
        }

        public IEnumerable<Country> GetCountries(int id, string name, Shop shop, Beer beer) {
            try {
                return GetCountries(id, name, shop, beer);
            }
            catch (Exception ex) {
                throw new CountryManagerException("CountryManager: GetCountries - failed", ex);
            }
        }

        public Country GetCountry(int id) {
            try {
                return GetCountry(id);
            }
            catch (Exception ex) {
                throw new CountryManagerException("CountryManager: GetCountry(int id) - failed", ex);
            }
        }

        public bool HasBeer(Country country, Beer beer) {
            try {
                return HasBeer(country, beer);
            }
            catch (Exception ex) {
                throw new CountryManagerException("CountryManager: HasBeer - failed", ex);
            }
        }

        public void RemoveCountry(int id) {
            try {
                 RemoveCountry(id);
            }
            catch (Exception ex) {
                throw new CountryManagerException("CountryManager: RemoveCountry - failed", ex);
            }
        }

        public void UpdateCountry(Country country) {
            try {
                UpdateCountry(country);
            }
            catch (Exception ex) {
                throw new CountryManagerException("CountryManager: UpdateCountry - failed", ex);
            }
        }
    }
}
