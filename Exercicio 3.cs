using System;

class Program
{
    static void Main(string[] args)
    {
        double[] valores = { 7.5, 8.0, 6.5, 9.0, 5.5 };
        double soma = 0;

        for (int i = 0; i < valores.Length; i++)
        {
            soma += valores[i];
        }

        double media = soma / valores.Length;
        Console.WriteLine("A média dos valores é: " + media);
    }
}