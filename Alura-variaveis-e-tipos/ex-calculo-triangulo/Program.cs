
Console.Write("Digite a largura: ");
double largura = double.Parse(Console.ReadLine()!);
Console.Write("Digite o comprimento: ");
double comprimento = double.Parse(Console.ReadLine()!);

double area = largura  * comprimento;
Console.WriteLine($"A área do terreno é {area} metros quadrados");
