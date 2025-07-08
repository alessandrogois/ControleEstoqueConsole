using System.ComponentModel;
using ControleEstoqueConsole.Data;
using ControleEstoqueConsole.Models;

namespace ControleEstoqueConsole.Services;

public class EstoqueService
{
  private List<Produto> _produtos = new();
  private int _proximoId;

  public EstoqueService()
  {
    _produtos = BancoDeDados.Carregar();
    _proximoId = (_produtos.Count == 0) ? 1 : _produtos.Max(p => p.Id) + 1;
  }

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
    BancoDeDados.Salvar(_produtos);
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
  public void AtualizarQuantidade(int id, int novaQuantidade)
  {
    var produto = _produtos.FirstOrDefault(p => p.Id == id);
    if (produto == null)
    {
      Console.WriteLine("Produto não encontrado.");
      return;
    }

    produto.Quantidade = novaQuantidade;
    BancoDeDados.Salvar(_produtos);
    Console.WriteLine("Qunatidade atualizada!");

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
    BancoDeDados.Salvar(_produtos);
    Console.WriteLine("Produto removido.");
  }

  public void BuscarPorNome(string termo)
  {
    var encontrados = _produtos
    .Where(p => p.Nome.ToLower().Contains(termo.ToLower()))
    .ToList();

    if (encontrados.Count == 0)
    {
      Console.WriteLine("Nenhum produto encontrado com esse nome.");
    }
    foreach (var p in encontrados)
    {
      Console.WriteLine(p);
    }

  }
}