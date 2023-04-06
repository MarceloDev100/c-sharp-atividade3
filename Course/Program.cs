using Course.Entities;
using System.Globalization;

// Testing product class

Console.Write("Product name: ");
string productName = Console.ReadLine();
Console.Write("Product price: ");
double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Product product = new Product(productName, price);

Console.WriteLine();
Console.Write("Product: ");
Console.WriteLine(product.Name + ", $ " + product.Price.ToString("F2", CultureInfo.InvariantCulture));





