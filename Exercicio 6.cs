using System;

class Program
{
    static void Main(string[] args)
    {
        int[] vetorA = new int[5];
        int[] vetorB = new int[5];
        int[] vetorSoma = new int[5];

        Console.WriteLine("--- Preencha o primeiro vetor ---");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Vetor A[" + i + "]: ");
            vetorA[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n--- Preencha o segundo vetor ---");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Vetor B[" + i + "]: ");
            vetorB[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            vetorSoma[i] = vetorA[i] + vetorB[i];
        }

        Console.WriteLine("\n--- Vetor Soma ---");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Soma[" + i + "] = " + vetorSoma[i]);

        }
    }
}
