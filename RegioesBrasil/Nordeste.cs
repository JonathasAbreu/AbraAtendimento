using AbraAtendimento.Animacoes;

namespace AbraAtendimento.Cidades
{
    public static class Nordeste
    {
        public static void ImprimirNordeste(string regiao, List<string> opcoes)
        {
            Console.Clear();
            Console.WriteLine($"\n--- Escolha um estado da região {regiao} ---\n");

            for (int i = 0; i < opcoes.Count; i++)
            {
                if (i == opcoes.Count - 1)
                {
                    Console.WriteLine($"{opcoes[i]}");
                }
                else
                {
                    Console.WriteLine($"{i + 1} - {opcoes[i]}");
                }
            }
            Console.WriteLine("-------------------------");

            int escolha = int.Parse(Console.ReadLine());

            while (escolha < 0 || escolha >= opcoes.Count)
            {
                Console.WriteLine($"\nOpção {escolha} não é válida. Digite uma das opções anteriores:");
                escolha = int.Parse(Console.ReadLine());
            }

            if (escolha == 0)
            {
                AnimacaoSaida.AnimacaoRegioes();
            }

            Console.Clear();
            Console.WriteLine($"\nSeu atendimento será no estado {opcoes[escolha - 1]}.");
        }
    }
}