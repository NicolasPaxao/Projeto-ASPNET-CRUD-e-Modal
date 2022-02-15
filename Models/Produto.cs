using Microsoft.AspNetCore.Mvc;
using ProjetoTreino0702.Models.Enumeradores;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoTreino0702.Models
{
    [Table("Tbl_Produtos")]
    public class Produto
    {
        [Column("Id"), HiddenInput]
        public int ProdutoId { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        [Required]
        public CategoriaProdutos Categorias { get; set; }
        [Required]
        public TamanhoProdutos Tamanhos { get; set; }
        public decimal Preco { get; set; }

    }
}
