Console.Write("Digite o código do livro: ");
int codigo = int.Parse(Console.ReadLine()!);

switch (codigo / 100 ){
    case 1:
        Console.WriteLine("\nFICÇÃO CIENTÍFICA");
        break;
      case 2:
        Console.WriteLine("\nLITERATURA CLÁSSICA");
        break;
      case 3:
        Console.WriteLine("\nFANTASIA");
        break;
      case 4:
        Console.WriteLine("\nROMANCE");
        break;
      case 5:
        Console.WriteLine("\nSUSPENSE/MISTÉRIO");
        break;
      case 6:
        Console.WriteLine("\nNÃO FICÇÃO");
        break;
      case 7:
        Console.WriteLine("\nBIOGRAFIAS/MEMÓRIAS");
        break;
      case 8:
        Console.WriteLine("\nDISTOPIA");
        break;
      case 9:
        Console.WriteLine("\nINFANTO JUVENIL");
        break;
    default:
        Console.WriteLine("\nCÓDIGO INEXISTENTE");
        break;
}