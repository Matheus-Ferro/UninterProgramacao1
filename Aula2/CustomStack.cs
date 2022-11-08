namespace Pratica2
{
    // Classe customizada de uma Stack simples.
    // Observe que ela declara um template onde aceita qualqyuer Type como parâmetro dentro do <>
    public class CustomStack<T>
    {
        //posição atual do ponteiro da pilha
        int position;

        //Quando declaramos que nossa classe irá trabalhar com Generics, usando a notação <T>
        //podemos passar qualquer Type/objeto para o T
        //E podemos também usar o T como um "placeholder", ou seja,
        //um acrônimo dentro de nossa classe, para referência um Type qualquer.
        //Veja, nesse exemplo, não sabemos o que é o "T"
        //Apenas sabemos que será um Type qualquer (qualquer tipo derivado de object)
        T[] arrayDoTipoT = new T[100];

        public void Push(T obj)
        {
            arrayDoTipoT[position++] = obj;
        }

        public T Pop()
        {
            return arrayDoTipoT[--position];
        }
    }

    public class ExemploStack
    {
        public ExemploStack()
        {
            var customStackInstance = new CustomStack<string>();
            customStackInstance.Push("oi pessoal!");
            customStackInstance.Push("Essa é uma fila!");
            customStackInstance.Push("É uma estrutura de dados que trabalha com LIFO.");
            customStackInstance.Push("LIFO-> Last  in, First Out.");
            customStackInstance.Push("fim....");

            string popResult = customStackInstance.Pop();
            popResult += customStackInstance.Pop();
            popResult += customStackInstance.Pop();
            popResult += customStackInstance.Pop();
            popResult += customStackInstance.Pop();

            Console.WriteLine(popResult);
            //fim....LIFO-> Last  in, First Out.É uma estrutura de dados que trabalha com LIFO.Essa é uma fila!oi pessoal!

            var customStack1 = new CustomStack<int>();
            var customStack2 = new CustomStack<string>();
            var customStack3 = new CustomStack<DateTime>();
            var customStack4 = new CustomStack<object>();
            var customStack5 = new CustomStack<Enum>();

            ObjectStack stack = new ObjectStack();
            stack.Push("uma string qualquer"); // Armazenamos uma string -- boxing
            stack.Push(100); // Depois um int -- boxing
            int i = (int)stack.Pop(); // Para converter o tipo para int, precisamos fazer um unboxing explicito (explicit cast) - Erro!
            string s = (string)stack.Pop();
        }
    }

    public class ObjectStack
    {
        int position;
        object[] data = new object[10];

        public void Push(object obj)
        {
            data[position++] = obj;
        }

        public object Pop()
        {
            return data[--position];
        }
    }
}
