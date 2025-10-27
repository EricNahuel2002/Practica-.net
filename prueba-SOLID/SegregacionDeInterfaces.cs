using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_SOLID;

public interface IScanner
{
    void Scan(string document);
    void Fax(string document);
}


public interface IPrinter
{
    void Print(string document);
}


public class BasicPrinter : IPrinter
{
    public void Print(string document)
    {
        Console.WriteLine($"Imprimiendo documento: {document}");
    }
}


public class MultiFunctionPrinter : IPrinter, IScanner
{
    public void Print(string document)
    {
        Console.WriteLine($"Imprimiendo documento: {document}");
    }
    public void Scan(string document)
    {
        Console.WriteLine($"Escaneando documento: {document}");
    }
    public void Fax(string document)
    {
        Console.WriteLine($"Enviando fax del documento: {document}");
    }
}