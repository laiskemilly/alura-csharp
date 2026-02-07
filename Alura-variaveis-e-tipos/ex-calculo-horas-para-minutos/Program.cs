Console.Write("Digite o tempo em minutos: ");
int minutos = int.Parse(Console.ReadLine()!);

int horas = (minutos / 60);
int minutosRestantes =  (minutos % 60);

Console.WriteLine($"Tempo: {horas} horas e {minutosRestantes} minutos.");