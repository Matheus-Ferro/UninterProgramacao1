namespace Exercicio1
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine($"----------Bhaskara----------");

      // Coleta dos dados e armazenamento nas variáveis
      Console.WriteLine($"Informe a: ");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine($"Informe b: ");
      int b = int.Parse(Console.ReadLine());
      Console.WriteLine($"Informe c: ");
      int c = int.Parse(Console.ReadLine());

      // Calculo do delta e das raízes
      int delta = b * b - 4 * a * c;
      if (a == 0 || delta < 0)
      {
        Console.WriteLine($"Impossível Calcular");
      }
      else
      {
        int x1 = (int)(-b + Math.Sqrt(delta));
        int x2 = (int)(b - Math.Sqrt(delta));
        Console.WriteLine($"Delta= {delta}\nx1= {x1}\nx2= {x2}");
      }
    }
  }
}

