Account account = new Account();
account.id = 1;
account.holder = "Lais";
account.balance = 1000000;
account.password = 9999;

Console.WriteLine("INFORMAÇÕES DA CONTA:");
Console.WriteLine($"Titular: {account.holder}");
Console.WriteLine($"Saldo: {account.balance}");