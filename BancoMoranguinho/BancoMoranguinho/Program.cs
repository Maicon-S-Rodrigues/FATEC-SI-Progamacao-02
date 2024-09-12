using System;

namespace BancoMoranguinho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();

            Menu(conta);

            Console.ReadKey();
        }

        private static void Menu(ContaBancaria conta)
        {
            bool continuar = true;
            decimal valor = 0;
            do
            {
                Console.WriteLine("Escolha sua opção:");
                Console.WriteLine("1 - Depositar\n2 - Sacar\n3 - Ver Saldo\n0 - Sair");
                int opcao = int.Parse(Console.ReadLine());
                
                switch (opcao)
                {
                    case 1:
                        Console.Write("Informe o valor desejado para depositar: ");
                        valor = LerValor("depositar");

                        if (conta.Depositar(valor))
                        {
                            Console.WriteLine("Depósito realizado!");
                            MensagemContinuar();
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido para depósito...");
                            MensagemContinuar();
                        }
                        break;

                    case 2:
                        Console.Write("Informe o valor desejado para sacar: ");
                        valor = LerValor("sacar");

                        if (conta.Sacar(valor))
                        {
                            Console.WriteLine("Saque realizado!");
                            MensagemContinuar();
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente para o saque solicitado...");
                            MensagemContinuar();
                        }
                        break;

                    case 3:
                        Console.WriteLine("Seu saldo atual é: " + conta.VerSaldo());
                        MensagemContinuar();
                        break;

                    case 0: continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!\n");
                        MensagemContinuar();
                        break;
                }

            } while (continuar);
        }

        private static decimal LerValor(string acao)
        {
            do
            {
                try
                {
                    return decimal.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor inválido...");
                    MensagemContinuar();
                    Console.Write($"Informe o valor desejado para {acao}: ");
                }
            } while (true);
        }

        private static void MensagemContinuar()
        {
            Console.WriteLine("\nAperte ´Enter´ para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}