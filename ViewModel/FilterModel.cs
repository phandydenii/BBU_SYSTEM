using System;
namespace BBU_SYSTEM.ViewModel
{
	public class FilterModel
	{
		public int? degree_id { get; set; }
		public int? school_id { get; set; }
		public int? field_id { get; set; }
		public int? promotion_id { get; set; }
        public int? promotion_no { get; set; }
        public int? stage_id { get; set; }
        public int? stage_no { get; set; }
        public int? term_id { get; set; }
        public int? term_no { get; set; }
        public int? group_id { get; set; }
        public string? study_time { get; set; } = string.Empty;
        public string? from_date { get; set; } = string.Empty;
        public string? to_date { get; set; } = string.Empty;
    }
}

