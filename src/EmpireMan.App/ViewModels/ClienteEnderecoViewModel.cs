using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmpireMan.App.ViewModels
{
    public class ClienteEnderecoViewModel
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(150, ErrorMessage = "O campo {0} precisa conter entre {2}, e {1} caracteres.", MinimumLength = 2)]
        public string Logradouro { get; set; }

        [DisplayName("Descrição")]
        [MaxLength(50)]
        public string Numero { get; set; }

        [MaxLength(150)]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(8, ErrorMessage = "O campo {0} precisa conter {1} caracteres.", MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(2, ErrorMessage = "O campo {0} precisa conter {1} caracteres.", MinimumLength = 2)]
        public string Estado { get; set; }

        public ClienteViewModel Cliente { get; set; }
    }
}