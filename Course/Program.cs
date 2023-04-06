// Testing client class

using Course.Entities;

Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Email: ");
string email = Console.ReadLine();

Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

Client client = new Client(name, email, birthDate);

Console.WriteLine();
Console.WriteLine("Client: " + client);



