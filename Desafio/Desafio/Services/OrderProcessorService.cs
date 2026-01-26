using Desafio.Entities;

namespace Desafio.Services;

public class OrderProcessorService
{
    private IPagamento _pagamento;
    
    public OrderProcessorService(IPagamento pagamento)
    {
        _pagamento = pagamento;
    }

    public bool ProcessOrder(Order order)
    {
        order.OrderProcessed();
        return true;
    }
}