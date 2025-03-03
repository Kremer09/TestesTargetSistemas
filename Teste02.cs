//2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...)
// escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.
//IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um numero: ");
        int num = int.Parse(Console.ReadLine());

        if (PertenceFibonacci(num))
            Console.WriteLine($"O numero {num} pertence a sequencia de Fibonacci.");
        else
            Console.WriteLine($"O numero {num} NAO pertence a sequencia de Fibonacci.");
    }

    static bool PertenceFibonacci(int numero)
    {
        int a = 0, b = 1, temp;

        while (b <= numero)
        {
            if (b == numero)
                return true;

            temp = a + b;
            a = b;
            b = temp;
        }

        return false;
    }
}

// Gera a sequencia do Fibonacci ate o numero que foi digitado, se ele for encontrado retorna 1, se não for retorna 0 e o programa mostra a mensagem