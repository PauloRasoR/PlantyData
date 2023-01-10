using PlentyData.Models.Enuns;

namespace PlentyData.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public EnderecoTipo Tipo { get; set; }
        public int Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Referencia { get; set; }
        public bool Ativo  { get; set; }
        public Entidade EnderecoEntidade { get; set; }  
        public int EntidadeId { get; set; }

        public Endereco() 
        { 
        }

        public Endereco(int id, EnderecoTipo tipo, int cep, string logradouro, int numero, string complemento, string referencia, bool ativo)
        {
            Id = id;
            Tipo = tipo;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Referencia = referencia;
            Ativo = ativo;
        }
    }
}
