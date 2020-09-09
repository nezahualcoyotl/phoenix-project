using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackstageMusic.Models
{
    public class OrderDetail : BaseEntity
    {
        [Key]
        public int id_orderdetail { get; set; }

        [ForeignKey("Order")]
        public int id_order { get; set; }
        public Order Order { get; set; }

        [ForeignKey("Product")]
        public int id_product { get; set; }
        public Product Product { get; set; }
    }
}