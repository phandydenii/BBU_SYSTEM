using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model;

[Table("branch")]
public class Branch
{
    [Key]
    public int branch_id { get; set; }
    public string? branch_name { get; set; }
    public string? branch_name_in_khmer { get; set; }
    public string? short_name { get; set; }
    public string? address { get; set; }
    public string? phone { get; set; }
}
