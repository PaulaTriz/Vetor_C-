using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 10, 20, 30, 40, 50 };

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Elemento na posição " + i + ": " + numeros[i]);
        }
    }
}