Console.Write("Digite a nota obtida: ");
float nota = float.Parse(Console.ReadLine()!);

if  (nota >= 9)
{
    Console.WriteLine("O aluno recebeu a nota A");
} else if (nota >= 7 &&  nota < 9)
{
    Console.WriteLine("O aluno recebeu a nota B");
} else if (nota >= 5 && nota < 7)
{
    Console.WriteLine("O aluno recebeu a nota C");
} else if (nota < 5)
{
    Console.WriteLine("O aluno recebeu a nota D");
}else
{
    Console.WriteLine("Nota inválida");
}