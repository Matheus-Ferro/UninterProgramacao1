namespace Pratica2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Inicializando um array nativo
            //Um array de inteiros contendo 10 posições
            int[] inteiros = new int[10];

            //Um array de caracteres com 2 posições já inicializadas na construção
            char[] caracteres = new char[2] { 'o', 'i' };
            foreach (var item in caracteres)
            {
                Console.WriteLine($"{item}");
            }

            var versoes = new Version[5]; //Um array de uma classe qualquer
            var matriz = new int[3, 2]; //Uma matriz 3x2 (array bi-dimensional)
            var matriz3D = new int[3, 3, 3]; //Uma matriz 3x3x3 (array tri-dimensional)

            Console.WriteLine($"---------------------------------------------------------");
            Console.WriteLine($"Aula Prática 2");
            Console.WriteLine($"---------------------------------------------------------");

            Console.WriteLine($"---------------------------------------------------------");
            Console.WriteLine($"Arrays");
            Console.WriteLine($"---------------------------------------------------------");

            PraticaComArrays praticaComArrays = new PraticaComArrays();
            // praticaComArrays.Exercicio1();
            // praticaComArrays.Exercicio2();
            PraticaComFilasBoxing praticaComFilasBoxing = new PraticaComFilasBoxing();
            // praticaComFilasBoxing.ExercicioBoxingFilas();
            PraticaManipulandoCollections praticaManipulandoCollections =
                new PraticaManipulandoCollections();
            // praticaManipulandoCollections.Exercicio1();
            PraticaExtensionMethods praticaExtensionMethods = new PraticaExtensionMethods();
            praticaExtensionMethods.Exercicio1();
        }
    }
}
