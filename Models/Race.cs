using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Models
{
	[Table("RACE")]
	public class Race
	{
		[Key]
		public int race_id { get; set; }
		public string? race { get; set; }
		public string? race_in_khmer { get; set; }
    }
}

