using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prueba_SOLID;




public abstract class PaymentProcessor
{
    public abstract void ProcessPayment(double amount);
}
public class StandardPayment : PaymentProcessor
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Procesando standard payment: ${amount}");
    }
}

public abstract class SpecialPayment : PaymentProcessor
{
    public override void ProcessPayment(double amount)
    {
        if(amount != 50)
            throw new InvalidOperationException("Special payments solo pueden ser de $50.");
        Console.WriteLine($"Procesando special payment: ${amount}");
    }
}

public class CreditCardProcessor : StandardPayment
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Procesando pago con tarjeta de crédito de ${amount}");
    }
}

public class CashProcessor : StandardPayment
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Procesando pago en efectivo de ${amount}");
    }
}

public class GiftCardProcessor : SpecialPayment
{
    public override void ProcessPayment(double amount)
    {
        if (amount != 50)
            throw new InvalidOperationException("Las gift cards solo pueden usarse para montos exactos de $50.");

        Console.WriteLine("Pago con gift card de $50 completado.");
    }
}