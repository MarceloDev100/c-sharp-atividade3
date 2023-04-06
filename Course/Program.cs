using Course.Entities;
using Course.Entities.Enums;
using System.Globalization;

// Testing all

Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Email: ");
string email = Console.ReadLine();

Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

Client client = new Client(name, email, birthDate);

Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

Order order = new Order(status, client);

OrderItem orderItem;

for (int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Enter #{i} data: ");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();

    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Product product = new Product(productName, productPrice);

    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    orderItem = new OrderItem(product, quantity);
    order.AddItem(orderItem);
}

Console.WriteLine();
Console.WriteLine("ORDER SUMMARY: ");
Console.WriteLine(order);




