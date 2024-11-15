using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirVisEcomerce.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]    
        public int UserId { get; set; }
        public required string name { get; set; }
        public required string lastname { get; set; }
        public required string email { get; set; }
        public required string password { get; set; }
        public required string role { get; set; }


        public ICollection<Resenia> Resenias {  get; set; } = new List<Resenia>();
    }

}
