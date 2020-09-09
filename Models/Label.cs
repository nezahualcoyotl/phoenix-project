using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackstageMusic.Models
{
    public class Label : BaseEntity
    {
        [Key]
        public int id_label { get; set; }

        [Required]
        public string name { get; set; }

        [ForeignKey("User")]
        public int id_user { get; set; }
        public User User { get; set; }

        public virtual ICollection<Manager> Managers { get; set; }
    }
}