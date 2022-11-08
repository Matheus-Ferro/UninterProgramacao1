class Pessoa1
{
  /* Parâmetros, variáveis locais e campos privados (private fields) devem ser escritos utilizando-se a notação camel case.
     Por exemplo, “minhaVariavel”.
     Demais identificadores, como classes, métodos, propriedades, namespaces, tipos, atributos etc. devem ser escritos
     utilizando-se a notação pascal case. Por exemplo, “MinhaPropriedade”.
  */
  /* A variável nome pode ser descrita como um field, pois é uma variável local, pertencente somente ao contexto da classe.
     O sinal de interrogação depois do tipo indica que a variável pode ser nulável, ou seja, pode ficar sem um valor atribuido,
     sendo assim uma variável nula.
  */
  string? nome;
  // A variável idade é uma propriedade contendo getters and setters nativos.
  int Idade { get; set; }
  // Pode andar é um método que retorna um booleano.
  bool PodeAndar() { return true; }
}

class Pessoa2
{
  string? Nome { get; set; }
  int idade;
  void SetIdade(int idadeDesejada)
  {
    idade = idadeDesejada;
  }
  int GetIdade()
  {
    return idade;
  }
}
