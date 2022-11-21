using System.Diagnostics;

namespace Pratica4
{
  public class EntendendoThreads
  {
    public void ProgAssincrona()
    {
      Console.WriteLine($"---------------------------------------------");
      Console.WriteLine($"Threads");
      Console.WriteLine($"---------------------------------------------");
      Stopwatch sw = new Stopwatch();
      sw.Start();
      ExecutarComThreads();
      sw.Stop();
      Console.WriteLine($"Operação gastou {sw.ElapsedMilliseconds} milissegundos");
    }

    static void RealizarOperacao(int op, string nome, string sobrenome)
    {
      Console.WriteLine($"Iniciando Operação {op} ...");
      for (int i = 0; i < 1000000000; i++)
      {
        var p = new Pessoa(nome, sobrenome, 35);
      }
      Console.WriteLine($"Finalizando Operação {op} ...");
    }

    static void ExecutarSequencial()
    {
      // 37 Segundos
      RealizarOperacao(1, "Fulano", "da Silva");
      RealizarOperacao(2, "Siclano", "da Silva");
      RealizarOperacao(3, "Beltrano", "da Silva");
    }

    static void ExecutarComThreads()
    {
      // 17 Segundos
      var t1 = new Thread(() =>
      {
        RealizarOperacao(1, "Fulano", "da Silva");
      });
      var t2 = new Thread(() =>
      {
        RealizarOperacao(2, "Siclano", "da Silva");
      });
      var t3 = new Thread(() =>
      {
        RealizarOperacao(3, "Beltrano", "da Silva");
      });
      t1.Start();
      t3.Start();
      t2.Start();

      // O Join() faz com que a thread do método que chamou espere a tarefa ser concluida
      t1.Join();
      t2.Join();
      t3.Join();
    }
  }
}
