using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace PlentyData.Models
{
    public class Unidade
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Unidade")]
        public string Abreviacao { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Nome { get; set; }
        public bool Ativo { get; set; } 
        
        public Unidade()
        {

        }

        public Unidade(int id, string abreviacao, string nome, bool ativo)
        {
            Id = id;
            Abreviacao = abreviacao;
            Nome = nome;
            Ativo = ativo;
        }
    }
}
