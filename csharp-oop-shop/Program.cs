// See https://aka.ms/new-console-template for more information
using csharp_oop_shop;

Console.WriteLine("Hello, World!");
var product = new Product(name: "Microfono", description: "è comodo", price: 40, Vat:22);
Console.WriteLine(product.Id);
Console.WriteLine(product.Name);
Console.WriteLine(product.AllName());