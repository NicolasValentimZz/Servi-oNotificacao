using Desafio.Entities;
using Desafio.Services;

internal class Program
{
    public static void Main(string[] args)
    {
        double value = 200.0;
        Console.Write("Please provide a description of the product: ");
        string description = Console.ReadLine();
        
        Order order = new Order(value,  description);
        
        Console.WriteLine("Choose your payment method: ");
        Console.WriteLine("1 - CreditCard: ");
        Console.WriteLine("2 - Pix: ");
        int opc =  int.Parse(Console.ReadLine());
        
        IPagamento pagamentoSelecionado;

        switch (opc)
        {
            case 1:
                pagamentoSelecionado = new CreditCard();
                order.OrderProcessed();
                break;
            case 2:
                pagamentoSelecionado = new Pix();
                order.OrderProcessed();
                break;
        }
    }
}