using Desafio.Services;

namespace Desafio.Entities;

public class CreditCard : IPagamento
{
    public bool ProcessPayment(double value)
    {
        Console.WriteLine("Credit card payment processed!");
        return true;
    }
}