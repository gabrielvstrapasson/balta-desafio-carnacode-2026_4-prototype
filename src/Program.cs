using Project.Client;
using Project.ConcretePrototype;
using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Templates de Documentos ===\n");

        var documentService = new DocumentService();
        var baseTemplate = documentService.CreateDocument();

        var startTime = DateTime.Now;

        for (int i = 1; i <= 5; i++)
        {
            var contract = (DocumentTemplate)baseTemplate.Clone();
            contract.Title = $"Contrato #{i} - Cliente {i}";
            contract.RequiredFields[0] = $"Campo obrigatório para contrato #{i}";
            documentService.DisplayTemplate(contract);
        }

        var elapsed = (DateTime.Now - startTime).TotalMilliseconds;
        Console.WriteLine($"Tempo total: {elapsed}ms\n");

    }
}