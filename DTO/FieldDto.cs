namespace BBU_SYSTEM.DTO;

public class FieldDto
{
    public int field_id { get; set; }
	public string? field_name { get; set; }
	public string? field_name_in_khmer { get; set; }
	public int school_id { get; set; }  
	public int degree_id { get; set; }  
	public string? degree_name { get; set; }
	public string? degree_name_in_khmer { get; set; }
	public bool? type { get; set; }
}