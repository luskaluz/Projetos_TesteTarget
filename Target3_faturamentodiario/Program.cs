using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using Target3_faturamentodiario;
class Program
{
    private static void FaturamentoDiario()
    {

        string jsondados = File.ReadAllText("dados.json");
        var dados = JsonConvert.DeserializeObject<List<Faturamento>>(jsondados);
        var fatValido = dados.Where(d => d.valor.HasValue && d.valor.Value > 0).Select(d => d.valor.Value).ToList();

        decimal menorFat = fatValido.Min();
        decimal maiorFat = fatValido.Max();
        Console.WriteLine("Maior faturamento: R$ {0:f2}", maiorFat);
        Console.WriteLine("Menor faturamento: R$ {0:f2}", menorFat);

        decimal media = fatValido.Average();
        Console.WriteLine("Média: R$ {0:f2}", media);

        int diaAcimaMedia = fatValido.Count(f => f > media);
        Console.WriteLine("Dias com faturamento acima da média: " + diaAcimaMedia);

    }
    
    private static void Main(string[] args)
    {
        FaturamentoDiario();
    }
}