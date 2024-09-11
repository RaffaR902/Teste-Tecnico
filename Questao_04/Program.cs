using System;

class Program
{
    static void Main(string[] args)
    {
        var faturamento_por_estado = new Dictionary<string, double>
        {
                {"SP", 67836.43},
                {"RJ", 36678.66},
                {"MG", 29229.88},
                {"ES", 27165.48},
                {"Outros", 19849.53}
        };

        double faturamento_total = faturamento_por_estado.Values.Sum();

        foreach (var estado in faturamento_por_estado)
        {
            double percentual = (estado.Value / faturamento_total) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }
}