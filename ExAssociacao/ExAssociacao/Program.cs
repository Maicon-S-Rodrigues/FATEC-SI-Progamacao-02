using System;

namespace ExAssociacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa(
                "Maicon Siqueira Rodrigues",
                "1698870003",
                new Endereco(
                    "Precide São Martim",
                    "Rua",
                    "Araraquara",
                    "SP",
                    "Jardim Santa Clara",
                    14811,
                    126,
                    "Portaria - Fatec Araraquara"
                ),
                25
            );

            Console.WriteLine("Dados da Pessoa:" + pessoa.ToString());

            Console.WriteLine("____________________________________________________________");

            PessoaFisica pessoaFisica = new PessoaFisica(
                "47933005588",
                "Maicon Siqueira Rodrigues",
                "1698870003",
                new Endereco(
                    "Precide São Martim",
                    "Rua",
                    "Araraquara",
                    "SP",
                    "Jardim Santa Clara",
                    14811,
                    126,
                    "Portaria - Fatec Araraquara"
                ),
                25
            );

            Console.WriteLine("Dados da Pessoa Física:" + pessoaFisica.ToString());

            Console.ReadKey();
        }
    }
}