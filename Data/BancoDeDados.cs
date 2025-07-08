using System.Text.Json;
using ControleEstoqueConsole.Models;
using ControleEstoqueConsole.Services;

namespace ControleEstoqueConsole.Data;

public class BancoDeDados
{
  private const string CaminhoArquivo = "estoque.json";

  public static void Salvar(List<Produto> produtos)
  {
    var json = JsonSerializer.Serialize(produtos, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText(CaminhoArquivo, json);
  }


  public static List<Produto> Carregar()
  {
    if (!File.Exists(CaminhoArquivo))
      return new List<Produto>();

    var json = File.ReadAllText(CaminhoArquivo);
    var produtos = JsonSerializer.Deserialize<List<Produto>>(json);

    return produtos ?? new List<Produto>();
  }




}


