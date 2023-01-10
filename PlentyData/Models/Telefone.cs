using NuGet.Protocol.Core.Types;
using PlentyData.Models.Enuns;

namespace PlentyData.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public TelefoneTipo Tipo { get; set; }
        public int NumeroTelefone { get; set; }
        public bool Ativo { get; set; }
        public Entidade TelefoneEntidade { get; set; }
        public int EntidadeId { get; set; }

        public Telefone()
        {

        }

        public Telefone(int id, TelefoneTipo tipo, int numeroTelefone, bool ativo)
        {
            Id = id;
            Tipo = tipo;
            NumeroTelefone = numeroTelefone;
            Ativo = ativo;
        }
    }
}
