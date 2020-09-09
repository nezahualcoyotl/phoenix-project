using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackstageMusic.Models
{
    public class Admin : BaseEntity
    {
        [Key]
        public int id_admin { get; set; }

        [Required]
        public string name { get; set; }

        [ForeignKey("User")]
        public int id_user { get; set; }
        public virtual User User { get; set; }
    }
}