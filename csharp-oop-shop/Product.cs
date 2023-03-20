using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    class Product
    {
        public int Id;
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Vat = 22;

        public Product()
        {
            Id = new Random().Next();
        }
        public Product(string name, string description, decimal price, int Vat)
        {
            this.Id = new Random().Next(); 
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Vat = Vat;


        }
        public decimal BasePrice()
        {
            return Price;
        }
        public decimal IvaPrice()
        {
            return Price * (Vat / 100);
        }
        public string AllName()
        {
            return $"{Id} - {Name}";
        }

        public string ZeroId()
        {
            return Id.ToString().PadLeft(8, '0');
        }

    }
}
