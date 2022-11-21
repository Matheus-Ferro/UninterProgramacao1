using System.Diagnostics;

namespace Pratica4
{
    public class EntendendoTasks
    {
        public void ProgAssincrona()
        {
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"Tasks");
            Console.WriteLine($"---------------------------------------------");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ExecutarComTasks();
            sw.Stop();
            Console.WriteLine($"Operação gastou {sw.ElapsedMilliseconds} milissegundos");
        }

        static void RealizarOperacao(int op, string nome, string sobrenome)
        {
            Console.WriteLine($"Iniciando Tarefa {op} ...");
            for (int i = 0; i < 1000000000; i++)
            {
                var p = new Pessoa(nome, sobrenome, 35);
            }
            Console.WriteLine($"Finalizando Tarefa {op} ...");
        }

        static void ExecutarComTasks()
        {
            var t1 = Task<int>.Run(() =>
            {
                RealizarOperacao(1, "Fulano", "da Silva");
                return 1;
            });
            var t2 = Task<int>.Run(() =>
            {
                RealizarOperacao(2, "Siclano", "da Silva");
                return 2;
            });
            var t3 = Task<int>.Run(() =>
            {
                RealizarOperacao(3, "Beltrano", "da Silva");
                return 3;
            });

            Console.WriteLine($"Tarefa {t1.Result} finalizou.");
            Console.WriteLine($"Tarefa {t2.Result} finalizou.");
            Console.WriteLine($"Tarefa {t3.Result} finalizou.");
        }
    }
}
