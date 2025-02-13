using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pratas.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public decimal Preco { get; set; }
        [ForeignKey("Categoria")]
        public int? CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}