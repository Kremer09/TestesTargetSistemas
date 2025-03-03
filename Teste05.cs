//5) Escreva um programa que inverta os caracteres de um string.
//IMPORTANTE:
//a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
//b) Evite usar funções prontas, como, por exemplo, reverse;

using System;

class Program
{
    static void Main()
    {
        Console.Write("digite uma string para ser inversa: ");
        string original = Console.ReadLine();

        char[] carac = original.ToCharArray();
        
        int inicio = 0;
        int fim = carac.Length - 1;

        while (inicio < fim)
        {
            char temp = carac[inicio];
            carac[inicio] = carac[fim];
            carac[fim] = temp;

            inicio++;
            fim--;
        }

        string invertida = new string(carac);

        Console.WriteLine($"String inversa: {invertida}");
    }
}

//converte a string digitada em um array de caracts e dai vai trocando os valores pelas extremidades até inverter completamente a string
