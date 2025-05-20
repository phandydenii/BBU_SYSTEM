using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model;

[Table("faculty")]
public class Faculty
{
    [Key]
    public decimal faculty_id { get; set; }
    public string? faculty_name { get; set; }
    public string? faculty_name_in_khmer { get; set; }
}