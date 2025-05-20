using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model
{
	[Table("HIGH_SCHOOL")]
	public class HightSchool
	{
		[Key]
		public int high_school_id { get; set; }
		public string? high_school_name { get; set; }
		public string? high_school_name_in_khmer { get; set; }
	}
}

