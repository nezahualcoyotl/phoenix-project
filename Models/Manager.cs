using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackstageMusic.Models
{
    public class Manager : BaseEntity
    {
        [Key]
        public int id_manager { get; set; }

        [Required]
        public string name { get; set; }

        [ForeignKey("User")]
        public int id_user { get; set; }
        public User User { get; set; }

        [ForeignKey("Label")]
        public int? id_label { get; set; }
        public Label Label { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
    }
}
