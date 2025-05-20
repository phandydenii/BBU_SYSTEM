using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model;

[Table("stage")]
public class Stage
{
    [Key]
    public int stage_id { get; set; }
    public int promotion_id { get; set; }
    public int stage_no { get; set; }
    public string? status { get; set; }
}