using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Humanizer;

namespace BBU_SYSTEM.Models
{
    [Table("NATIONALITY")]
	public class Nationality
	{
        [Key]
		public int nationality_id { get; set; }
        public string? nationality { get; set; }
        public string? nationality_in_khmer { get; set; }
    }
}

