namespace Cadastro.De.Alunos.E.Disciplinas
{
    internal class Disciplina
    {
        public Disciplina(
            int codigo, 
            string nome, 
            double primeiraNota, 
            double segundaNota,
            double notaSubstitutiva,
            double mediaFinal, 
            int faltas, 
            string situacaoFinal
        )
        {
            Codigo = codigo;
            Nome = nome;
            PrimeiraNota = primeiraNota;
            SegundaNota = segundaNota;
            NotaSubstitutiva = notaSubstitutiva;
            MediaFinal = mediaFinal;
            Faltas = faltas;
            SituacaoFinal = situacaoFinal;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double PrimeiraNota { get; set; }
        public double SegundaNota { get; set; }
        public double NotaSubstitutiva { get; set; }
        public double MediaFinal { get; set; }
        public int Faltas { get; set; }
        public string SituacaoFinal { get; set; }

        public override string ToString()
        {
            return $"\n-------------------------------------------------" +
                   $"\nDados da Disciplina {Nome} | Código: {Codigo}:" +
                   $"\nPrimeira Nota do Aluno: {PrimeiraNota}" +
                   $"\nSegunda Nota do Aluno: {SegundaNota}" +
                   $"\nNota Substitutiva do Aluno: {NotaSubstitutiva}" +
                   $"\n\nMédia Final do Aluno: {MediaFinal}" +
                   $"\nQuantidade de Faltas do Aluno: {Faltas}" +
                   $"\n\nSituação Final: {SituacaoFinal}" +
                   $"\n-------------------------------------------------";
        }
    }
}