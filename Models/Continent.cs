using System.ComponentModel.DataAnnotations;

namespace BackstageMusic.Models
{
    public class Continent : BaseEntity
    {
        [Key]
        public int id_continent { get; set; }

        [Required]
        public string name { get; set; }
    }
}