Console.WriteLine("Digite 1 para produto PERECÍVEL");
Console.WriteLine("Digite 2 para produto NÃO PERECÍVEL");

Console.Write("\nDigite o código do produto: ");
int codigo = int.Parse(Console.ReadLine()!);

if  (codigo == 1)
{
    Console.WriteLine("\nPRODUTO PERECÍVEL CADASTRADO");
} else if (codigo == 2)
{
    Console.WriteLine("\nPRODUTO NÃO PERECÍVEL CADASTRADO");
} else
{
    Console.WriteLine("\nCÓDIGO INVÁLIDO");
}