using System;
namespace BBU_SYSTEM.DTO
{
	public class ExtendDto
	{
        public int extend_id { get; set; }
        public string student_id { get; set; } = null!;
        public int term_no { get; set; }
        public string extend_from { get; set; } = null!;
        public int from_id { get; set; }
        public int? is_certificate_received { get; set; }
        public int? is_transcript_received { get; set; }
        public DateTime? extend_date { get; set; }
    }
}

