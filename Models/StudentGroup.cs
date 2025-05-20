using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model
{
    [Table("STUDENT_GROUP")]
	public class StudentGroup
	{
        [Key]
        public int student_group_id { get; set; }
        public string? student_id { get; set; }
        public int term_no { get; set; }
        public int group_id { get; set; } 
    }
}

