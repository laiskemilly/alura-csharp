// Número Secreto C#

Random numeroAleatorio = new Random();
int numeroSecreto = numeroAleatorio.Next(1, 101);

do
{
    Console.Write("\nDigite o número secreto entre 1 e 100: ");
    int numeroEscolhido = int.Parse(Console.ReadLine()!);

    if (numeroEscolhido == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número secreto :)");
        break;
    } else if (numeroEscolhido < numeroSecreto)
    {
        Console.WriteLine("Quase! O número secreto é maior.");
    } else {
        Console.WriteLine("Quase! O número secreto é menor.");
    }
} while (true);

Console.WriteLine("\nO jogo acabou.");