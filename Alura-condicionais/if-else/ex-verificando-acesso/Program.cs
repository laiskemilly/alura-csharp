Console.Write("Informe a senha: ");
int password = int.Parse(Console.ReadLine()!);

Console.Write("Informe o nível de acesso: ");
int acesso =  int.Parse(Console.ReadLine()!);

if (password == 42 && acesso >= 5)
{
    Console.WriteLine("\nACESSO LIBERADO");
} else
{
    Console.WriteLine("\nACESSO NEGAGO");
}