using System.ComponentModel.DataAnnotations;

namespace BBU_SYSTEM.DTO;

public class DegreeDto
{
    public int degree_id { get; set; }

    [Required(ErrorMessage = "Degree is required")]
    public string? degree { get; set; }

    [Required(ErrorMessage = "Degree in khmer is required")]
    public string? degree_in_khmer { get; set; }
}