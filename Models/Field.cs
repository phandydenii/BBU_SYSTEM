using BBU_SYSTEM.Repository;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model;
[Table("field")]
public class Field
{
    [Key]
    public int field_id { get; set; }
    public string? field_name { get; set; }
    public string? field_name_in_khmer { get; set; }
    public int school_id { get; set; } 
    public int degree_id { get; set; } 
    public string? degree_name { get; set; }
    public string? degree_name_in_khmer { get; set; }
    public bool? type { get; set; }
}
