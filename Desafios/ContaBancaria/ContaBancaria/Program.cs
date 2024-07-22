DadosConta conta1 = new DadosConta();
conta1.titular = "Maria dos Anjos";
conta1.numeroConta = 11241;
conta1.numeroIndicador = 8;
conta1.senha = "MinhaSenha";
conta1.saldo = 10.25;

void ExibirLogo()
{
    Console.WriteLine(@"
█▀▄▀█ █▄█ ▄▄ █▀▄▀█ █▀█ █▄░█ █▀▀ █▄█
█░▀░█ ░█░ ░░ █░▀░█ █▄█ █░▀█ ██▄ ░█░░");

}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nSelecione a opção desejada: ");
    Console.WriteLine("1 - Verificar meu saldo.");
    Console.WriteLine("2 - Trocar minha senha.");
    Console.WriteLine("99 - Sair\n");

    int opcaoSelecionada  = int.Parse(Console.ReadLine())!;
    switch (opcaoSelecionada)
    {
        case 1:
            Console.WriteLine("");
            break;
        case 2:
            Console.WriteLine("");
            break;
        case 99:
            Console.WriteLine("\nAté mais :)");
            break;
        default:
            Console.WriteLine("\nOpção Selecionada inválida!");
            Thread.Sleep(1500);
            Console.Clear();
            ExibirMenu();
            break;
    }
}

ExibirMenu();