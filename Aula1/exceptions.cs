namespace Programação_I.Aula1
{
  public class Try_catch
  {
    public Try_catch()
    {
      try
      {
        //ao executarmos o trecho de código abaixo vamos ver que o C# irá lançar
        //uma exception do tipo: System.FormartException
        //pois o parâmetro "texto" não está no formato esperado pelo método Parse da classe int
        var texto = "uma string qualquer";
        int i = int.Parse(texto);

        //outros códigos quaisquer....
        //..
        //..
        i = i + 10;
      }
      catch (FormatException formatEx)
      {
        //a CLR irá abortar a execução do bloco acima e o trecho: i= i+10 nunca será executado
        //o objeto formatEx terá a mensagem e detalhes do erro
        Console.WriteLine(formatEx.Message);

        //podemos "relançar a exception" para outro bloco ou método superior ao nosso, usando a palavra: throw
        //a palavra reservada throw é responsável por avisar o C# que uma exceção será lançada.
        //Observe abaixo que temos uma exceção nova sendo criada, usando a mensagem da exeção formartEx como parâmetro
        throw new Exception(formatEx.Message);
      }
      catch (ArgumentException argEx)
      {
        Console.WriteLine(argEx);
      }
      catch (Exception ex)
      {
        //ao final o código irá cair aqui
        //O type (classe) base de todas as exceções é a "System.Exception"
        //todas as demais exceções herdam dela

        //Você pode ter quantos catch`s quiser em seu bloco try/catch
        //contanto que as exceções estejam em ordem de prevalência (herança), ou seja,
        //as classes filhas acima das classes pai (exceções)
        //como é o caso da FormartException e ArgumentException acima, que herda da classe Exception

        Console.WriteLine(ex);

        //Também é possível relançar a exceção original
        //o modo correto de fazer isso é simplismente usar a diretiva "throw"
        //dessa forma a StackTrace é mantida e você conseguirá rastrear melhor a fonte original do problema
        //esse é o modo correto de re-lançar exceções, quando você não irá trata-las em seu bloco catch
        //e deixará para outro método/bloco superior ao seu trata-la
        throw;
      }
      finally
      {
        //o bloco finally representa uma instruçao para que SEMPRE
        //seja executado esse trecho de código, independente do
        //bloco TRY gerar um erro. Mesmo que passe por vários catchs
        //o bloco finally representa um bloco que SEMPRE SERÁ EXECUTADO
        //você deve usa-lo para "limpar" alguma variável ou estado 
        //da aplicação e permitir que seja possível seu programa continuar
        //a execução, até re-tetando a execução do seu próprio método
      }
    }
  }
}