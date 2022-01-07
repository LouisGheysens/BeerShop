using Business.Enums;
using Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Objects {
    public class Country {
        public Country(string name, bool certified, Shop shop, Beer beer) {
            SetName(name);
            this.EUcertified = certified;
            SetShop(shop);
            SetBeer(beer);
        }
        public Country(int id, string name, bool certified, Shop shop, Beer beer) : this(name, certified, shop, beer) {
            SetId(id);
        }

        public Country() { }

        public int Id { get; set; }

        public string Name { get; set; }

        public bool EUcertified { get; set; }

        public Shop Shop { get; set; }

        public Beer Beer { get; set; }

        private void SetId(int id) {
            if(id < 1) {
                CountryException ex = new CountryException("Country: Id is not in correct format!");
                ex.Data.Add("id", id);
                throw ex;
            }
            this.Id = id;
        }


        private void SetName(string name) {
            if(name == null || string.IsNullOrWhiteSpace(name)) {
                CountryException ex = new CountryException("Country: Name is not in correct format!");
                ex.Data.Add("name", name);
                throw ex;
            }
            this.Name = name;
        }

        private void SetShop(Shop shop) {
            if(!Enum.IsDefined(typeof(Shop), (Shop)shop)){
                CountryException ex = new CountryException("Country: Shop was not in correct format!");
                ex.Data.Add("shop", shop);
                throw ex;
            }
            this.Shop = shop;
        }

        private void SetBeer(Beer beer) {
            if(beer == null) {
                CountryException ex = new CountryException("Country: Beer was not in correct format!");
                ex.Data.Add("beer", beer);
                throw ex;
            }
            this.Beer = beer;
        }

        public override string ToString() {
            return $"Id: {Id}\nName: {Name}\nCertified: {EUcertified}\nShop: {Shop.ToString()}\nBeer: {Beer.ToString()}";
        }

        public override bool Equals(object obj) {
            return obj is Country country &&
                   Id == country.Id &&
                   Name == country.Name &&
                   EUcertified == country.EUcertified &&
                   Shop == country.Shop &&
                   EqualityComparer<Beer>.Default.Equals(Beer, country.Beer);
        }

        public override int GetHashCode() {
            return HashCode.Combine(Id, Name, EUcertified, Shop, Beer);
        }
    }
}
