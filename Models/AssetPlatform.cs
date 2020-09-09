using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackstageMusic.Models
{
    public class AssetPlatform : BaseEntity
    {
        [Key]
        public int id_assetplatform { get; set; }

        [ForeignKey("Asset")]
        public int id_asset { get; set; }
        public virtual Asset Asset { get; set; }

        [ForeignKey("Platform")]
        public int id_genre { get; set; }
        public virtual Platform Platform { get; set; }
    }
}