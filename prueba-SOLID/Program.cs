using prueba_SOLID;

//SINGLE RESPONSABILITY SOLUCION

//ISender sender = new EmailSender();
//ReportGenerator report = new ReportGenerator(sender);

//report.GenerateReport("Datos importantes del reporte.");


//OPEN CLOSED PRINCIPLE SOLUCION
//ICalculator regularCalculator = new ForeignCustomerCalculator();

//DiscountCalculator discountCalculator = new DiscountCalculator(regularCalculator);

//double amountCalculated = discountCalculator.Calculate(1000);

//Console.WriteLine($"Descuento calculado: {amountCalculated}");


//LISKOV SUBSTITUTION PRINCIPLE SOLUCION

//Los subtipos deben ser substituibles
//por sus tipos base.

//Si tu código está diseñado para funcionar con un objeto
//de un tipo base (por ejemplo, ClaseBase), también debería
//funcionar perfectamente cuando le pasas un objeto de un subtipo
//o clase derivada (por ejemplo, ClaseDerivada), sin que el programa
//se rompa o arroje resultados inesperados.
var standardPayments = new List<StandardPayment>
{
    new CreditCardProcessor(),
    new CashProcessor()
};

foreach (var p in standardPayments)
{
    p.ProcessPayment(100); // ✅ todos aceptan cualquier monto
}

var specialPayments = new List<SpecialPayment>
{
    new GiftCardProcessor()
};

foreach (var p in specialPayments)
{
    try
    {
        p.ProcessPayment(100); // 💥 lanza excepción esperada
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error esperado: {ex.Message}");
    }

    p.ProcessPayment(50); // ✅ válido
}

