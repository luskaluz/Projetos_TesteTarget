class Program
{
    static string ReverterString(string str)
    {
        string rvString = string.Empty;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            rvString += str[i];
        }

        return rvString;
    }

    public static void Main(string[] args)
    {
        string str = "Bom dia";
        Console.WriteLine(ReverterString(str));
    }
}
