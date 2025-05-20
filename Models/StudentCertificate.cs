using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model
{
    [Table("STUDENT_CERTIFICATE")]
	public class StudentCertificate
	{
        [Key]
        public int student_certificate_id { get; set; }
        public string student_id { get; set; } = null!;
        public int certificate_id { get; set; }
        public string? grade { get; set; }
        public int? is_received { get; set; }
        public string? certificate_issue_no { get; set; }
    }
}

