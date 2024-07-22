DadosConta conta1 = new DadosConta();
conta1.titular = "Maria dos Anjos";
conta1.numeroConta = 11241;
conta1.numeroIndicador = 8;
conta1.senha = "MinhaSenha";
conta1.saldo = 10.25;

DadosConta conta2 = new DadosConta();
conta2.titular = "José Pereira";
conta2.numeroConta = 11781;
conta2.numeroIndicador = 3;
conta2.senha = "MinhaSenha2";
conta2.saldo = 1000250.25;

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
            ExibirSaldo();
            break;
        case 2:
            ExibirSaldo();
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

void ExibirSaldo()
{
    Console.Clear();
    ExibirLogo();
    Console.Write("\nDigite o número da sua conta sem o digito verificador: ");
    int numeroConta = int.Parse(Console.ReadLine()!);
    if (numeroConta == conta1.numeroConta)
    {
        Console.WriteLine($"\nOlá {conta1.titular}, agora digite sua senha: ");
        string senhaConta = Console.ReadLine()!;
        if (senhaConta == conta1.senha)
        {
            Console.WriteLine($"\n{conta1.titular} seu saldo é: R${conta1.saldo}");
        }
        else
        {
            Console.WriteLine("Senha digitada incorreta, retornando ao menu principal");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirMenu();
        }
    }
    else if (numeroConta == conta2.numeroConta)
    {
        
        Console.WriteLine($"\nOlá {conta2.titular}, agora digite sua senha: ");
        string senhaConta = Console.ReadLine()!;
        if (senhaConta == conta2.senha)
        {
            Console.WriteLine($"\n{conta2.titular} seu saldo é: R${conta2.saldo}");
        }
        else
        {
            Console.WriteLine("\nSenha digitada incorreta, retornando ao menu principal");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirMenu();
        }
    }
    else
    {
        Console.WriteLine("Conta digitada não encontrada! Retornando ao menu principal");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
    }

ExibirMenu();