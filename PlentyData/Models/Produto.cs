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
        public int Gtin { get; set; }
        public bool Ativo { get; set; }

    }
}
