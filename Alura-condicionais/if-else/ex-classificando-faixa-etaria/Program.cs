Console.Write("Informe a idade: ");
int idade = int.Parse(Console.ReadLine()!);

if (idade > 0 && idade <= 12)
{
    Console.WriteLine("\nClassificação: INFANTIL");
} else if (idade >= 13 && idade <= 17)
{
    Console.WriteLine("\nClassificação: ADOLESCENTE");
} else if (idade >= 18 && idade <= 59)
{
    Console.WriteLine("\nClassificação: ADULTO");
} else 
{
    Console.WriteLine("\nClassificação: IDOSO");
}