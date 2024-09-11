using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Questao_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoXml = "dados.xml"; 

            try
            {
                XDocument doc = XDocument.Load(caminhoXml);

                var rows = doc.Descendants("row");

                var faturamento = rows.Select(row => new
                {
                    Dia = (int)row.Element("dia"),
                    Valor = (double)row.Element("valor")
                })
                .Where(x => x.Valor > 0) 
                .ToList();

                double menor = faturamento.Min(x => x.Valor);
                double maior = faturamento.Max(x => x.Valor);
                double media = faturamento.Average(x => x.Valor);

                int dias_acima_da_media = faturamento.Count(x => x.Valor > media);

                Console.WriteLine($"Menor valor de faturamento: {menor:C}");
                Console.WriteLine($"Maior valor de faturamento: {maior:C}");
                Console.WriteLine($"Acima da média: {dias_acima_da_media} dias");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar o arquivo XML: {ex.Message}");
            }
        }
    }
}