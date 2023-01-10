namespace PlentyData.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeFiscal { get; set; }
        public string Referencia { get; set; }
        public int Ncm { get; set; }
        public int Cest { get; set; }
        public double Gtin { get; set; }
        public bool Ativo { get; set; }

        public Produto()
        {

        }

        public Produto(int id, string nome, string nomeFiscal, string referencia, int ncm, int cest, double gtin, bool ativo)
        {
            Id = id;
            Nome = nome;
            NomeFiscal = nomeFiscal;
            Referencia = referencia;
            Ncm = ncm;
            Cest = cest;
            Gtin = gtin;
            Ativo = ativo;
        }
    }
}
