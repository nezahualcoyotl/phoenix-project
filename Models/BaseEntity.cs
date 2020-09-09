using System;

namespace BackstageMusic.Models
{
    public class BaseEntity
    {
        public bool active { get; set; } = true;
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
    }
}