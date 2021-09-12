using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC2.Models
{
    public class Produto
    {
        public int id { get; set; }
        [Display(Name = "Descrição")]
        public String Descricao { get; set; }
        [Range(1, 10, ErrorMessage = "Valor fora do padrão")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
