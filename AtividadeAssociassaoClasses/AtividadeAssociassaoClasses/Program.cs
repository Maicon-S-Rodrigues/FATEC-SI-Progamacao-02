using System;

namespace AtividadeAssociassaoClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa(
                "Thais Keli Vilasboas Batista",
                "1698870003",
                new Endereco(
                    "Jesuino Ferreira Lopes",
                    "Rua",
                    "Araraquara",
                    "SP",
                    "Del Rey",
                    1222,
                    126,
                    "Portaria - Fatec Araraquara"
                ),
                25
            );

            PessoaFisica pessoaFisica = new PessoaFisica(
                "47933005588",
                "Maicon Siqueira Rodrigues",
                "1698870003",
                new Endereco(
                    "Jose Segantini",
                    "Rua",
                    "Araraquara",
                    "SP",
                    "Silvestre",
                    16161,
                    126,
                    "Portaria - Fatec Araraquara"
                ),
                25
            );           

            Menu(pessoa, pessoaFisica);

            Console.Clear();
            Console.WriteLine("Bye Bye...");
            Console.ReadKey();
        }

        private static void MostrarPessoa(
            Pessoa pessoa
        )
        {
            Console.WriteLine("\nDados da Pessoa:" + pessoa.ToString());
            Console.WriteLine("____________________________________________________________");
        }

        private static void MostrarEnderecoDaPessoa(
            Pessoa pessoa
        )
        {
            Console.WriteLine("\nDados do Endereço da Pessoa:" + pessoa.Endereco.ToString());
            Console.WriteLine("____________________________________________________________");
        }

        private static void MostrarPessoaFisica(
            PessoaFisica pessoaFisica
        )
        {
            Console.WriteLine("\nDados da Pessoa Física:" + pessoaFisica.ToString());
            Console.WriteLine("____________________________________________________________");
        }

        private static void MostrarEnderecoDaPessoaFisica(
            PessoaFisica pessoaFisica
        )
        {
            Console.WriteLine("\nDados do Endereço da Pessoa Física:" + pessoaFisica.Endereco.ToString());
            Console.WriteLine("____________________________________________________________");
        }

        private static void MostrarTodosOsDadosDasDuasPessoas(
            Pessoa pessoa, 
            PessoaFisica pessoaFisica
        )
        {
            MostrarPessoa(pessoa);
            MostrarPessoaFisica(pessoaFisica);
        }

        private static void Menu(
            Pessoa pessoa, 
            PessoaFisica pessoaFisica
        )
        {
            bool continuar = true;
            int escolha = 0;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\nDigite o número da ação que deseja fazer:");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine(
                        "\n[ 1 ] - Ver os dados de uma Pessoa" +
                        "\n[ 2 ] - Ver os dados de uma Pessoa Física" +
                        "\n[ 3 ] - Ver o endereço de uma Pessoa" +
                        "\n[ 4 ] - Ver o endereço de uma Pessoa Física" +
                        "\n[ 5 ] - Ver todos os dados dos dois tipos de Pesoa" +
                        "\n[ 6 ] - Sair"
                    );
                    Console.WriteLine("-------------------------------------------------");
                    Console.Write("Escolha: ");
                    escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            Console.Clear();
                            MostrarPessoa(pessoa);
                            MensagemContinuar();
                            break;

                        case 2:
                            Console.Clear();
                            MostrarPessoaFisica(pessoaFisica);
                            MensagemContinuar();
                            break;

                        case 3:
                            Console.Clear();
                            MostrarEnderecoDaPessoa(pessoa);
                            MensagemContinuar();
                            break;

                        case 4:
                            Console.Clear();
                            MostrarEnderecoDaPessoaFisica(pessoaFisica);
                            MensagemContinuar();
                            break;

                        case 5:
                            Console.Clear();
                            MostrarTodosOsDadosDasDuasPessoas(pessoa, pessoaFisica);
                            MensagemContinuar();
                            break;

                        case 6:
                            continuar = false;
                            break;

                        default:
                            throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nEscolha inválida... Escolha um Número com a ação desejada [ de 1 a 6 ]");
                    MensagemContinuar();
                }       
            } while (continuar);
        }

        private static void MensagemContinuar()
        {
            Console.WriteLine("\nAperte 'Enter' para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}