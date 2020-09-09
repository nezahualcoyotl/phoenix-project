using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackstageMusic.Models
{
    public class Invitation : BaseEntity
    {
        [Key]
        public int id_invitation { get; set; }

        [ForeignKey("Inviter")]
        public int id_inviter { get; set; }

        [ForeignKey("Invitee")]
        public int id_invitee { get; set; }

        public DateTime? accepted_on { get; set; }

        public virtual User Inviter { get; set; }
        public virtual User Invitee { get; set; }
    }
}