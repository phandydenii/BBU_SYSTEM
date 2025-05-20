using System;
namespace BBU_SYSTEM.ViewModel
{
	public class StudentDiscountViewModel
	{
        public int student_discount_id { get; set; }
        public string? student_id { get; set; }
        public string? student_name { get; set; }
        public string? student_name_in_khmer { get; set; }
        public string? sex { get; set; }
        public DateTime date_of_birth { get; set; }
        public int? place_of_birth_id { get; set; }
        public string? phone { get; set; }
        public string? email { get; set; }
        public string? address { get; set; }
        public int discount { get; set; }
        public string? note { get; set; }
    }
}

