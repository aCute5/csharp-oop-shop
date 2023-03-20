// See https://aka.ms/new-console-template for more information
using csharp_oop_shop;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");
var Microphone = new Product(name: "Microfono", description: "è comodo", price: 40);
Console.WriteLine(Microphone.Id);
Console.WriteLine(Microphone.ZeroId());
Console.WriteLine(Microphone.Id);

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