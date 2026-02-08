Console.Write("Digite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Digite o segundo número: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("\n1 - SOMAR");
Console.WriteLine("2 - SUBTRAIR");
Console.WriteLine("3 - MULTIPLICAR");
Console.WriteLine("4 - DIVIDIR");

Console.Write("\nDigite a opção desejada: ");
int opcao = int.Parse(Console.ReadLine()!);

switch (opcao)
{
    case 1: 
        int sum = num1 + num2;
        Console.WriteLine($"\nResultado = {sum}");
        break;
    case 2:
        int sub = num1 - num2;
        Console.WriteLine($"\nResultado = {sub}");
        break;
    case 3: 
        int multiplicar = num1 * num2;
        Console.WriteLine($"\nResultado = {multiplicar}");
        break;
    case 4:
        int div = num1 / num2;
        Console.WriteLine($"\nResultado = {div}");
        break;
    default:
        Console.WriteLine("\nOperação inválida");
        break;
}       

