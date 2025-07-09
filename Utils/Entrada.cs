namespace ControleEstoqueConsole.Utils;

public static class Entrada
{
  public static int LerInt(string mensagem)
  {
    int valor;
    while (true)
    {
      Console.Write(mensagem);
      string? input = Console.ReadLine();
      if (int.TryParse(input, out valor) && valor >= 0)
        return valor;

      Console.WriteLine("Por favor, digite um número inteiro válido e positivo.");
    }
  }

  public static decimal LerDecimal(string mensagem)
  {
    decimal valor;
    while (true)
    {
      Console.Write(mensagem);
      string? input = Console.ReadLine();
      if (decimal.TryParse(input, out valor) && valor >= 0)
        return valor;

      Console.WriteLine("Por favor, digite um valor decimal válido e positivo.");


    }
  }

  public static string LerTexto(string mensagem)
  {
    while (true)
    {
      Console.Write(mensagem);
      string? input = Console.ReadLine();
      if (!string.IsNullOrWhiteSpace(input))
        return input;

      Console.WriteLine("O campo não pode ser vazio.");
    }
  }
}