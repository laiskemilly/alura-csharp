class Account
{
    public int id;
    public string holder;
    public float balance;
    public int password;

    public void BankAccount()
    {
        Console.WriteLine("INFORMAÇÕES DA CONTA:");
        Console.WriteLine($"Titular: {holder}");
        Console.WriteLine($"Saldo: {balance}");
    }
}
