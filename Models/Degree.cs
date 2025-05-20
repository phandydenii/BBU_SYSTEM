using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Models;

[Table("DEGREE")]
public class Degree
{
    [Key] public int degree_id { get; set; }

    [Required(ErrorMessage = "Degree is required")]
    public string? degree { get; set; }

    [Required(ErrorMessage = "Degree in khmer is required")]
    public string? degree_in_khmer { get; set; }
}