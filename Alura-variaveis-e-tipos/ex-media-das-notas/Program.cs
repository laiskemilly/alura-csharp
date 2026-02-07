Console.Write("Digite a primeira nota: ");
float nota1 = float.Parse(Console.ReadLine()!);

Console.Write("Digite a segunda nota: ");
float nota2 = float.Parse(Console.ReadLine()!);

Console.Write("Digite a terceira nota: ");
float nota3 = float.Parse(Console.ReadLine()!);

float media = (nota1 + nota2 + nota3) / 3;
Console.WriteLine($"A média das notas é: {media}");