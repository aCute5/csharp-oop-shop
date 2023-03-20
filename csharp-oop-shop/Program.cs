// See https://aka.ms/new-console-template for more information
using csharp_oop_shop;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;


var Microphone = new Product(name: "Microfono", description: "è comodo", price: 40);
var Sgabelloo = new Product(name: "Sgabello", description: "è comodo", price: 20);
var Telefono = new Product(name: "Telefono", description: "è potente", price: 120);

Console.WriteLine("Hello, World!");
Console.WriteLine(Microphone.Id);
Console.WriteLine(Microphone.ZeroId());
Console.WriteLine(Microphone.Id);

Product[] arrProducts = new Product[10];


arrProducts[0] = Microphone;
arrProducts[1] = Telefono;
arrProducts[2] = Sgabelloo;



printProduct(Microphone);
void printProduct(Product product)
{
    Console.WriteLine("Name:" + product.Name);
    Console.WriteLine("Description:" + product.Description);
    Console.WriteLine("Price:" +  "" + "$" +  product.Price);
    Console.WriteLine("VATPRICE:" + product.IvaPrice());
    Console.WriteLine("Id:" + product.Id);
    Console.WriteLine(product.AllName());
}