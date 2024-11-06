class Program
{
    //1
    private static int Soma()
    {
        int indice = 13, soma = 0, k = 0;

        while (k < indice)
        {
            k = k + 1;
            soma = soma + k;
        }

        return soma;

        //Resultado = 91
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Soma: " + Soma());
    }
}
