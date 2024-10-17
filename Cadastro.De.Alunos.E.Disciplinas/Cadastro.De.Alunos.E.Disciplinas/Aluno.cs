namespace Cadastro.De.Alunos.E.Disciplinas
{
    internal class Aluno
    {
        public string RA { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"\n-------------------------------------------------" +
                   $"\nDados do Aluno:" +
                   $"\nNome: {Nome} | RA: {RA}" +
                   $"\n-------------------------------------------------";
        }
    }
}