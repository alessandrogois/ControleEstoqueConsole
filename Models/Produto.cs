using System.Diagnostics.Contracts;

namespace ControleEstoqueConsole.Models;

public class Produto
{
  public int Id { get; set; }
  public string Nome { get; set; } = "";

  public string Categoria { get; set; } = "";
  public int Quantidade { get; set; }
  public decimal Preco { get; set; }

  public override string ToString()
  {
    return $"ID: {Id} | Nome {Nome} | Categoria {Categoria} Quantidade: {Quantidade} | Preço: R$ {Preco:F2}";
  }

}