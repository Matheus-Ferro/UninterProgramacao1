public class ModificadoresAcesso
{
  // Torna a variável "quantidade" privada, ou seja, de leitura e escrita exclusiva da classe "ModificadoresAcesso"
  private int quantidade;

  // Isso limita o set para que apenas a classe "ModificadoresAcesso" possa alterar seu valor, enquanto o get fica público.
  // É como ter um método público de get e outro privado de set
  // Muito útil para expor o valor de um campo mas limitar seu acesso a escrita à outras classes
  public bool SetPrivado { get; private set; }

  // Torna a variável "nome" pública, ou seja, de leitura e escrita aberta a todas as classes.
  public string? nome;

  // Deixa a propriedade idade visível e alterável apenas a suas subclasses
  protected int Idade { get; set; }

  // Limita o acesso a todas as classes e tipos que herdem desta classe.
  protected internal int RecuperarPeso()
  {
    return 10;
  }

  // Limita o acesso apenas a classe "ModificadoresAcesso"
  private void CalcularPeso()
  {
    // Inicializa uma classe interna aninhada com a classe "ModificadoresAcesso"
    ClasseInterna objeto = new ClasseInterna();

    // Chama um método com visibilidade interna
    objeto.Calcular();

    // Não podemos executar a linha abaixo, pois isso geraria um erro de compilação.
    // A variável quantidadeInterna pertence apenas à "ClasseInterna", pois está com visibilidade private
    // objeto.quantidadeInterna = 1;
  }

  internal class ClasseInterna
  {
    private int quantidadeInterna;

    // Método com visibilidade interna apenas
    internal void Calcular()
    {

    }
  }

}