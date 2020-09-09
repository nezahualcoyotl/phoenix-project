using System.ComponentModel.DataAnnotations;

namespace BackstageMusic.Models
{
    public class UserType : BaseEntity
    {
        [Key]
        public int id_usertype { get; set; }

        [Required]
        public string name { get; set; }
    }
}