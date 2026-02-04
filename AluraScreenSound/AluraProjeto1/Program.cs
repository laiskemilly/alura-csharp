// Screen Sound ALURA

string mensagemBoasVindas = "Bem vindos ao Screen Sound - ALURA";
//List<string> listaBandas = new List<string> { "U2", "The Beatles", "Nirvana"};  

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("The Beatles", new List<int> { 10, 9, 8 });
bandasRegistradas.Add("Nirvana", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄   ▄▄   ▄▀█ █░░ █░█ █▀█ ▄▀█
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀   ░░   █▀█ █▄▄ █▄█ █▀▄ █▀█
");
    Console.WriteLine(mensagemBoasVindas);
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a opção escolhida:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistroBanda();
            break;
        case 2:
            ExibirBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            MediaNotasBanda();
            break;
        case -1:
            Console.WriteLine("\nEncerrando o programa...");
            break;
        default:
            Console.WriteLine("\nOpção inválida");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirMenu();
            break;
    }
}
void RegistroBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite a banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void ExibirBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo as bandas registradas");

    // for (int i = 0; i < listaBandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {listaBandas[i]}");
    // }

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu");;
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asterisco);
    Console.WriteLine(titulo);
    Console.WriteLine(asterisco + "\n");
}
void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avalie uma banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"\nDigite uma nota de 1 a 10 para a banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }else
    {
        Console.WriteLine($"\nA {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

void MediaNotasBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média das notas de uma banda");
    Console.Write("\nDigite o nome da banda que deseja exibir a média das notas: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
       List<int> media = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A média de notas da banda {nomeDaBanda} é {media.Average()}.");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    } else
    {
        Console.WriteLine($"\nA {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

ExibirMenu();