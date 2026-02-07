Console.Write("Digite o valor de milhas:");
double milhas = double.Parse(Console.ReadLine()!);
double quilometros = milhas * 1.60934;

Console.WriteLine($"{milhas} milhas equivalem a {quilometros} quilômetros.");