Console.Write("Digite o ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine()!);

Console.Write("Digite o ano atual: ");
int ano_Atual = int.Parse(Console.ReadLine()!);

int idade = (ano_Atual - anoNascimento);

Console.WriteLine($"A idade do usuário é {idade} anos.");
