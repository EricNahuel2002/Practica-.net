using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Net.Mail;

namespace prueba_SOLID;

// Viola SRP: la clase hace demasiadas cosas (genera, guarda y envía reportes)

public class ReportGenerator
{

    private ISender _sender;
    public ReportGenerator(ISender sender)
    {
        _sender = sender;
    }


    public void GenerateReport(string data)
    {
        string report = $"--- Report ---\n{data}";
        Console.WriteLine("Reporte generado.");
        SaveToFile(report);
        this._sender.SendReport(report);
    }

    private void SaveToFile(string report)
    {
        File.WriteAllText("report.txt", report);
        Console.WriteLine("Reporte guardado en archivo.");
    }

   
}



public interface ISender
{
    public void SendReport(string report);
}

//SOLUCION

public class EmailSender: ISender
{
    public void SendReport(string report)
    {
        var mail = new MailMessage("from@example.com", "to@example.com", "Reporte", report);
        var client = new SmtpClient("smtp.example.com");
        client.Send(mail);
        Console.WriteLine("Reporte enviado por email.");
    }
}
