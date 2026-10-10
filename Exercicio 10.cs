using System;

class Program
{
    static void Main(string[] args)
    {
        int totalMercadorias = 40;
        string[] nomes = new string[totalMercadorias];
        int[] quantidades = new int[totalMercadorias];
        double[] precos = new double[totalMercadorias];
        bool cadastradas = false;

        int opcao = 0;

        while (opcao != 3)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Cadastra mercadorias");
            Console.WriteLine("2. Exibe valor total em mercadorias da empresa");
            Console.WriteLine("3. Sair");
            Console.Write("OPÇÃO: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("\n--- Cadastro de 40 Mercadorias ---");
                    for (int i = 0; i < totalMercadorias; i++)
                    {
                        Console.WriteLine("Mercadoria " + (i + 1) + ":");
                        Console.Write("Nome: ");
                        nomes[i] = Console.ReadLine();

                        Console.Write("Quantidade em estoque: ");
                        quantidades[i] = int.Parse(Console.ReadLine());

                        Console.Write("Preço unitário: ");
                        precos[i] = double.Parse(Console.ReadLine());
                    }
                    cadastradas = true;
                    Console.WriteLine("Cadastro concluído com sucesso!");
                    break;

                case 2:
                    if (!cadastradas)
                    {
                        Console.WriteLine("\nNenhuma mercadoria cadastrada ainda. Selecione a opção 1 primeiro.");
                    }
                    else
                    {
                        double valorTotalGeral = 0;
                        for (int i = 0; i < totalMercadorias; i++)
                        {
                            valorTotalGeral += quantidades[i] * precos[i];
                        }
                        Console.WriteLine("\nO valor total em mercadorias na empresa é: R$ " + valorTotalGeral.ToString("F2"));
                    }
                    break;

                case 3:
                    Console.WriteLine("\nA encerrar o programa...");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida!");
                    break;
            }
        }
    }
}
