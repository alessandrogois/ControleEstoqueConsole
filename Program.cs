using ControleEstoqueConsole.Services;
using ControleEstoqueConsole.Utils;

EstoqueService estoque = new();

while (true)
{
  Console.WriteLine("\n=== CONTROLE DE ESTOQUE ===");
  Console.WriteLine("1. Adicionar Produto");
  Console.WriteLine("2. Listar Produtos");
  Console.WriteLine("3. Atualizar Quantidade");
  Console.WriteLine("4. Remover Produto");
  Console.WriteLine("5. Buscar produto por nome");
  Console.WriteLine("6. Relatório Financeiro");
  Console.WriteLine("0. Sair");
  Console.Write("Escolha uma opção: ");
  string opcao = Console.ReadLine() ?? "";

  switch (opcao)
  {
    case "1":
      string nome = Entrada.LerTexto("Nome do produto: ");

      int quantidade = Entrada.LerInt("Quantidade: ");

      string categoria = Entrada.LerTexto("Categoria: ");

      decimal preco = Entrada.LerDecimal("Preço: ");

      estoque.AdicionarProduto(nome, categoria, quantidade, preco);
      break;

    case "2":
      estoque.ListarProdutos();
      break;

    case "3":
      Console.Write("ID do produto: ");
      int idAtualizar = int.Parse(Console.ReadLine() ?? "0");

      Console.Write("Nova Quantidade: ");
      int novaQtd = int.Parse(Console.ReadLine() ?? "0");

      estoque.AtualizarQuantidade(idAtualizar, novaQtd);
      break;

    case "4":
      Console.Write("ID do produto: ");
      int idRemover = int.Parse(Console.ReadLine() ?? "0");

      estoque.RemoverProduto(idRemover);
      break;

    case "5":
      Console.Write("Digite parte do nome para buscar:  ");
      string termoBusca = Console.ReadLine() ?? "";
      estoque.BuscarPorNome(termoBusca);
      break;

    case "6":
      estoque.GerarRelatorioFinanceiro();
      break;

    case "0":
      Console.WriteLine("Saindo...");
      return;

    default:
      Console.WriteLine("Opção inválida. Tnte novamente.");
      break;

  }
}