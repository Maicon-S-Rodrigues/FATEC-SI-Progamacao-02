namespace AtividadeAssociassaoClasses
{
    internal class PessoaFisica : Pessoa
    {
        public PessoaFisica(
            string cpf,
            string nome,
            string telefone,
            Endereco endereco,
            int idade
        ) : base(
            nome,
            telefone,
            endereco,
            idade
        )
        {
            CPF = cpf;
        }

        public string CPF { get; set; }

        public override string ToString()
        {
            return $"\nCPF: {CPF},\nNome: {Nome},\nIdade: {Idade},\nTelefone: {Telefone},\n\nEndereço:{Endereco}";
        }
    }
}