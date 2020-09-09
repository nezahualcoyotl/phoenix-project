using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackstageMusic.Models
{
    public class Country : BaseEntity
    {
        [Key]
        public int id_country { get; set; }

        [Required]
        public string name { get; set; }

        [ForeignKey("Continent")]
        public int id_continent { get; set; }
        public Continent Continent { get; set; }
    }
}