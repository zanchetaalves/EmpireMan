using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmpireMan.App.ViewModels
{
    public class CategoriaViewModel
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(150, ErrorMessage = "O campo {0} precisa conter entre {2}, e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}