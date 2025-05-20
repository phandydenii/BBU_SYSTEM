using System;
namespace BBU_SYSTEM.DTO
{
	public class SchoolarshipDto
	{
        public int student_schoolarship_id { get; set; }
        public string student_id { get; set; } = null!;
        public int term_no { get; set; }
        public int is_full_schoolarship { get; set; }
        public int amount { get; set; }
        public int sponsor_id { get; set; }
    }
}

