using System.Globalization;

namespace Desafio.Entities;

public class Order
{
    public double Value { get; set; }
    public string Description { get; set; }

    public Order(double value, string description)
    {
        Value = value;
        Description = description;
    }

    public void OrderProcessed()
    {
        Console.WriteLine("Order processed! " + Value.ToString("F2", CultureInfo.InvariantCulture) + " - " + Description);
    }
}