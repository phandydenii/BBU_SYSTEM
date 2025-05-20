using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model;

[Table("term")]
public class Term
{
    [Key]
    public int term_id { get; set; }
    public int stage_id { get; set; }
    public int term_no { get; set; }
    public DateTime start_date { get; set; }
    public DateTime end_date { get; set; }
    public int academic_year_start { get; set; }
    public int academic_year_end { get; set; }
    public string? status { get; set; }
    public DateTime? start_payment_date { get; set; }
}