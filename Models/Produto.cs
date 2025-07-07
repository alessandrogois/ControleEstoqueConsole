using System.Diagnostics.Contracts;

namespace ControleEstoqueConsole.Models;

public class Produto
{
  public int Id { get; set; }
  public string Nome { get; set; }
  public int Quantidade { get; set; }
  public decimal Preco { get; set; }

  public override string ToString()
  {
    return $"ID: {Id} | Mome {Nome} | Quantidade: {Quantidade} | Preço: R$ {Preco: F2}";
  }

}