Console.Write("Digite o valor do saldo: ");
float saldo = float.Parse(Console.ReadLine()!);

if  (saldo == 0)
{
    Console.WriteLine("SALDO INSUFICIENTE");
} else if (saldo < 0)
{
    Console.WriteLine("SALDO NEGATIVO");
}else
{
    Console.WriteLine("SALDO POSITVO");
}