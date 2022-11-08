/*
  Uma interface é como uma classe, porém, apenas descreve comportamentos, ou seja, métodos e
  propriedades. Ela não pode implementar nenhum desses, apenas declará-los. Seu objetivo é
  descrever comportamentos comuns, para que classes que implementam a interface possam utilizar o
  conceito de abstração da orientação a objetos.
*/
/*
  É uma convenção no C# usarmos a leta “I” maiúscula na frente do nome da interface para
  diferenciá-la de uma classe. Outra convenção é o uso do sufixo “able/iable” em inglês. Esse sufixo é
  utilizado para dar sentido de que é uma ação possível de ser feita, como Acesso -> Acessivel ou
  Vestimenta -> Vestivel. Em português nem sempre encontramos boas traduções literais para essas
  palavras. O mais importante ao declarar uma interface é que ela reflita um comportamento, e não
  uma ação ou um substantivo.
*/
interface IComestivel
{
  void Mastigar(object comida);
  int MaximoComida { get; }
  string Descrever()
  {
    return "Possibilita o comportamento de mastigar um alimento";
  }
}

/*
  No C# uma classe pode implementar quantas interfaces desejar. Devemos ler isso como
  “uma classe pode implementar quantos comportamentos desejar”.
*/
abstract class Animal : IComestivel
{
  public int MaximoComida => 10;

  /*
    Observe no exemplo que a classe Animal declara o método Mastigar como “abstract” e
    assim não precisa implementá-lo. Deixando a implementação concreta deste método para
    outras classes que herdem dela.
  */
  public abstract void Mastigar(object comida);
}

/*
Note que, ao implementar a interface, você é obrigado a implementar os métodos e propriedades
declaradas na interface. Observe que a classe cachorro herda de animal e ainda implementa outra
interface, a IConeable. Essa interface define o comportamento de um objeto poder se clonar;
Obriga sua classe a implementar o método “Clone”.
*/
class Cachorro : Animal, ICloneable
{
  public object Clone()
  {
    return this.MemberwiseClone();
  }
  public override void Mastigar(object comida)
  {
  }
}

class PetShop
{
  public void Teste()
  {
    Cachorro cachorro = new Cachorro();

    cachorro.Clone();
    cachorro.Mastigar(new object());
    int maximo = cachorro.MaximoComida;
  }
}
