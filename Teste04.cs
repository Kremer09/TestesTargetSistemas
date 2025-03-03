//4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
//• SP – R$67.836,43
//• RJ – R$36.678,66
//• MG – R$29.229,88
//• ES – R$27.165,48
//• Outros – R$19.849,53
//Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.  

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dicionário com o faturamento por estado
        Dictionary<string, double> faturamentoEstados = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        // Calculando o faturamento total
        double faturamentoTotal = 0;
        foreach (var valor in faturamentoEstados.Values)
        {
            faturamentoTotal += valor;
        }

        // Exibindo a porcentagem de cada estado no faturamento total
        Console.WriteLine("percentual de representacao de cada estado no faturamento :");
        foreach (var estado in faturamentoEstados)
        {
            double percentual = (estado.Value / faturamentoTotal) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }
}

//armazena os valores dos faturamentos por estado e soma tudo para pegar o faturamento total e faz o calculo de participação percentual dos estados

