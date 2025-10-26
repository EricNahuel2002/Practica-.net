using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_SOLID;


public interface ICalculator
{
    double CalculateDiscount(double amount);
}

public class RegularCustomerCalculator : ICalculator
{
    public double CalculateDiscount(double amount)
    {
        return amount * 0.05;
    }
}

public class PremiumCustomerCalculator : ICalculator
{
    public double CalculateDiscount(double amount)
    {
        return amount * 0.10;
    }
}

public class VIPCustomerCalculator : ICalculator
{
    double taxes = 0.02;
    public double CalculateDiscount(double amount)
    {
        return amount * 0.20 * taxes;
    }
}

public class ForeignCustomerCalculator : ICalculator
{
    public double CalculateDiscount(double amount)
    {
        return amount * 0.15;
    }
}



public class DiscountCalculator
{

    private ICalculator _calculator;

    public DiscountCalculator(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public double Calculate(double amount)
    {
        return _calculator.CalculateDiscount(amount);
    }
}
