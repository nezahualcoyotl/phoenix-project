using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackstageMusic.Models
{
    public class Collaboration : BaseEntity
    {
        [Key]
        public int id_collaboration { get; set; }

        [ForeignKey("Track")]
        public int id_track { get; set; }
        public virtual Track Track { get; set; }

        [ForeignKey("CollaboratorType")]
        public int id_collaboratortype { get; set; }
        public virtual CollaboratorType CollaboratorType { get; set; }

        [Required]
        public string name { get; set; }
    }
}