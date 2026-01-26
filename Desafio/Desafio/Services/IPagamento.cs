namespace Desafio.Services;

public interface IPagamento
{
    public bool ProcessPayment(double value);
}