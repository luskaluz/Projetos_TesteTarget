class Program
{
    private static bool EstaFibo(int n)
    {
        int a = 0, b = 1;

        if (n == a || n == b)
        {
            return true;
        }
        int fibo = a + b;
        while (fibo <= n)
        {
            if (fibo == n)
                return true;

            a = b;
            b = fibo;
            fibo = a + b;
        }
        return false;
    }

    private static void Main(string[] args)
    {
        int n = 5;
        int error = 4;
        if (EstaFibo(n))
        {
            Console.WriteLine("2. {0} está na sequência", n);
        }
        else
        {
            Console.WriteLine("2. {0} não está na sequência", n);
        }
        if (EstaFibo(error))
        {
            Console.WriteLine("2. {0} está na sequência", error);
        }
        else
        {
            Console.WriteLine("2. {0} não está na sequência", error);
        }
    }
}