using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model;

[Table("Group")]
public class Group
{
    [Key]
    public int group_id { get; set; }
    public string? group_name { get; set; }
    public string? study_time { get; set; }
    public int stage_id { get; set; }
    public int field_id { get; set; }
    public int created_in_term_no { get; set; }
    public string? note { get; set; }
}