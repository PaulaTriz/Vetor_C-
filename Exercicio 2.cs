using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[5];
        double[] nota1 = new double[5];
        double[] nota2 = new double[5];
        double[] medias = new double[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("--- Aluno " + (i + 1) + " ---");
            Console.Write("Nome: ");
            nomes[i] = Console.ReadLine();

            Console.Write("Nota 1: ");
            nota1[i] = double.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            nota2[i] = double.Parse(Console.ReadLine());

            medias[i] = (nota1[i] + nota2[i]) / 2.0;
        }

        Console.WriteLine("\n=== LISTAGEM DOS ALUNOS ===");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Nome: " + nomes[i] + " | Nota 1: " + nota1[i] + " | Nota 2: " + nota2[i] + " | Média: " + medias[i]);

        }
    }
}
