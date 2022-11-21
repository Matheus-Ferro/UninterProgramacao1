namespace Exercicio2
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Instanciando a classe produto
      Produto produto1 = new Produto("TV", 900.00, 10);

      // Adicionando 8 unidades conforme o enunciado (ultimo numero do RU)
      produto1.AdicionarProduto(8);
      produto1.RemoverProduto(3);

      produto1.ExibirEstoque();

      produto1.AdicionarProduto(9);
      produto1.RemoverProduto(6);

      produto1.ExibirEstoque();
    }
  }
}
