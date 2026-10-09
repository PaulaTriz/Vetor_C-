using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 15, 42, 8, 99, 23, 4 };
        int menor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }
        Console.WriteLine("O menor valor é: " + menor);
    }
}
