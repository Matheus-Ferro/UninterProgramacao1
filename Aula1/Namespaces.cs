// Usamos "using" para acessar qualquer classe daquele nível de namespace sem declarar seu caminho completo.
using BibliotecaComum.DAL;

// Um namespace pode ter várias classes, essa é a função dele, organizar as classes dentro dentro de uma "pasta".
// Dessa forma a estrutura do sistema fica em níveis de organização.
namespace Programação_I.Aula1
{
  
  public class ClasseExemplo
  {
    SubDir.Item item = new SubDir.Item();
  }
  public class ClasseExemplo2
  {
    ClasseExemplo3 exemplo3 = new ClasseExemplo3();
  }
  public class ClasseExemplo3
  {
    ClasseExemplo exemplo1 = new ClasseExemplo();
  }
}

namespace Programação_I.Aula1.SubDir
{
  public class Item
  {
    ClasseExemplo3 exemplo3 = new ClasseExemplo3();
    BibliotecaComum.DAL.Comum.Repositorio Repositorio = new BibliotecaComum.DAL.Comum.Repositorio();
    RepositorioConfiguracao configuracao = new RepositorioConfiguracao();
  }
}

namespace BibliotecaComum.DAL.Comum
{
  public class Repositorio
  {

  }
}
namespace BibliotecaComum.DAL
{
  public class RepositorioConfiguracao
  {

  }
}
