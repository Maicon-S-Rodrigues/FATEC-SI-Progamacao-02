using System;

namespace BancoMoranguinho
{
    internal class ContaBancaria
    {
        public ContaBancaria()
        {
            NumeroConta = GerarNumeroConta();
            Saldo = 0;
        }

        private string NumeroConta;
        private decimal Saldo;

        public bool Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                return true;
            }

            return false;
        }

        public bool Sacar(decimal valor)
        {
            if (Saldo > 0 || valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }

            return false;
        }

        public decimal VerSaldo()
        {
            return Saldo;
        }

        private string GerarNumeroConta()
        {
            int numero = 1;

            for (int i = 1; i <= 10; i++)
            {
                numero *= (new Random().Next(1, 10));
            }

            return numero.ToString();
        }
    }
}