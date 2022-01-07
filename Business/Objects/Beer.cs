using Business.Enums;
using Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Objects {
    public class Beer {

        public Beer(string name, bool alcoholFree, double alcoholPercentage, Country descent, decimal price) { 
            SetName(name);
            this.AlcoholFree = alcoholFree;
            SetPercentage(alcoholPercentage);
            SetCountry(descent);
            SetPrice(price);
        }

        public Beer(int id, string name, bool alcoholFree, double alcoholPercentage, Country descent, decimal price): this(name, alcoholFree, alcoholPercentage,
            descent, price) {
            SetId(id);
        }

        public Beer() { }

        public int Id { get; set; }

        public string Name { get; set; }
        
        public bool AlcoholFree { get; set; }

        public double AlcoholPercentage { get; set; }

        public Color Color { get; set; }

        public Shop Shop { get; set; }

        public Country Descent { get; set; }

        public decimal Price { get; set; }

       public void SetId(int id) {
            if (id < 1) {
                BeerException ex = new BeerException("Beer: Id must be bigger than zero!");
                ex.Data.Add("id", id);
                throw ex;
            }
            this.Id = id;
        }

        public void SetName(string name) {
            if (name == null || string.IsNullOrWhiteSpace(name) ||
                !char.IsUpper(name[0])) {
                BeerException ex =  new BeerException("Beer: Name is not in correct format");
                ex.Data.Add("name", name);
                throw ex;
            }
            this.Name = name;
        }

        public void SetPercentage(double percentage) {
            if (percentage < 0) {
                BeerException ex = new BeerException("Beer: Percentage is not in correct format!");
                ex.Data.Add("percentage", percentage);
                throw ex;
            }
            this.AlcoholPercentage = percentage;
        }

        public void SetColor(Color color) {
            if(!Enum.IsDefined(typeof(Color), (Color)color)) {
                BeerException ex =  new BeerException("Beer: Color is nog in correct format!");
                ex.Data.Add("color", color);
                throw ex;
            }
            this.Color = color;
        }

        public void SetShop(Shop shop) {
            if (!Enum.IsDefined(typeof(Shop), (Shop)shop)) {
                BeerException ex = new BeerException("Beer: Shop is nog in correct format!");
                ex.Data.Add("shop", shop);
                throw ex;
            }
            this.Shop = shop;
        }

        public void SetCountry(Country newCountry) {
            if (newCountry == null || newCountry == Descent) {
                BeerException ex =  new BeerException("Beer: Descent was not in correct format!");
                ex.Data.Add("newCountry", newCountry);
                throw ex;
            }
            this.Descent = newCountry;
        }

        public void SetPrice(decimal price) {
            if (price == 0) {
                BeerException ex = new BeerException("Beer: Price was not in correct format!");
                ex.Data.Add("price", price);
                throw ex;
            }
            decimal.Round(price);
            this.Price = price;
        }

        public override string ToString() {
            return $"Id: {Id}\nName: {Name}\nAlcoholfree: {AlcoholFree}\nAlcoholpercentage=: {AlcoholPercentage}\n" +
                $"Color: {Color.ToString()}\nShop: {Shop.ToString()}\n" +
                $"Descent: {Descent.ToString()}\nPrice: {Price}";
        }

        public override bool Equals(object obj) {
            return obj is Beer beer &&
                   Id == beer.Id &&
                   Name == beer.Name &&
                   AlcoholFree == beer.AlcoholFree &&
                   AlcoholPercentage == beer.AlcoholPercentage &&
                   Color == beer.Color &&
                   Shop == beer.Shop &&
                   EqualityComparer<Country>.Default.Equals(Descent, beer.Descent) &&
                   Price == beer.Price;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Id, Name, AlcoholFree, AlcoholPercentage, Color, Shop, Descent, Price);
        }
    }
}
