namespace BBU_SYSTEM.DTO;

public class PromotionDto
{
    public int promotion_id { get; set; }
	public int degree_id { get; set; }
	public int school_id { get; set; }
	public int promotion_no { get; set; }
	public int academic_year_start { get; set; }
	public int academic_year_end { get; set; }
	public string? status { get; set; }
	public DateTime? graduate_date1 { get; set; }
	public DateTime? graduate_date2 { get; set; }
}