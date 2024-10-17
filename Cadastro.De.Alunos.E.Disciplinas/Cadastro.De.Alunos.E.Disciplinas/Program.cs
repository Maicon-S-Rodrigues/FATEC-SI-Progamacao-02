using System;
using System.Collections.Generic;

namespace Cadastro.De.Alunos.E.Disciplinas
{
    internal class Program
    {
        public static readonly int _cargaHorariaDasDisciplinas = 80;
        public static Aluno _aluno = new Aluno();
        public static List<Disciplina> _disciplinas = new List<Disciplina>();

        static void Main(string[] args) => Menu();
        
        private static void Menu()
        {
            bool continuar = true;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Bem vindo!");
                    Console.WriteLine("[ 1 ] -> Cadastrar Aluno");
                    Console.WriteLine("[ 2 ] -> Adicionar Disciplinas");
                    Console.WriteLine("[ 3 ] -> Calcular Situação Final do Aluno");
                    Console.WriteLine("[ 4 ] -> Imprimir todos os dados do Aluno e suas Disciplinas");
                    Console.WriteLine("[ 5 ] -> Sair");
                    Console.Write("\nO que deseja fazer? ");
                    int escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            Console.Clear();
                            if (_aluno.RA != null)
                            {
                                Console.WriteLine("\nJá tem um Aluno informado!");
                                MensagemParaContinuar();
                            }
                            else
                            {
                                CadastrarAluno();
                                Console.WriteLine("\nAluno cadastrado com Sucesso!");
                                MensagemParaContinuar();
                            }
                            break;

                        case 2:
                            Console.Clear();
                            if (_aluno.RA != null)
                            {
                                CadastrarDisciplina();
                                Console.WriteLine("\nDisciplina cadastrada com Sucesso!");
                                MensagemParaContinuar();
                            }
                            else
                            {
                                Console.WriteLine("\nAluno não cadastrado, primeiro cadastre um para então cadastrar suas Disciplinas...");
                                MensagemParaContinuar();
                            }
                            break;

                        case 3:
                            Console.Clear();
                            if (_aluno.RA != null)
                            {
                                Console.WriteLine(_aluno.ToString());
                                
                                if (_disciplinas.Count > 0)
                                    foreach (var disciplina in _disciplinas)
                                        Console.WriteLine(disciplina.ToString());
                                else
                                {
                                    Console.WriteLine("\nNenhuma Disciplina para mostrar para este Aluno...");
                                    MensagemParaContinuar();
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNenhum Resultado para mostrar...");
                                MensagemParaContinuar();
                            }
                            MensagemParaContinuar();
                            break;

                        case 4:
                            Console.Clear();
                            if (_aluno.RA != null)
                            {
                                Console.WriteLine(_aluno.ToString());

                                if (_disciplinas.Count > 0)
                                    foreach (var disciplina in _disciplinas)
                                        Console.WriteLine(disciplina.ToString());
                                else
                                {
                                    Console.WriteLine("\nNenhuma Disciplina para mostrar para este Aluno...");
                                    MensagemParaContinuar();
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNão há nada para mostrar...");
                                MensagemParaContinuar();
                            }
                            MensagemParaContinuar();
                            break;

                        case 5:
                            continuar = false;
                            break;

                        default:
                            throw new Exception();
                    }
                }
                catch (Exception) 
                {
                    Console.WriteLine("\nEscolha inválida!\nDigite um número Inteiro [ 1... 5 ]");
                    MensagemParaContinuar();
                }
            } while(continuar);
        }

        private static void CadastrarAluno()
        {
            Console.WriteLine("Cadastro do Aluno:\n");
            
            Console.Write("Informe o Nome do Aluno: ");
            _aluno.Nome = Console.ReadLine();

            Console.Write("\nInforme o RA do Aluno: ");
            _aluno.RA = Console.ReadLine();
        }

        private static void CadastrarDisciplina()
        {
            Console.WriteLine("Cadastro de Disciplina:\n");

            int codigo = LerValorInteiro("\nInforme o Código da Disciplina: ");

            Console.Write("\nInforme o Nome da Disciplina: ");
            string nome = Console.ReadLine();

            double primeiraNota = LerValorDouble("\nInforme a Primeira Nota do Aluno na Disciplina: ");
            double segundaNota = LerValorDouble("\nInforme a Segunda Nota do Aluno na Disciplina: ");
            double notaSubstitutiva = LerValorDouble("\nInforme a Nota Substitutiva do Aluno na Disciplina [Caso não tenha, digite 0]: ");

            double mediaFinal = CalcularMediaFinal(
                primeiraNota, 
                segundaNota, 
                notaSubstitutiva
            );

            int faltas = LerValorInteiro("\nInforme quantas Faltas o Aluno teve na Disciplina: ");

            string situacaoFinal = DeterminarSituacaoFinalDoAluno(
                mediaFinal,
                faltas
            );

            _disciplinas.Add(
                new Disciplina(
                    codigo,
                    nome,
                    primeiraNota,
                    segundaNota,
                    notaSubstitutiva,
                    mediaFinal,
                    faltas,
                    situacaoFinal
                )
            );
        }

        private static double CalcularMediaFinal(
            double primeiraNota, 
            double segundaNota, 
            double notaSubstitutiva
        )
        {
            if ( notaSubstitutiva > 0 )
            {
                double maiorNota = 0;

                if (primeiraNota > segundaNota)
                    maiorNota = primeiraNota;

                else if (segundaNota > primeiraNota)
                    maiorNota = segundaNota;

                else if (primeiraNota == segundaNota)
                    maiorNota = primeiraNota;

                return (maiorNota + notaSubstitutiva) / 2;
            }
            else
                return (primeiraNota + segundaNota) / 2;
        }

        private static string DeterminarSituacaoFinalDoAluno(
            double mediaFinal,
            int faltas
        )
        {
            int limiteDeFaltas = (_cargaHorariaDasDisciplinas * 25) / 100;

            if (faltas > limiteDeFaltas)
                return "REPROVADO - Faltas";

            else if (mediaFinal >= 6)
                return "APROVADO";

            else
                return "REPROVADO - Notas";
        }

        private static int LerValorInteiro(string mensagem)
        {
            do
            {
                try
                {
                    Console.Write(mensagem);
                    return int.Parse(Console.ReadLine());        
                }
                catch (Exception)
                {
                    Console.WriteLine("\nValor inválido!");
                    MensagemParaContinuar();
                }
            } while (true);
        }

        private static double LerValorDouble(string mensagem)
        {
            do
            {
                try
                {
                    Console.Write(mensagem);
                    double numero = double.Parse(Console.ReadLine());

                    if (numero >= 0 && numero <= 10)
                        return numero;
                    else
                        throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("\nValor inválido!");
                    MensagemParaContinuar();
                }
            } while (true);
        }

        private static void MensagemParaContinuar()
        {
            Console.WriteLine("[ Aperte 'Enter' para continuar... ]");
            Console.ReadKey();
            Console.Clear();
        }
    }
}