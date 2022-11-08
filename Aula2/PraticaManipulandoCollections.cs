namespace Pratica2
{
    class PraticaManipulandoCollections
    {
        public void Exercicio1()
        {
            var arrayBase = new int[50];
            for (int i = 0; i < arrayBase.Length; i++)
            {
                arrayBase[i] = i;
            }

            IEnumerable<int> enumerable = arrayBase;
            IList<int> lista = arrayBase;
            ICollection<int> collection = arrayBase;

            foreach (var item in enumerable)
            {
                Console.WriteLine($"Item: {item}");
            }
            foreach (var item in lista)
            {
                Console.WriteLine($"Item: {item}");
            }
            foreach (var item in collection)
            {
                Console.WriteLine($"Item: {item}");
            }

            int countAux = 0;
            foreach (var item in enumerable)
            {
                countAux++;
            }
            Console.WriteLine($"Qtd Enumerable: {countAux}");
            Console.WriteLine($"Qtd Lista: {lista.Count}");
            Console.WriteLine($"Qtd Collection: {collection.Count}");

            int countAux2 = 0;
            foreach (var item in enumerable)
            {
                if (countAux2 == 30)
                {
                    Console.WriteLine($"Item 30 do enumerable: {item}");
                }
                countAux2++;
            }
            Console.WriteLine($"Item 30 da lista: {lista[30]}");

            int countAux3 = 0;
            foreach (var item in collection)
            {
                if (countAux3 == 30)
                {
                    Console.WriteLine($"Item 30 da collection: {item}");
                }
                countAux3++;
            }
        }
    }
}
