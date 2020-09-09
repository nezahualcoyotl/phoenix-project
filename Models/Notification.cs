using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackstageMusic.Models
{
    public class Notification : BaseEntity
    {
        [Key]
        public int id_notification { get; set; }

        [ForeignKey("Sender")]
        public int id_sender { get; set; }

        [ForeignKey("Receiver")]
        public int id_receiver { get; set; }

        [Required]
        public string message { get; set; }

        [Required]
        public bool is_seen { get; set; }

        public virtual User Sender { get; set; }
        public virtual User Receiver { get; set; }
    }
}