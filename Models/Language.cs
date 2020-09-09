using System.ComponentModel.DataAnnotations;


namespace BackstageMusic.Models
{
    public class Language : BaseEntity
    {
        [Key]
        public int id_language { get; set; }

        [Required]
        public string name { get; set; }
    }
}