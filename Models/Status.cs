using System.ComponentModel.DataAnnotations;


namespace BackstageMusic.Models
{
    public class Status : BaseEntity
    {
        [Key]
        public int id_status { get; set; }

        [Required]
        public string name { get; set; }
    }
}