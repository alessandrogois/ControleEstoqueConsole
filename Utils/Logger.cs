using System;

namespace ControleEstoqueConsole.Utils;

public static class Logger
{
  private const string Caminholog = "log.txt";

  public static void Registrar(string mensagem)
  {
    string log = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}]{mensagem};";
    File.AppendAllText(Caminholog, log + Environment.NewLine);

  }

}