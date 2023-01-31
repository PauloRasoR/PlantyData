using Microsoft.AspNetCore.Mvc.Rendering;
using PlentyData.Models.Enum;
using System.Collections.Generic;

namespace PlentyData.Models.ViewModels

{
    public class ProdutoCadastro
    {
        public Produto produto { get; set; }       
        public ICollection<Unidade> Unidade { get; set; }
        public TipoAgregadoEnum TipoAgregadoEnum { get; set; }
        public ICollection<Empresa> Empresa { get; set; }
    }
}
