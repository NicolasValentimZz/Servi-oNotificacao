using Desafio.Services;

namespace Desafio.Entities;

public class Pix : IPagamento
{
    public bool ProcessPayment(double value)
    {
        Console.WriteLine("Payment pix processed!");
        return true;
    }
}