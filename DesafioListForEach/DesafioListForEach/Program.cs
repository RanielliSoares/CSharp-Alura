void ExibirLogo()
{
    Console.WriteLine(@"
█░░ █ █▀ ▀█▀ ▄▀█   █▀▄ █▀▀   █▀▀ █▀█ █▀▄▀█ █▀█ █▀█ ▄▀█ █▀
█▄▄ █ ▄█ ░█░ █▀█   █▄▀ ██▄   █▄▄ █▄█ █░▀░█ █▀▀ █▀▄ █▀█ ▄█");
}    
void MenuPrincipal()
{
    ExibirLogo();
    Console.WriteLine("\nSelecione a opção desejada");
    Console.WriteLine("1 - Cadastrar um novo Item");
    Console.WriteLine("2 - Exibir lista de compras");
    Console.WriteLine("99 - Sair do programa");
    int opcaoSelecinada = int.Parse(Console.ReadLine());
    switch (opcaoSelecinada)
    {
        case 1:
            CadastrarItem();
            break;
        case 2:
            ExibirListaComprasForEach();
            break;
        case 99:
            Console.WriteLine("Você selecionou sair :)");
            break;
        default:
            Console.WriteLine("Opção selecionada inválida!");
            Thread.Sleep(1000);
            Console.Clear();
            MenuPrincipal();
            break;
    }

}
List<string> comprasFazer = new List<string>();
void CadastrarItem()
{
    Console.Clear();
    Console.WriteLine("**********************");
    Console.WriteLine("Cadastramento de Itens");
    Console.WriteLine("**********************");
    Console.WriteLine("Digite o item que precisa comprar: ");
    string item = Console.ReadLine();
    comprasFazer.Add(item);
    Console.WriteLine($"O item {item} foi adicionado a sua lista de compras ");
    Thread.Sleep(2000);
    Console.Clear();
    MenuPrincipal();
}
void ExibirListaCompras()
{
    Console.Clear();
    Console.WriteLine("************************");
    Console.WriteLine("Lista de Itens a comprar");
    Console.WriteLine("************************");
    for(int i = 0;i < comprasFazer.Count; i++)
    {
        Console.WriteLine($"Item: {comprasFazer[i]}");
    }
    Console.WriteLine("\n O que deseja fazer ?");
    Console.WriteLine("1 - Voltar ao menu principal.");
    Console.WriteLine("2 - Encerrar o programa.");
    int opcaoSelecionada = int.Parse(Console.ReadLine());
    switch (opcaoSelecionada)
    {
        case 1:
            Console.Clear();
            MenuPrincipal();
            break;
        case 2:
            Console.WriteLine("Você selecionou sair :)");
            break;
        default:
            Console.WriteLine("Opção selecionada inválida!");
            Thread.Sleep(1000);
            Console.Clear();
            ExibirListaCompras();
            break;
    }
}
void ExibirListaComprasForEach()
{
    Console.Clear();
    Console.WriteLine("************************");
    Console.WriteLine("Lista de Itens a comprar");
    Console.WriteLine("************************");
    foreach(string item in comprasFazer)
    {
        Console.WriteLine($"Item: {item}");
    }
    Console.WriteLine("\n O que deseja fazer ?");
    Console.WriteLine("1 - Voltar ao menu principal.");
    Console.WriteLine("2 - Encerrar o programa.");
    int opcaoSelecionada = int.Parse(Console.ReadLine());
    switch (opcaoSelecionada)
    {
        case 1:
            Console.Clear();
            MenuPrincipal();
            break;
        case 2:
            Console.WriteLine("Você selecionou sair :)");
            break;
        default:
            Console.WriteLine("Opção selecionada inválida!");
            Thread.Sleep(1000);
            Console.Clear();
            ExibirListaCompras();
            break;
    }
}
MenuPrincipal();