using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackstageMusic.Models
{
    public class Order : BaseEntity
    {
        [Key]
        public int id_order { get; set; }

        [ForeignKey("Payment")]
        public int id_payment { get; set; }
        public Payment Payment { get; set; }

        [ForeignKey("User")]
        public int id_user { get; set; }
        public User User { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}