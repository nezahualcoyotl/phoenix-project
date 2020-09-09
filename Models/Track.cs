using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackstageMusic.Models
{
    public class Track : BaseEntity
    {
        [Key]
        public int id_track { get; set; }

        [ForeignKey("Asset")]
        public int id_asset { get; set; }
        public Asset Asset { get; set; }

        [Required]
        public Guid track_guid { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string file_name { get; set; }

        [Required]
        public int track_number { get; set; }

        [Required]
        public bool is_explicit { get; set; }

        [Required]
        public string isrc { get; set; }
    }
}