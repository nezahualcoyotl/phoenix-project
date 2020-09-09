using System.ComponentModel.DataAnnotations;


namespace BackstageMusic.Models
{
    public class Genre : BaseEntity
    {
        [Key]
        public int id_genre { get; set; }

        [Required]
        public string name { get; set; }
    }
}