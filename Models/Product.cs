using System.ComponentModel.DataAnnotations;

namespace BackstageMusic.Models
{
    public class Product : BaseEntity
    {
        [Key]
        public int id_product { get; set; }

        [Required]
        public string name { get; set; }

        public string photo_url { get; set; }

        [Required]
        public decimal price { get; set; }
    }
}