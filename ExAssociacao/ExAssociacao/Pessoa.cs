namespace ExAssociacao
{
    internal class Pessoa
    {
        public Pessoa() { }
        public Pessoa(
            string nome, 
            string telefone, 
            Endereco endereco, 
            int idade
        )
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Idade = idade;
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"\nNome: {Nome},\nIdade: {Idade},\nTelefone: {Telefone},\n\nEndereço:{Endereco}";
        }
    }
}