// See https://aka.ms/new-console-template for more information
using Exercicio_Proposto_Enum_e_Composição.Entities;
using Exercicio_Proposto_Enum_e_Composição.Entities.Enums;

Console.WriteLine("Enter cliente data: ");

Console.Write("Name: "); 
string name = Console.ReadLine();
Console.Write("Email: "); 
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYY): ");
DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Client client = new Client(name, email, birthDate);
Order order = new Order(DateTime.Now, status, client);

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());




for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} data: ");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine());
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    

     
    Product product = new Product(productName, price);
    OrderItem item = new OrderItem(quantity, price, product);
    order.AddItem(item);
}

Console.WriteLine();
Console.WriteLine("ORDER SUMMARY: ");
Console.WriteLine(order.ToString());
