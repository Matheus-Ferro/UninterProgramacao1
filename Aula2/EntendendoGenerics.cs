namespace Pratica2
{
    public class EntendendoGenerics
    {
        void Principal()
        {
            var macho = new Cachorro();
            var femea = new Cachorro();
            var filhote = Cruzar(macho, femea);
        }

        // Método que retorna um filhote do mesmo tipo genérico dos pais.
        public T Cruzar<T>(T macho, T femea) where T : Mamifero<T>
        {
            var filhote = Activator.CreateInstance<T>();
            filhote.Mae = femea;
            filhote.Pai = macho;
            filhote.Peso = 10;
            return filhote;
        }

        // Classe abstrata que descreve um mamífero genérico, pode ser qualquer mamífero
        // por isso o tipo genérico <T>, pode ser de qualquer tipo, um gato, cachorro ou
        // elefante. Restringimos o tipo genérico para que seja somente mamíferos do tipo
        // genérico (where T : Mamifero<T>).
        public abstract class Mamifero<T> where T : Mamifero<T>
        {
            // Ao dizer que tanto o pai quanto a mãe são do tipo genérico asseguramos
            // que sejam do mesmo tipo ao implementarmos a classe abstrata.
            public T Pai { get; set; }
            public T Mae { get; set; }
            public decimal Peso { get; set; }
        }

        // Implementa a classe abstrata passando a própria classe como tipo: <Cachorro>
        public class Cachorro : Mamifero<Cachorro>
        {
            public string Raca { get; set; }
        }

        // Implementa a classe abstrata passando a própria classe como tipo: <Gato>
        public class Gato : Mamifero<Gato>
        {
            public string Raca { get; set; }
            public int Bigode { get; set; }
        }

        // Implementa a classe abstrata passando a própria classe como tipo: <Elefante>
        public class Elefante : Mamifero<Elefante>
        {
            public int Tromba { get; set; }
        }
    }
}
