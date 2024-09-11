using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um texto: ");
        string texto_original = Console.ReadLine();

        string texto_invertido = "";

        for (int i = texto_original.Length - 1; i >= 0; i--)
        {
            texto_invertido += texto_original[i];
        }

        Console.WriteLine("Texto invertido: " + texto_invertido);
    }
}
