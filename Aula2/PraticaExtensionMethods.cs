namespace Pratica2
{
    public class PraticaExtensionMethods
    {
        public void Exercicio1()
        {
            var string1 = "123";
            var string2 = "10,0578";
            var string3 = "9000,87";
            var string4 = "010";

            Console.WriteLine($"String1 to int: {string1.ToInt()}");
            Console.WriteLine($"String2 to decimal: {string2.ToDecimal()}");
            Console.WriteLine($"String3 to decimal: {string3.ToDecimal()}");
            Console.WriteLine($"String4 to int: {string4.ToInt()}");

            var arrayBase = new int[50];
            for (int i = 0; i < arrayBase.Length; i++)
            {
                arrayBase[i] = i;
            }

            IEnumerable<int> enumerable = arrayBase;
            IList<int> lista = arrayBase;
            ICollection<int> collection = arrayBase;

            Console.WriteLine($"Qtd Enumerable: {enumerable.CountCustom()}");
            Console.WriteLine($"Qtd Lista: {lista.CountCustom()}");
            Console.WriteLine($"Qtd Collection: {collection.CountCustom()}");
        }
    }

    public static class ExtensionMethodsAula
    {
        public static int ToInt(this string value)
        {
            return int.Parse(value);
        }

        public static decimal ToDecimal(this string minhaString)
        {
            return decimal.Parse(minhaString);
        }

        public static int CountCustom<T>(this IEnumerable<T> enumerable)
        {
            int countAux = 0;
            foreach (var item in enumerable)
            {
                countAux++;
            }
            return countAux;
        }
    }
}
