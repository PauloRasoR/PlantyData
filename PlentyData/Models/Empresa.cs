namespace PlentyData.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string CpfCnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public int IE { get; set; }
        public Boolean Ativo { get; set; }

        public Empresa()
        {

        }

        public Empresa(int id, string cpfCnpj, string razaoSocial, string nomeFantasia, int iE, bool ativo)
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
