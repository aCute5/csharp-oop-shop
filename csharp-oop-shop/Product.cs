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
            Id = new Random().Next(100,900);
        }
        public Product(string name, string description, decimal price)
        {
            this.Id = new Random().Next(100, 900);
            this.Name = name;
            this.Description = description;
            this.Price = price;
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

            // Function senza usare il metodo PadLeft
            //public string 0Code()
            //{
            //    var stringCode = Convert.ToString(Code);
            //   
            //    var iterations = 8 - stringCode.Length;

            //    for (int i = 0; i < iterations; i++)
            //    {
            //        stringCode = "0" + stringCode; 
            //    }

            //    return stringCode;
            //}
        }

    }
}
