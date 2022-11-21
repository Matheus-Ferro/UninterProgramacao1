namespace Pratica3
{
    public class PraticaComLambdas
    {
        public void Exercicio1()
        {
            Action<DateTime> lambda1 = (DateTime data) =>
            {
                Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss"));
            };

            lambda1(new DateTime(2010, 05, 27));
            lambda1(new DateTime(2001, 09, 07, 10, 05, 30));

            Func<int, int> lambda2 = (int valor) =>
            {
                return valor + 1;
            };

            Console.WriteLine(lambda2(5));
            Console.WriteLine(lambda2(10));

            Func<object, object, string> lambda3 = (object elemento, object elemento2) =>
            {
                return $"{elemento} {elemento2}";
            };

            Console.WriteLine(lambda3("Nota:", 10));
            Console.WriteLine(lambda3(11, 0.5M));

            Console.WriteLine($"----------------------------------");

            // Inicia um array com 10 valores lineares
            var arrayBase = new int[10];
            for (int i = 0; i < arrayBase.Length; i++)
            {
                arrayBase[i] = i;
            }
            IEnumerable<int> enumerable = arrayBase;

            // Array base 5
            var arrayBase5 = new int[5] { 5, 10, 15, 20, 25 };

            // Lambda
            Func<IEnumerable<int>, IEnumerable<int>, IEnumerable<int>> multiplicaVetores = (
                IEnumerable<int> vetor,
                IEnumerable<int> vetor2
            ) =>
            {
                List<int> result = new List<int>(vetor.Count());
                foreach (var item in vetor)
                {
                    result.Add(vetor2.Sum(x => x * item));
                }
                return result;
            };

            var result = multiplicaVetores(arrayBase, arrayBase5);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }

    public static class ExtensionMethodLambda
    {
        public static IEnumerable<T> MultiplicaPorEnumerable<T>(
            this IEnumerable<T> origem,
            IEnumerable<T> vetor2,
            Func<IEnumerable<T>, IEnumerable<T>, IEnumerable<T>> funcaoMultiplicar
        )
        {
            return funcaoMultiplicar(origem, vetor2);
        }
    }
}
