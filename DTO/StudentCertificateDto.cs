using System;
namespace BBU_SYSTEM.DTO
{
	public class StudentCertificateDto
	{
        public int student_certificate_id { get; set; }
        public string student_id { get; set; } = null!;
        public int certificate_id { get; set; }
        public string? grade { get; set; }
        public int? is_received { get; set; }
        public string? certificate_issue_no { get; set; }
    }
}

