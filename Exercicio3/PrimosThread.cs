namespace Exercicio3
{
  public class PrimosThread
  {
    // Atributo que receberá o parâmetro do construtor
    private int max;

    // Atributo que armazena quantas vezes o o contador foi divisível
    private int divisivel = 0;

    // Atributo que determina quantas Threads serão criadas
    private int nThreads = 0;

    // Método construtor
    public PrimosThread(int maximo)
    {
      this.max = maximo;
      StartThreads();
    }

    // Este método foi iniciado no construtor assim que a classe foi instanciada.
    // Ele é responsável por calcular quantas Threads criar e as inicia.
    public void StartThreads()
    {
      // Este loop define quantas Threads criar, com base no enunciado, onde pede
      // para criar uma Thread a cada dez valores.
      for (var i = 0; i < max; i++)
      {
        if (i == 0 || i % 10 == 0)
        {
          nThreads += 1;
        }
      }

      // Com o número de Threads definido, neste loop é feito o start.
      for (var i = 0; i < nThreads; i++)
      {
        new Thread((VerificaPrimo)).Start();
      }
    }

    // Método executado a partir das Threads.
    // No console vão ficar várias linhas dessincronizadas, creio eu
    // que por conta do paralelismo das Threads.
    public void VerificaPrimo()
    {
      // j = dividendo
      for (var j = 2; j <= max; j++)
      {
        // i = divisor
        for (var i = 1; i <= j; i++)
        {
          // Se o resto da divisão for igual a 0 é por que é divisível
          // portanto acrescenta 1 ao atributo.
          divisivel += j % i == 0 ? 1 : 0;

          // Se tiver mais que 2 divisíveis quer dizer que não é primo.
          // Portanto resetamos o atributo e quebramos o loop para irmos
          // ao próximo dividendo.
          if (divisivel > 2)
          {
            divisivel = 0;
            break;
          }
        }
        // Se o loop do divisor terminar e a quantidade de divisíveis for
        // igual a 2 quer dizer que o número é primo, então é externado o
        // o resultado ao usuário e resetado o atributo divisível.
        if (divisivel == 2)
        {
          Console.WriteLine($"{j} é primo");
          divisivel = 0;
        }
      }
    }
  }
}