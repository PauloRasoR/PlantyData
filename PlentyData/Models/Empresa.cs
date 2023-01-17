

namespace PlentyData.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string CpfCnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string IE { get; set; }
        public bool Ativo { get; set; }

        public Empresa()
        {

        }

        public Empresa(int id, string cpfCnpj, string razaoSocial, string nomeFantasia, string iE, bool ativo)
        {
            Id = id;
            CpfCnpj = cpfCnpj;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            IE = iE;
            Ativo = ativo;
        }
    }
}
