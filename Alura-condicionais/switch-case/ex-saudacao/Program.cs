Console.WriteLine("SAUDAÇÃO PERSONALIZADA\n");
Console.Write("Informe o seu nome: ");
string usuario = Console.ReadLine()!;

Console.WriteLine("\nMOMENTO DO DIA");
Console.WriteLine("1 - MANHÃ");
Console.WriteLine("2 - TARDE");
Console.WriteLine("3 - NOITE");

Console.Write("Informe o momento do dia: ");
int opcao = int.Parse(Console.ReadLine()!);

switch (opcao)
{
    case 1 :
        Console.WriteLine($"\nBom dia, {usuario}!");
        break;
    case 2:
        Console.WriteLine($"\nBoa tarde, {usuario}!");
        break;
    case 3 :
        Console.WriteLine($"\nBoa noite, {usuario}!");
        break;
    default:
        Console.WriteLine("\nOpção inválida");
        break;
}