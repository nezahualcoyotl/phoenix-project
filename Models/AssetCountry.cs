using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackstageMusic.Models
{
    public class AssetCountry : BaseEntity
    {
        [Key]
        public int id_assetcountry { get; set; }

        [ForeignKey("Asset")]
        public int id_asset { get; set; }
        public virtual Asset Asset { get; set; }

        [ForeignKey("Country")]
        public int id_country { get; set; }
        public virtual Country Country { get; set; }
    }
}