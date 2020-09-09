using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackstageMusic.Models
{
    public class Asset : BaseEntity
    {
        [Key]
        public int id_asset { get; set; }

        [ForeignKey("Artist")]
        public int id_artist { get; set; }
        public virtual Artist Artist { get; set; }

        [ForeignKey("AssetType")]
        public int id_assettype { get; set; }
        public virtual AssetType AssetType { get; set; }

        [ForeignKey("Language")]
        public int id_language { get; set; }
        public virtual Language Language { get; set; }

        [ForeignKey("Status")]
        public int id_status { get; set; }
        public virtual Status Status { get; set; }

        [ForeignKey("OrderDetail")]
        public int? id_orderdetail { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }

        [ForeignKey("Admin")]
        public int id_admin { get; set; }
        public virtual Admin Admin { get; set; }

        [Required]
        public Guid asset_guid { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string copy_holder { get; set; }

        [Required]
        public int copy_year { get; set; }

        [Required]
        public int image_version { get; set; }

        public string upc { get; set; }

        [Required]
        public bool is_explicit { get; set; }

        [Required]
        public string is_debut { get; set; }

        [Required]
        public decimal price { get; set; }

        public DateTime? received_on { get; set; }

        public DateTime? approved_on { get; set; }

        public DateTime? released_on { get; set; }

        public DateTime? rejected_on { get; set; }
    }
}