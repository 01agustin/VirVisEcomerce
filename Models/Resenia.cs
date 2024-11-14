using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirVisEcomerce.Models
{
    public class Resenia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int ReseniaId { get; set; }
        public required string Comentario { get; set; }
        public int Puntuacion { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

        [ForeignKey("Producto")]
        public int ProductoId { get; set; }

        public Producto Producto { get; set; }
    }
}
