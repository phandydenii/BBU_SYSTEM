using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model
{
    [Table("EXTEND")]
	public class Extend
	{
        [Key]
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

