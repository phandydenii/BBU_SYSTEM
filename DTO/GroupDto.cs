namespace BBU_SYSTEM.DTO;

public class GroupDto
{
    public int group_id { get; set; }
    public string? group_name { get; set; }
    public string? study_time { get; set; }
    public int stage_id { get; set; }
    public int field_id { get; set; }
    public int created_in_term_no { get; set; }
    public string? note { get; set; }
}