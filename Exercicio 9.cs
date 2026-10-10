using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Insira o " + (i + 1) + "º nome: ");
            nomes[i] = Console.ReadLine();
        }

        Console.WriteLine("\n--- LISTA DE NOMES ---");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine((i + 1) + ". " + nomes[i]);
        }
    }
}
