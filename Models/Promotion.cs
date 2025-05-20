using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model;

[Table("promotion")]
public class Promotion
{
    [Key]
    public int promotion_id { get; set; }
    public int degree_id { get; set; }
    public int school_id { get; set; }
    public int promotion_no { get; set; }
    public int academic_year_start { get; set; }
    public int academic_year_end { get; set; }
    public string? status { get; set; }
    public DateTime? graduate_date1 { get; set; }
    public DateTime? graduate_date2 { get; set; }
}