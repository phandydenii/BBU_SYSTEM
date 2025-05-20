using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Models
{
	[Table("STUDENT_DISCOUNT")]
	public class StudentDiscount
	{
		[Key]
		public int student_discount_id { get; set; }
		public string? student_id { get; set; }
		public int discount { get; set; }
		public string? note { get; set; }
	}
}

