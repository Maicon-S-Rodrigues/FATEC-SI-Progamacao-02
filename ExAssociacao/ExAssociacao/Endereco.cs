namespace ExAssociacao
{
    internal class Endereco
    {
        public Endereco(
            string logradouro,
            string tipoDeLogradouro, 
            string localidade, 
            string uf, 
            string bairro,
            int cep,
            int numero,
            string complemento
        )
        {
            Logradouro = logradouro;
            TipoDeLogradouro = tipoDeLogradouro;
            Localidade = localidade;
            UF = uf;
            Bairro = bairro;
            CEP = cep;
            Numero = numero;
            Complemento = complemento;
        }

        public string Logradouro { get; set; }
        public string TipoDeLogradouro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public override string ToString()
        {
            return $"\nLogradouro: {Logradouro},\nTipo de Logradouro: {TipoDeLogradouro}," +
                   $"\nLocalidade: {Localidade},\nUF: {UF},\nBairro: {Bairro},\nCEP: {CEP}," +
                   $"\nNúmero: {Numero},\nComplemento: {Complemento}.\n"; 
        }
    }
}