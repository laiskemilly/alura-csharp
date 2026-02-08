Console.Write("Informe seu nome: ");
string usuario = Console.ReadLine()!;

string admin = "LAIS";

if (usuario.ToUpper() == admin)
{
    Console.WriteLine($"Bem vindo (a), {admin}");
} else
{
    Console.WriteLine("Usuário não cadastrado\n");
    Console.WriteLine("OPÇÕES DISPONÍVEIS: ");
    Console.WriteLine("1 - CADASTRAR NOVO USUÁRIO");
    Console.WriteLine("2 - ACESSAR COMO CONVIDADO");
    Console.WriteLine("3 - SAIR");
    Console.Write("\nDigite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"\nUsuário {usuario} cadastrado com sucesso!");
            break;
        case 2:
            Console.WriteLine($"\nAcesso concedido como convidado! Olá {usuario}");
            break;
        case 3:
            Console.WriteLine("\nEncerrando o sistema...");
            break;
        default:
            Console.WriteLine("\nOpção inválida");
            break;
    }   

}