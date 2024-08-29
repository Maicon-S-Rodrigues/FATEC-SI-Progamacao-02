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

    private static double CalcularFatorial(
        double numero
    ) =>
        numero == 0 ? 1 
        : numero * CalcularFatorial(numero - 1);

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
