using System.ComponentModel.DataAnnotations;


namespace BackstageMusic.Models
{
    public class CollaboratorType : BaseEntity
    {
        [Key]
        public int id_collaboratortype { get; set; }

        [Required]
        public string name { get; set; }
    }
}