//3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
//• O menor valor de faturamento ocorrido em um dia do mês;
//• O maior valor de faturamento ocorrido em um dia do mês;
//• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.
//IMPORTANTE:
//a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
//b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;

using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // valores dos faturamentos, (nao foi recebido nenhum json ou xml com numeros para entrada, entao coloquei no programa mesmo)
        List<double> faturamentos = new List<double>
        {
            10500.50, 12000.75, 9800.30, 0, 0, 15000.00, 0,
            17200.25, 0, 16000.90, 14050.55, 0, 15800.45, 13400.00,
            0, 18000.75, 15950.40, 0, 0, 16250.80, 17500.60, 0, 0, 
            16800.00, 0, 17400.10, 16350.55, 17750.20, 0, 0
        };

        var diasComFaturamento = faturamentos.Where(valor => valor > 0).ToList();

        if (diasComFaturamento.Count == 0)
        {
            Console.WriteLine("Nao tem dados o suficiente para analise.");
            return;
        }

        double menorFaturamento = diasComFaturamento.Min();
        double maiorFaturamento = diasComFaturamento.Max();


        double mediaFaturamento = diasComFaturamento.Average();

        int diasAcimaDaMedia = diasComFaturamento.Count(valor => valor > mediaFaturamento);

        Console.WriteLine($"Menor faturamento: {menorFaturamento}");
        Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
        Console.WriteLine($"Dias com faturamento acima da edia: {diasAcimaDaMedia}");
    }
}
