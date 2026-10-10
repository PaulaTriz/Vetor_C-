using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 12, 5, 87, 1, 34, 23 };

        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = 0; j < numeros.Length - 1 - i; j++)
            {
                if (numeros[j] < numeros[j + 1])
                {
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Vetor em ordem decrescente:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
