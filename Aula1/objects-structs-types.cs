using System;

namespace Programação_I.Aula1
{
  /* 
    Nossa classe abstrata mãe. A herança é redundante, ou seja, todas as classes herdam de System.Object,
    mesmo não declarando explicitamente.
  */
  public abstract class ClasseMae : System.Object
  {
    // Propriedade com protected (Visível a todas as subclasses)
    protected long Quantidade { get; set; }

    // Construtor
    public ClasseMae(long qtd)
    {
      Quantidade = qtd;
    }

    // Método abstrato
    public abstract void MetodoAbstrato(string nome, string sobrenome);

    // Método estático (Não requer inicialização)
    public static long CalcularTicks(int valor)
    {
      return DateTime.Now.Ticks * valor;
    }
  }

  /* 
    Classe filha. Repare no "sealed", que significa que a classe não pode ser herdada ou modificada. Este é
    um tipo de modificador de acesso especial de classes. Observe que ela HERDA da ClasseMae e implementa a
    interface ICloneable.
  */
  public sealed class MinhaClasseCompleta : ClasseMae, ICloneable
  {
    // Propriedade Privada
    private string? Nome { get; set; }

    // Campo/Field auxiliar interno (privado)
    string nomeCompletoAuxiliar;

    /*
      Repare que o construtor recebe um valor inteiro e chama o construtor da classe mãe usando uma referência
      "base" passada cini oarâmetro o valor para um método estático (que não requer que a classe esteja inicializada
      para executar), passando como retorno deste método o valor para o construtor.
    */
    public MinhaClasseCompleta(int qtd) : base(MinhaClasseCompleta.CalcularTicks(qtd))
    {
      // Inicialização de campos e propriedades
      nomeCompletoAuxiliar = string.Empty;
      Nome = nomeCompletoAuxiliar;
    }

    // Método publico da interface
    public object Clone()
    {
      return MemberwiseClone();
    }

    // Implementação do método abstrato
    public override void MetodoAbstrato(string nome, string sobrenome)
    {
      nomeCompletoAuxiliar = string.Join(" ", nome, sobrenome);
      Nome = nomeCompletoAuxiliar;
    }

    // Destrutor/Finalizador da classe
    ~MinhaClasseCompleta()
    {
      Nome = null;
    }
  }
}
