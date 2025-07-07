using System.ComponentModel;
using ControleEstoqueConsole.Models;

namespace ControleEstoqueConsole.Services;

public class EstoqueService
{
  private List<Produto> _produtos = new();
  private int _proximoId = 1;

  public void AdicionarProduto(string nome, int qunatidade, decimal preco)
  {
    var produto = new Produto
    {
      Id = _proximoId++,
      Nome = nome,
      Quantidade = qunatidade,
      Preco = preco
    };

    _produtos.Add(produto);
    Console.WriteLine("Produto adicionado com sucesso!");
  }

  public void ListarProdutos()
  {
    if (_produtos.Count == 0)
    {
      Console.WriteLine("Nenhum produto cadastrado.");
      return;
    }

    foreach (var p in _produtos)
    {
      Console.WriteLine(p);
    }
  }
  public void AtualizarQuantidade(int id, int NovaQuantidade)
  {
    var produto = _produtos.FirstOrDefault(p => p.Id == id);
    if (produto == null)
    {
      Console.WriteLine("Produto não encontrado.");
      return;
    }

    _produtos.Remove(produto);
    Console.WriteLine("Produto removido.");

  }

  public void RemoverProduto(int id)
  {
    var produto = _produtos.FirstOrDefault(p => p.Id == id);
    if (produto == null)
    {
      Console.WriteLine("Produto não encontrado.");
      return;
    }

    _produtos.Remove(produto);
    Console.WriteLine("Produto removido.");
  }
}