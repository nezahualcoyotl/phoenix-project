using System.ComponentModel.DataAnnotations;

namespace BackstageMusic.Models
{
    public class AssetType : BaseEntity
    {
        [Key]
        public int id_assettype { get; set; }

        [Required]
        public string name { get; set; }
    }
}