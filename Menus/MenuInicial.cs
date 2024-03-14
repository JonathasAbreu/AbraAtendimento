namespace AbraAtendimento.Menus
{
    public class MenuInicial
    {
        public static void VisualizarMenu()
        {
            Console.WriteLine("\n------ Selecione uma Opção ------ \n");
            Console.WriteLine("1 - INICIAR NOVO ATENDIMENTO");
            Console.WriteLine("2 - ACOMPANHAR ATENDIMENTO");
            Console.WriteLine("3 - QUERO FALAR COM ANALISTA");
            Console.WriteLine("4 - QUERO FALAR COM LÍDER");
            Console.WriteLine("0 - SAIR");
            Console.WriteLine("---------------------------------");

            int opcaoEscolhida = int.Parse(Console.ReadLine());
            Console.Clear();

            switch(opcaoEscolhida)
            {
                case 1:
                    MenuRegioes.ExibirRegioes();
                    break;
                default:
                    Console.WriteLine("Opção inválida! Selecione outra opção.");
                    VisualizarMenu();
                    break;
            }
        }        
    }
}