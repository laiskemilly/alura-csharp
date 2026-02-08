Console.Write("Digite o código de recompensa (DOBRAR, CURAR, OURO, ESPECIAL: ");
string codigo = Console.ReadLine()!;

string mensagem = codigo.ToUpper() switch
{
    "DOBRAR" => "Você ganhou 2x EXP por 1 hora!",
    "CURAR" => "Você ganhou 1 POÇÃO DE CURA!",
    "OURO" => "Você ganhou 1000 moedas de ouro!",
    "ESPECIAL" => "Você ganhou 1 ITEM LENDÁRIO!",
    _ => "Recompensa indisponível"
};

Console.WriteLine(mensagem);