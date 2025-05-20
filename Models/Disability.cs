using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model
{
    [Table("disability_tbl")]
    public class Disability
	{
        [Key]
        public int id { get; set; }
        public string? disability { get; set; }
        public string? disabilityKh { get; set; }
    }
}

