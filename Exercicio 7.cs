using System;

class Program
{
    static void Main(string[] args)
    {
        int[] vetorA = { 1, 2, 3, 4, 5 };
        int[] vetorB = { 10, 20, 30, 40, 50 };
        int[] vetorSoma = new int[5];

        for (int i = 0; i < 5; i++)
        {
            vetorSoma[i] = vetorA[i] + vetorB[i];
            Console.WriteLine("Posição " + i + ": " + vetorSoma[i]);
        }
    }
}
