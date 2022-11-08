namespace Pratica2
{
    class PraticaComFilasBoxing
    {
        public void ExercicioBoxingFilas()
        {
            // Iniciando as Listas
            var filaGenerics = new FilaGenerics<Animal>(10);
            var filaObject = new FilaObject(10);

            // Instância das classes filhas
            Cachorro cachorro1 = new Cachorro();
            Gato gato1 = new Gato();

            // Instancia com box
            Animal cachorro2 = new Cachorro();
            Animal gato2 = new Gato();

            // Instancia com box para interface
            IBarulhento cachorro3 = new Cachorro();
            IBarulhento gato3 = new Gato();

            // Add na fila
            filaGenerics.Enqueue(cachorro1);
            filaGenerics.Enqueue(gato1);
            filaGenerics.Enqueue(cachorro2);
            filaGenerics.Enqueue(gato2);
            filaGenerics.Enqueue((Animal)cachorro3);
            filaGenerics.Enqueue((Animal)cachorro3);

            filaObject.Enqueue(cachorro1);
            filaObject.Enqueue(gato1);
            filaObject.Enqueue(cachorro2);
            filaObject.Enqueue(gato2);
            filaObject.Enqueue(cachorro3);
            filaObject.Enqueue(gato3);

            try
            {
                while (filaGenerics.Count > 0)
                {
                    IBarulhento animal = filaGenerics.Dequeue();
                    Console.WriteLine(
                        $"Meu type é {animal.GetType().BaseType.Name}. Sou um {animal.GetType().Name}. Emito o seguinte som: {animal.EmitirSom()}"
                    );
                }
                while (filaObject.Count > 0)
                {
                    IBarulhento animal = (Animal)filaObject.Dequeue();
                    Console.WriteLine(
                        $"Meu type é {animal.GetType().BaseType.Name}. Sou um {animal.GetType().Name}. Emito o seguinte som: {animal.EmitirSom()}"
                    );
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
