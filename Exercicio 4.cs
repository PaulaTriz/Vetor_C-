using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 15, 42, 8, 99, 23, 4 };
        int maior = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
        }
        Console.WriteLine("O maior valor é: " + maior);
    }
}
