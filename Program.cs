using WlodCar.Data;
using WlodCar.Models;

using WlodCarContext context = new WlodCarContext();

foreach (Customer customer in context.Customers)
{
    Console.WriteLine($"Name: {customer.FirstName} {customer.LastName}");
}