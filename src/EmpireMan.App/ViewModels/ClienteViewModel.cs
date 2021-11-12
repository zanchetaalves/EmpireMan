using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmpireMan.App.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(11, ErrorMessage = "O campo {0} precisa conter entre {1} caracteres.", MinimumLength = 11)]
        public string Cpf { get; set; }

        [MaxLength(10)]
        public string Rg { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataNascimento { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }


        public ClienteEnderecoViewModel ClienteEndereco { get; set; }
    }
}