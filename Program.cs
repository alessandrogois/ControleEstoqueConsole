using ControleEstoqueConsole.Services;

EstoqueService estoque = new();

while (true)
{
  Console.WriteLine("\n=== CONTROLE DE ESTOQUE ===");
  Console.WriteLine("1. Adicionar Produto");
  Console.WriteLine("2. Listar Produtos");
  Console.WriteLine("3. Atualizar Quantidade");
  Console.WriteLine("4. Remover Produto");
  Console.WriteLine("5. Buscar produto por nome");
  Console.WriteLine("0. Sair");
  Console.Write("Escolha uma opção: ");
  string opcao = Console.ReadLine() ?? "";

  switch (opcao)
  {
    case "1":
      Console.Write("Nome do produto: ");
      string nome = Console.ReadLine() ?? "";

      Console.Write("Quantidade: ");
      int quantidade = int.Parse(Console.ReadLine() ?? "0");

      Console.Write("Preço: ");
      decimal preco = decimal.Parse(Console.ReadLine() ?? "0");

      estoque.AdicionarProduto(nome, quantidade, preco);
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

    case "0":
      Console.WriteLine("Saindo...");
      return;

    default:
      Console.WriteLine("Opção inválida. Tnte novamente.");
      break;

  }
}