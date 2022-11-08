class Pessoa3
{
  string? nomeCompleto;
  public string NomeCompleto
  {
    get
    {
      return nomeCompleto;
    }
    set
    {
      if (value.Contains(" "))
      {
        nomeCompleto = value.Replace(" ", "-");
        return;
      }
      nomeCompleto = value;
    }
  }

}
