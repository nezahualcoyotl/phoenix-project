using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackstageMusic.Models
{
    public class User : BaseEntity
    {
        [Key]
        public int id_user { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }

        [ForeignKey("UserType")]
        public int id_usertype { get; set; }
        public virtual UserType UserType { get; set; }

        [Required]
        public bool is_suscribed { get; set; }

        [Required]
        public bool is_confirmed { get; set; }

        public string primary_address { get; set; }

        public string secondary_address { get; set; }

        public string city { get; set; }

        public int zipcode { get; set; }

        [ForeignKey("Country")]
        public int id_country { get; set; }
        public virtual Country Country { get; set; }

        public string voucher { get; set; }
    }
}