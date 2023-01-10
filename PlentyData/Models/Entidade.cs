using NuGet.Protocol.Core.Types;
using PlentyData.Models.Enuns;

namespace PlentyData.Models
{
    public class Entidade
    {
        public int Id { get; set; }
        public EntidadeTipo Tipo { get; set; }
        public string NomeRazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public int CNPJCPF { get; set; }
        public int Identidade { get; set; }
        public int InscricaoEstadual { get; set; }
        public int InscricaoMunicipal { get; set; }
        public bool Ativo { get; set; }
        public ICollection<Endereco> Enderecos { get; set; } = new List<Endereco>();
        public ICollection<Telefone> Telefones { get; set; } = new List<Telefone>();
        
        public Entidade() 
        { 
        }

        public Entidade(int id, EntidadeTipo tipo, string nomeRazaoSocial, string nomeFantasia, int cNPJCPF, int identidade, int inscricaoEstadual, int inscricaoMunicipal, bool ativo)
        {
            Id = id;
            Tipo = tipo;
            NomeRazaoSocial = nomeRazaoSocial;
            NomeFantasia = nomeFantasia;
            CNPJCPF = cNPJCPF;
            Identidade = identidade;
            InscricaoEstadual = inscricaoEstadual;
            InscricaoMunicipal = inscricaoMunicipal;
            Ativo = ativo;
        }
    }
}
