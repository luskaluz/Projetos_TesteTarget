class Program
{
    private static void FaturamentoMensal()
    {
        var faturamentos = new List<(string estado, decimal faturamento)>
        {
            ("SP", 67836.43m),
            ("RJ", 36678.66m),
            ("MG", 29229.88m),
            ("ES", 27165.48m),
            ("Outros", 19849.53m)
        };

        decimal total = 0;
        foreach (var fat in faturamentos)
        {
            total += fat.faturamento;
        }

        foreach (var item in faturamentos)
        {
            string estado = item.estado;
            decimal faturamentoEstado = item.faturamento;

            decimal percentual = (faturamentoEstado / total) * 100;

            Console.WriteLine($"{estado}: {percentual:f2}%");
        }

    }

    private static void Main(string [] args)
    {
        FaturamentoMensal();
    }
}