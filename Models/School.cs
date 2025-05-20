using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model;

[Table("school")]
public class School
{
    [Key]
    public int school_id { get; set; }
    public string? school_name { get; set; }
    public string? school_name_in_khmer { get; set; }
    public string? school_code { get; set; }
    public decimal faculty_id { get; set; } 
    public int is_foundation_school { get; set; }
}