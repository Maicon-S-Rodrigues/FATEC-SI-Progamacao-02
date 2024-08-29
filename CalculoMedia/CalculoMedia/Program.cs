using System;

namespace CalculoMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float notaUm = 0, notaDois = 0, notaTres = 0, media = 0;

            Console.Write("Digite a primeira Nota: ");
            notaUm = LerNota();

            Console.Write("\nDigite a segunda Nota: ");
            notaDois = LerNota();

            Console.Write("\nDigite a terceira Nota: ");
            notaTres = LerNota();

            media = CalcularMedia(notaUm, notaDois, notaTres);

            InformarResultado(media);
        }

        private static float LerNota()
        {
            bool ok = false;
            float nota = 0;

            do
            {
                try
                {
                    nota = float.Parse(Console.ReadLine());
                    
                    if (nota >= 0 && nota <= 10) 
                    {
                        ok = true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nValor inválido!\nInforme um valor entre 0 e 10!\n");
                }
            } while (ok != true);

            return nota;
        }

        private static float CalcularMedia(
            float notaUm,
            float notaDois, 
            float notaTres
        ) =>
            (notaUm + notaDois + notaTres) / 3;
        

        private static void InformarResultado(float media)
        {
            if (media < 3) 
            {
                Console.WriteLine("Reprovado, com Media: " + media);
            }
            else if (media < 6)
            {
                Console.WriteLine("Exame, com Media: " + media);
            }
            else
            {
                Console.WriteLine("Aprovado, com Media: " + media);
            }

            Console.ReadKey();
        }
    }
}