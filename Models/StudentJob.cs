using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model
{
	[Table("STUDENT_JOB")]
	public class StudentJob
	{
		[Key]
		public int job_id { get; set; }
		public string? job { get; set; }
		public string? job_in_khmer { get; set; }
    }
}

