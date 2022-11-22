namespace Exercicio2
{
  public class Produto
  {
    // Declaração de atributos
    private string Nome;
    private double Preco;
    private int Quantidade;

    // Método construtor
    public Produto(string nome, double preco, int quantidade)
    {
      this.Nome = nome;
      this.Preco = preco;
      this.Quantidade = quantidade;
      Console.WriteLine($"----------PRODUTO CRIADO----------");
      Console.WriteLine($"Produto: {Nome}");
      Console.WriteLine($"Preço Un.: R$ " + String.Format("{0:0.00}", Preco));
      Console.WriteLine($"Quantidade: {Quantidade}");
      Console.WriteLine($"Valor Total: R$ " + String.Format("{0:0.00}", ValorTotalEstoque()));

    }

    // Método que retorna o valor total do produto em estoque
    public double ValorTotalEstoque()
    {
      return Preco * Quantidade;
    }

    // Método que adiciona produtos ao estoque
    public void AdicionarProduto(int quantidade)
    {
      Quantidade += quantidade;
    }

    // Método que remove produtos do estoque
    public void RemoverProduto(int quantidade)
    {
      Quantidade -= quantidade;
    }

    // Método que exibe o histórico atualizado
    public void ExibirEstoque()
    {
      Console.WriteLine($"----------ESTOQUE ATUALIZADO----------");
      Console.WriteLine($"Produto: {Nome}");
      Console.WriteLine($"Preço Un.: R$ " + String.Format("{0:0.00}", Preco));
      Console.WriteLine($"Quantidade: {Quantidade}");
      Console.WriteLine($"Valor Total: R$ " + String.Format("{0:0.00}", ValorTotalEstoque()));
    }
  }
}