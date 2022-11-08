namespace Pratica2
{
    public class FilaObject
    {
        private int _countInterno;
        public int Count
        {
            get { return _countInterno; }
        }
        private object[] arrayInterno;

        public FilaObject(int quantidade)
        {
            _countInterno = 0;
            arrayInterno = new object[quantidade];
        }

        public void Enqueue(object elemento)
        {
            arrayInterno[_countInterno] = elemento;
            _countInterno++;
        }

        public object Dequeue()
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
