using AbraAtendimento.Menus;

namespace AbraAtendimento.Animacoes
{
    public static class AnimacaoSaida
    {
        public static void AnimacaoRegioes()
        {
            Console.Clear();
            Console.Write("\nVoltando ao menu anterior..");
            Thread.Sleep(500);
            Console.WriteLine(".");
            Thread.Sleep(350);
            Console.WriteLine(".");
            Thread.Sleep(350);
            Console.WriteLine(".");
            Thread.Sleep(350);
            Console.WriteLine(".");
            Thread.Sleep(350);
            Console.WriteLine(".");
            Thread.Sleep(350);
            Console.WriteLine(".");
            Thread.Sleep(350);
            Console.Clear();
            MenuRegioes.ExibirRegioes();
        }

        public static void AnimacaoPrincipal()
        {
            Console.Clear();
            Console.Write("\nVoltando ao menu anterior..");
            Thread.Sleep(500);
            Console.WriteLine(".");
            Thread.Sleep(350);
            Console.WriteLine(".");
            Thread.Sleep(350);
            Console.WriteLine(".");
            Thread.Sleep(350);
            Console.WriteLine(".");
            Thread.Sleep(350);
            Console.WriteLine(".");
            Thread.Sleep(350);
            Console.WriteLine(".");
            Thread.Sleep(350);
            Console.Clear();
            MenuInicial.VisualizarMenu();
        }
    }
}