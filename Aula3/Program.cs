namespace Pratica3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Aula Prática de C# 3");
            Console.WriteLine($"----------------------------------");
            Console.WriteLine($"Lambda Functions");
            Console.WriteLine($"----------------------------------");
            PraticaComLambdas praticaComLambdas = new PraticaComLambdas();
            praticaComLambdas.Exercicio1();
            Console.WriteLine($"----------------------------------");
            PraticaExecucaoTardia praticaTardia = new PraticaExecucaoTardia();
            praticaTardia.Exercicio1();
        }
    }
}
