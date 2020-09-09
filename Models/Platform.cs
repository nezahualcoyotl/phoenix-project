using System.ComponentModel.DataAnnotations;

namespace BackstageMusic.Models
{
    public class Platform : BaseEntity
    {
        [Key]
        public int id_platform { get; set; }

        [Required]
        public string name { get; set; }

        public string photo_url { get; set; }
    }
}