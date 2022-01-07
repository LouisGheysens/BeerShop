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
    public class BeerManager {
        private IBeerRepository _repo;

        public BeerManager(IBeerRepository repo) {
            this._repo = repo;
        }

        public Beer AddBeer(Beer beer, Country country) {
            try {
                return _repo.AddBeer(beer, country);
            }catch(Exception ex) {
                throw new BeerManagerException("BeerManager: AddBeer - failed",ex);
            }
        }

        public bool ExistsBeer(Beer beer) {
            try {
                return _repo.ExistsBeer(beer);
            }
            catch (Exception ex) {
                throw new BeerManagerException("BeerManager: ExistsBeer - failed", ex);
            }
        }

        public Beer GetBeer(int id) {
            try {
                return _repo.GetBeer(id);
            }
            catch (Exception ex) {
                throw new BeerManagerException("BeerManager: GetBeer(int id) - failed", ex);
            }
        }

        public bool HasCountry(Beer beer, Country country) {
            try {
                return _repo.HasCountry(beer, country);
            }
            catch (Exception ex) {
                throw new BeerManagerException("BeerManager: HasCountry - failed", ex);
            }
        }

        public void RemoveBeer(int id) {
            try {
                _repo.RemoveBeer(id);
            }
            catch (Exception ex) {
                throw new BeerManagerException("BeerManager: RemoveBeer(int id) - failed", ex);
            }
        }

        public IEnumerable<Beer> ShowBeers(int id, string name, bool alcoholFree, double alcoholPercentage, 
            Color color, Shop shop, decimal price) {
            try {
                return _repo.ShowBeers(id, name, alcoholFree, alcoholPercentage, color, shop, price);
            }
            catch (Exception ex) {
                throw new BeerManagerException("BeerManager: ShowBeers - failed", ex);
            }
        }

        public Dictionary<Beer, Country> ShowBeersWithCountry(Beer beer, Country country) {
            try {
                return _repo.ShowBeersWithCountry(beer, country);
            }
            catch (Exception ex) {
                throw new BeerManagerException("BeerManager: ShowBeersWithCountry - failed", ex);
            }
        }

        public void UpdateBeer(Beer beer) {
            try {
                _repo.UpdateBeer(beer);
            }
            catch (Exception ex) {
                throw new BeerManagerException("BeerManager: UpdateBeer - failed", ex);
            }
        }
    }
}
