namespace Pratica2
{
    public class FilaGenerics<T>
    {
        private int _countInterno;
        public int Count
        {
            get { return _countInterno; }
        }
        private T[] arrayInterno;

        // Construtor
        public FilaGenerics(int quantidade)
        {
            _countInterno = 0;
            arrayInterno = new T[quantidade];
        }

        public void Enqueue(T elemento)
        {
            arrayInterno[_countInterno] = elemento;
            _countInterno++;
        }

        public T Dequeue()
        {
            var elemento = arrayInterno[0];
            lock (arrayInterno)
            {
                for (int i = 1; i < _countInterno; i++)
                {
                    arrayInterno[i - 1] = arrayInterno[i];
                }
                _countInterno--;
            }
            return elemento;
        }
    }
}
