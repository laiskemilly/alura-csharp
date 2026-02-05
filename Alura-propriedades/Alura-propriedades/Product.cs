class Produto()
{
    public string Nome { get; set; }
    public string Marca { get; set; }
    private double valor;
    private int estoque;

    public double Valor
    {
        get => valor;
        set
        {
            if (value > 0)
            {
                valor = value;
            }
            else
            {
                Console.WriteLine("Erro no valor");
            }
        }
    }

    public int Estoque
    {
        get => estoque;
        set
        {
            if (value > 0)
            {
                estoque = value;
            }
            else
            {
                estoque = 0;
            }
        }
    }

    public string InfoProduto => $"INFORMAÇÕES DO PRODUTO \n{this.Nome} {this.Marca} {this.valor}";
}