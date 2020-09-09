using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackstageMusic.Models
{
    public class Artist : BaseEntity
    {
        [Key]
        public int id_artist { get; set; }

        [Required]
        public string name { get; set; }

        [ForeignKey("User")]
        public int id_user { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Manager")]
        public int? id_manager { get; set; }
        public virtual Manager Manager { get; set; }
    }
}