using System.Runtime.InteropServices;

namespace AbraAtendimento.Menus
{
    public class MenuData
    {
        public static void DataDano()
        {
            Console.Clear();
            Console.WriteLine("\nInsira a data do dano");
            System.Console.WriteLine("");
            string data = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"\nO dano ocorreu dia: {data}");

            
        }
    }
}