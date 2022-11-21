namespace Exercicio3
{
  public class Program
  {
    public static void Main(string[] args)
    {
      /*Instanciando a classe que informará os números primos.
        Ela recebe um inteiro que determina até onde será feita
        a verificação.
        Os dois últimos dígitos do meu RU são 1 e 8 */
      var primosThread = new PrimosThread(18);
    }
  }
}