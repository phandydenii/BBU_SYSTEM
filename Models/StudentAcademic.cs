using System;
using BBU_SYSTEM.Model;

namespace BBU_SYSTEM.Models
{
	public class StudentAcademic
	{
        public Student? student { get; set; }
        public StudentGroup? studentGroup { get; set; }
        public Group? group { get; set; }
        public GroupRoom? groupRoom { get; set; }
        public Stage? stage { get; set; }
        public Term? term { get; set; }
        public Promotion? promotion { get; set; }
        public School? school { get; set; }
        public Field? field { get; set; }
        public Degree? degree { get; set; } 

        //public string? student_id { get; set; }
        //public string? student_name { get; set; }
        //public string? student_name_in_khmer { get; set; }
        //public string? sex { get; set; }
        //public DateTime date_of_birth { get; set; }
        //public int degree_id { get; set; }
        //public string? degree { get; set; }
        //public string? degree_in_khmer { get; set; }
        //public int school_id { get; set; }
        //public string? school_name { get; set; }
        //public string? school_name_in_khmer { get; set; }
        //public string? school_code { get; set; }
        //public decimal faculty_id { get; set; }
        //public int is_foundation_school { get; set; }
        //public int field_id { get; set; }
        //public string? field_name { get; set; }
        //public string? field_name_in_khmer { get; set; }
        //public string? degree_name { get; set; }
        //public string? degree_name_in_khmer { get; set; }
        //public bool? type { get; set; }
        //public int promotion_id { get; set; }
        //public int promotion_no { get; set; }
        //public int academic_year_start { get; set; }
        //public int academic_year_end { get; set; }
        //public string? status { get; set; }
        //public DateTime? graduate_date1 { get; set; }
        //public DateTime? graduate_date2 { get; set; }
        //public int term_id { get; set; }
        //public int term_no { get; set; }
        //public DateTime start_date { get; set; }
        //public DateTime end_date { get; set; }
        //public int term_start { get; set; }
        //public int term_end { get; set; }
        //public string? term_status { get; set; }
        //public DateTime? start_payment_date { get; set; }
        //public int stage_id { get; set; }
        //public int stage_no { get; set; }
        //public int group_id { get; set; }
        //public string? group_name { get; set; }
        //public string? study_time { get; set; }
        //public int created_in_term_no { get; set; }
        //public string? note { get; set; }
        //public string? room_name { get; set; }
        //public int student_group_id { get; set; }
    }
}

