using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Models
{
    [Table("province")]
    public class Province
    {
        [Key]
        public int province_id { get; set; }
        public string? province { get; set; }
        public string? province_in_khmer { get; set; }
        public int is_city { get; set; }
    }
}

