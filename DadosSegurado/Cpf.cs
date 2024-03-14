namespace AbraAtendimento.DadosSegurado
{
    public class Cpf
    {
        public static void DadoPessoal()
        {
            Console.Clear();
            Console.WriteLine("\n>>>Insira o CPF do titular do seguro <<<\n");
            string cpf = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"\nO dano ocorreu dia: {cpf}");
        }
    }
}