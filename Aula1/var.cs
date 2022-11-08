/*
  O var permite que você abstraia parte da declaração de variáveis para simplificar a escrita. Não
  produz nenhuma alteração de performance na aplicação ou mesmo de modo como as variáveis se
  comportam. Essa palavra-chave existe para facilitar a vida do desenvolvedor com tipos que são muito
  extensos.
*/
public class TesteVar
{
  public void Metodo1()
  {
    // Declaração sem usar o var
    Dictionary<string, string> dicionario = new Dictionary<string, string>();

    // Declaração usando o var
    var dicionarioComVar = new Dictionary<string,string>();
    if(dicionario.GetType() == dicionarioComVar.GetType()){
      Console.WriteLine($"Dicionário com var: C# Rocks!");
      
    }
  }
}