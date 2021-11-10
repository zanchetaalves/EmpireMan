using System;

namespace EmpireMan.Business.Models
{
    public class Produto : Entity
    {
        public int CategoriaId { get; set; }
        public string Descricao { get; set; }
        public string CodigoBarras { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public Categoria Categoria { get; set; }
    }
}