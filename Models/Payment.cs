using System.ComponentModel.DataAnnotations;

namespace BackstageMusic.Models
{
    public class Payment : BaseEntity
    {
        [Key]
        public int id_payment { get; set; }

        public string voucher { get; set; }

        [Required]
        public string transaction_id { get; set; }

        [Required]
        public string payment_status { get; set; }

        [Required]
        public string payment_amount { get; set; }

        [Required]
        public string currency { get; set; }
    }
}