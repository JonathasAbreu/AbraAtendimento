using AbraAtendimento.Animacoes;
using AbraAtendimento.Cidades;
namespace System.Collections.Generic { }
namespace AbraAtendimento.Menus

{
    public class MenuRegioes
    {
        public static void ExibirRegioes()
        {
            Console.Clear();
            Console.WriteLine("\n------ Em qual região será o atendimento ------\n");
            Console.WriteLine("1 - SUDESTE");
            Console.WriteLine("2 - SUL");
            Console.WriteLine("3 - NORTE");
            Console.WriteLine("4 - CENTRO-OESTE");
            Console.WriteLine("5 - NORDESTE");
            Console.WriteLine("0 - VOLTAR AO MENU ANTERIOR");
            Console.WriteLine("--------------------------------");

            int regiaoEscolhida = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (regiaoEscolhida)
            {
                // SUDESTE
                case 1:
                    Sudeste.ImprimirSudeste("Sudeste", new List<string>() { "ES", "RJ", "SP", "MG", "0 - Voltar ao menu anterior" });
                    break;

                // SUL
                case 2:
                    Sul.ImprimirSul("Sul", new List<string>() { "PR", "SC", "RS", "0 - Voltar ao menu anterior" });
                    break;

                // NORTE    
                case 3:
                    Norte.ImprimirNorte("Norte", new List<string>() { "AM", "PA", "AC", "RO", "RR", "AP", "TO", "0 - Voltar ao menu anterior" });

                    break;

                // CENTRO-OESTE
                case 4:
                    CentroOeste.ImprimirCentroOeste("Centro-Oeste", new List<string>() { "GO", "MT", "MS", "DF", "0 - Voltar ao menu anterior" });
                    break;

                // NORDESTE
                case 5:
                    Nordeste.ImprimirNordeste("Nordeste", new List<string>() { "MA", "PI", "CE", "RN", "PB", "PE", "AL", "SE", "BA", "0 - Voltar ao menu anterior" });
                    break;

                // VOLTAR MENU
                case 0:
                    AnimacaoSaida.AnimacaoPrincipal();
                    break;

                default: // Estou apanhando pra fazer esse loop do retorno.
                    if (regiaoEscolhida < 0 || regiaoEscolhida > 5)
                    {
                        Console.WriteLine($"\nOpção {regiaoEscolhida} não é válida. Digite uma das opções anteriores:");                        
                    }
                    else
                    {
                        AnimacaoSaida.AnimacaoRegioes();
                        ExibirRegioes();
                    }

                    break;
            }
        }
    }
}