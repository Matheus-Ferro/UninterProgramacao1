namespace Programação_I.Aula1
{
  /*
    Observe que cada item do Enum possui implicitamente um valor inteiro por definição. Seguindo
    a ordem que foi declarado, ou seja, o item “Cima” possui o valor “0”, o item “Baixo” o valor “1” e
    assim sucessivamente, dessa forma podemos fazer “casting implícito” de um Enum para um Int.
  */
  /*
    E observe
    outro caso muito comum de uso dos Enum, o bloco Switch/Case, isso pois o Enum nos permite uma
    excelente legibilidade das opções dentro de um Switch/Case, sendo na maioria vezes muito mais
    interessante que blocos if/else para essas estruturas.
  */
  public enum Direcoes
  {
    Cima,
    Baixo,
    Esquerda,
    Direita
  }
  public enum Direcoes_1
  {
    Cima = 1,
    Baixo = 10,
    Esquerda = 20,
    Direita = 67
  }
  public class Exemploenum
  {
    public void MetodoExemploEnum()
    {
      var direcaoCima = Direcoes_1.Cima;
      if ((int)direcaoCima > 20)
      {
        return;
      }
      switch (direcaoCima)
      {
        case Direcoes_1.Cima:
          break;
        case Direcoes_1.Baixo:
          break;
        case Direcoes_1.Esquerda:
          break;
        case Direcoes_1.Direita:
          break;
        default:
          break;
      }
    }
  }
}