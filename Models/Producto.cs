using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirVisEcomerce.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public required string name { get; set; }
        public required double price { get; set; }
        public required string description { get; set; }
        public required string img { get; set; }
        public required string descuento { get; set; }
        public required string categories { get; set; }
 

        public ICollection<Resenia> Resenias { get; set; } = new List<Resenia>();
    }
}
