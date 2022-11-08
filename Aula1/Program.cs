// Declaração de Tipos Primitivos
namespace Pratica1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // bool:
            bool a1 = true;
            bool b1 = false;
            bool resultBool = a1 && b1;
            Console.WriteLine($"Bool: {resultBool}");

            // int:
            int v1 = 10;
            int v2 = -20;
            int resultInt = v1 + v2;
            uint uv3 = 10 + 10;
            Console.WriteLine($"Int: {resultInt}");
            Console.WriteLine($"Uint: {uv3}");

            // float:
            float f1 = 10.5f; // Se não usar um (f) no final o compilador interpreta como double.
            float pi = 3.1415926535f;
            float resultFloat = pi * f1;
            resultFloat = resultFloat / 2;
            Console.WriteLine($"Float: {resultFloat}");

            // long:
            long l1 = 100000000;
            long l2 = -5000;
            long resultLong = l1 + (l2 * l1);
            Console.WriteLine($"Long: {resultLong}");

            // double:
            double d1 = 2000000.1231231313;
            double d2 = 100;
            double resultDouble = d1 * d2;

            // Em uma multiplicação de double com float o compilador realiza um processo chamado boxing e converte
            // o tipo float para um tipo double, resultando em um novo double.
            resultDouble = resultDouble * resultFloat;
            Console.WriteLine($"Double: {resultDouble}");

            // char:
            char o = 'o';
            char i = 'i';
            char exc = (char)33; // (char)nn converte um decimal em um caractere UTF-16

            // Variáveis do tipo char não podem ser somadas, então para concatenar-las em uma string se deve utilizar
            // a classe string() com um array char[]
            string resultChar = new string(new char[] { o, i, exc });
            Console.WriteLine($"Char: {resultChar}");

            // Declaração de reference types (objetos)

            // string:
            string s1 = "oi!";
            string s2 = new string('x', 5);
            string s3 = s1 + " " + s2;
            Console.WriteLine($"String: {s3}");

            // objetos:
            object obj1 = new object();
            Console.WriteLine($"Objeto vazio na memória: {obj1.ToString()}");
            // String são objetos por isso quando atribuimos o valor de s3 ao objeto só estamos fazendo uma referência
            // ao s3, e se alterarmos o s3 também alteramos o obj2
            object obj2 = s3;
            Console.WriteLine($"Referência a um objeto: {obj2.ToString()}");

            // Blocos de decisão e loop

            // Decisão | if / else:
            int val1 = 10;
            int val2 = 100;
            if (val1 + val2 > 0)
            {
                Console.WriteLine($"Condição do if: Verdadeira");
            }
            val2 = int.MinValue;
            if (val1 + val2 > 0)
            {
                Console.WriteLine($"Condição do if: Verdadeira");
            }
            else
            {
                Console.WriteLine($"Condição do if: Falsa");
            }

            // Decisão | switch / case:
            int teste1 = 1;
            bool csharpRocks = true;
            switch (teste1 > 0 && csharpRocks)
            {
                case true:
                    Console.WriteLine($"C# Rocks!");
                    break;
                case false:
                    Console.WriteLine($"C# é Ruim!");
                    break;
                default:
                    Console.WriteLine($"Jamais Cairá Aqui!");
            }

            // Loop | for:
            for (int counter = 0; counter < 5; counter++)
            {
                Console.WriteLine($"Olá, este é um for e esta é a iteração: {counter}");
            }

            // Loop | foreach:
            string stringForLoop = "c# is the best!";
            foreach (char caractere in stringForLoop)
            {
                Console.WriteLine($"{caractere}");
            }

            // Loop | while:
            string stringForWhile = "c# rocks!";
            while (stringForWhile.Length > 0)
            {
                Console.WriteLine($"{stringForWhile}");
                stringForWhile = stringForWhile.Substring(0, stringForWhile.Length - 1);
                if (stringForWhile.EndsWith("#"))
                {
                    stringForWhile = string.Empty;
                    Console.WriteLine($"String Vazia: {stringForWhile}");
                }
            }

            // ----------------------------------------------------------------------------------------------
            // Pratica 1
            Console.WriteLine($"--------------------------------------");
            Console.WriteLine($"|             Pratica 1              |");
            Console.WriteLine($"--------------------------------------");

            Console.WriteLine($"Reference Types");
            object obj10 = new object();
            var obj20 = new object();
            var obj30 = obj20;

            Console.WriteLine($"Comparando OBJs");
            Console.WriteLine(
                $"{obj10.GetType().Name} | {obj20.GetType().Name} | {obj30.GetType().Name}"
            );
            Console.WriteLine($"{obj20 == obj30}");

            Console.WriteLine($"--------------------------------------");
            Console.WriteLine($"Inicializando Strings de diferentes formas:");

            var s10 = new string('x', 5);
            string s20 = new string(new char[5] { 'x', 'x', 'x', 'x', 'x' });
            Console.WriteLine($"{s10 == s20}");

            string s30 = string.Concat((new char[5] { 'x', 'x', 'x', 'x', 'x' }).AsEnumerable());
            var s40 = $"{s30} string 30";
            Console.WriteLine($"{s40}");

            Console.WriteLine($"--------------------------------------");
            CompareString compare1 = new CompareString() { testeComparacao = "123" };
            var compare2 = new CompareString() { testeComparacao = "123" };

            Console.WriteLine($"Comparando com == e com equals");
            Console.WriteLine($"{compare1 == compare2}"); // False, endereços na memória diferentes
            Console.WriteLine($"{compare1.testeComparacao == compare2.testeComparacao}"); // True, valores iguais
            Console.WriteLine($"{compare1.testeComparacao.Equals(compare2.testeComparacao)}"); // Equals e == são sempre o mesmo resultado

            Console.WriteLine($"--------------------------------------");
            ClasseComplexa Complexa = new ClasseComplexa();
            Complexa.PropInterface = "123";

            IImprimirValores interfaceX = Complexa;

            Console.WriteLine($"{interfaceX.PropInterface}");

            Console.WriteLine($"--------------------------------------");
            Console.WriteLine($"Pratica Divisor");

            IDivisor divisorCalculadora = new DivisorCalc();
            Console.WriteLine($"Digite 'S' para SAIR a qualquer momento");
            string valorLido = string.Empty;
            int a;
            int b;
            string valorSaida = "S";
            do
            {
                //A
                Console.WriteLine($"Digite o Valor A:");
                valorLido = Console.ReadLine();
                if (valorSaida.Equals(valorLido))
                {
                    break;
                }
                try
                {
                    a = int.Parse(valorLido);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(
                        $"Erro ao converter o valor lido para int. Valor: {valorLido}"
                    );
                    continue;
                }

                // B
                Console.WriteLine($"Digite o Valor B:");
                valorLido = Console.ReadLine();
                if (valorSaida.Equals(valorLido))
                {
                    break;
                }
                try
                {
                    b = int.Parse(valorLido);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(
                        $"Erro ao converter o valor lido para int. Valor: {valorLido}"
                    );
                    continue;
                }
                // Resultado
                try
                {
                    var resultado = divisorCalculadora.Dividir(a, b);
                    Console.WriteLine($"Resultado:");
                    Console.WriteLine($"{resultado}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"Divisão por zero detectada. Reiniciando o processo");
                }
            } while (valorSaida.Equals(valorLido) == false);

            Console.WriteLine($"{divisorCalculadora.Dividir(100, 10)}");
        }
    }
}
