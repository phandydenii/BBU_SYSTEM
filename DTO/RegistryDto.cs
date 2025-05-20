using System;
namespace BBU_SYSTEM.DTO
{
	public class RegistryDto
	{
        public int registration_id { get; set; }
        public string? student_id { get; set; }
        public int degree_id { get; set; }
        public int school_id { get; set; }
        public int promotion_no { get; set; }
        public int stage_no { get; set; }
        public int term_no { get; set; }
        public string? study_time { get; set; }
        public DateTime registration_date { get; set; }
        public DateTime done_date { get; set; }
        public string? high_school_result { get; set; }
        public int? high_school_table_no { get; set; }
        public string? update_by { get; set; }
        public DateTime? update_date { get; set; }
    }
}

