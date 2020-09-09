using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackstageMusic.Models
{
    public class AssetGenre : BaseEntity
    {
        [Key]
        public int id_assetgenre { get; set; }

        [ForeignKey("Asset")]
        public int id_asset { get; set; }
        public virtual Asset Asset { get; set; }

        [ForeignKey("Genre")]
        public int id_genre { get; set; }
        public virtual Genre Genre { get; set; }
    }
}