
namespace BBU_SYSTEM.DTO
{
    public class SchoolDto
    {
        public int school_id { get; set; }
        public string? school_name { get; set; }
        public string? school_name_in_khmer { get; set; }
        public string? school_code { get; set; }
        public decimal faculty_id { get; set; } 
        public int is_foundation_school { get; set; }
    }
}