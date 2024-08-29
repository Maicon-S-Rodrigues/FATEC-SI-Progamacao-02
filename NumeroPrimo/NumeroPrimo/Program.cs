using System;

namespace NumeroPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            bool primo = false;

            Console.WriteLine("Digite um numero: ");
            numero = LerNumero();

            primo = IsPrimo(numero);

            switch (primo)
            {
                case true:
                    Console.WriteLine($"O numero {numero} é Primo!");
                    break;

                case false:
                    Console.WriteLine($"O numero {numero} não é Primo!");
                    break;
            }

            Console.ReadKey();
        }

        private static bool IsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static int LerNumero()
        {
            bool ok = false;
            int numero = 0;

            do
            {
                try
                {
                    numero = int.Parse(Console.ReadLine());

                    if (numero == 1)
                    {
                        Console.WriteLine("\nO numero 1 não é Primo!\nInforme outro...\n");         
                    }
                    else
                    {
                        ok = true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nValor inválido!\nInforme um numero inteiro!\n");
                }
            } while (ok != true);

            return numero;
        }
    }
}