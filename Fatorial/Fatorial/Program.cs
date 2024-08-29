using System;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            double numero = LerNumero();

            double fatorial = CalcularFatorial(numero);

            Console.WriteLine($"{numero}! = {fatorial}");

            Console.ReadKey();
        }

        private static double CalcularFatorial(double numero)
        {
            double fatorial = numero;

            for (double i = numero - 1; i >= 1; i--)
            {
                fatorial *= i;
            }

            return fatorial;
        }

        private static double LerNumero()
        {
            bool ok = false;
            double numero = 0;

            do
            {
                try
                {
                    numero = double.Parse(Console.ReadLine());
                    ok = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nValor inválido!\n");
                }
            } while (ok != true);

            return numero;
        }
    }
}