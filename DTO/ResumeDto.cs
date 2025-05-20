using System;
namespace BBU_SYSTEM.DTO
{
	public class ResumeDto
	{
        public int resume_id { get; set; }
        public DateTime date_payment { get; set; }
        public string student_id { get; set; } = null!;
        public int field_id { get; set; }
        public int f_promotion { get; set; }
        public int f_year { get; set; }
        public int f_semester { get; set; }
        public int c_promotion { get; set; }
        public string? stage { get; set; }
        public int c_year { get; set; }
        public int c_semester { get; set; }
        public string? other { get; set; }
        public string? type { get; set; }
    }
}

