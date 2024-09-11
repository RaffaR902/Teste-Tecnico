using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe um número:");
        int numero = int.Parse(Console.ReadLine());

        if (Fibonacci(numero))
        {
            Console.WriteLine("O número informado pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine("O número informado não pertence à sequência de Fibonacci.");
        }
    }

    static bool Fibonacci(int numero)
    {
        if (numero == 0 || numero == 1) 
        {
            return true;
        }

        int a = 0;
        int b = 1;
        int soma = a + b;

        while (soma <= numero)
        {
            if (soma == numero) 
            {
                return true;
            }

            a = b;
            b = soma;
            soma = a + b;
        }

        return false;
    }
}