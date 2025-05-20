using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
//[Table("RACE")]
//public class Race
//{
//	[Key]
//	public int race_id { get; set; }
//	[Column("RACE")]
//	public string? race_in_eng { get; set; }
//	public string? race_in_khmer { get; set; }
//}
[Table("nationality")]
public class Nationality
{
    [Key]
    public int nationality_id { get; set; }
    [Column("nationality")]
    public string? nationality_in_eng { get; set; }
    public string? nationality_in_khmer { get; set; }
}
[Table("FIELD_CERTIFICATE")]
public class FieldCertificate
{
    [Key]
    public int id { get; set; }
    public int? degree_id { get; set; }
    public string? degree_name { get; set; }
    public string? degree_name_khmer { get; set; }
    public int? school_id { get; set; }
    public string? school_name { get; set; }
    public string? school_name_khmer { get; set; }
    public int? field_id { get; set; }
    public string? field_name { get; set; }
    public string? field_name_khmer { get; set; }
    public int? promotion_no { get; set; }
    public bool? status { get; set; }
}

//[Table("disability_tbl")]
//public class Disability_Tbl
//{
//	[Key]
//	public int id { get; set; }
//	public string? disability { get; set; }
//	public string? disability_kh { get; set; }
//}
//[Table("app_c_bank_student_id")]
//public class app_c_bank_student_id
//{
//	[Key]
//	public string? student_id { get; set; }
//}

//[Table("available_time")]
//public class available_time
//{
//	[Key]
//	public int available_time_id { get; set; }
//	public int instructor_id { get; set; }
//	public string? day_of_week { get; set; }
//	public string? time { get; set; }
//}


[Table("book_clothes")]
public class book_clothes
{
    [Key]
    public int id { get; set; }
    public string? student_id { get; set; }
    public bool? is_deposit { get; set; }
    public bool? is_return { get; set; }
    public string? invoice_no { get; set; }
    public string? contact_number { get; set; }
    public string? note { get; set; }
}

[Table("booking_tbl")]
public class Booking
{
    [Key]
    public int bookingid { get; set; }
    public DateTime? bookingdate { get; set; }
    public int? userid { get; set; }
    public string? studentid { get; set; }
    public decimal? exchangeid { get; set; }
    public decimal? total { get; set; }
    public int? vat { get; set; }
    public decimal? discount { get; set; }
    public decimal? paydollar { get; set; }
    public decimal? payrieal { get; set; }
    public string? note { get; set; }
    public bool? active { get; set; }
    public string? degree { get; set; }
    public int? school_id { get; set; }
    public int? field_id { get; set; }
    public int? promotion_no { get; set; }
    public int? stage_no { get; set; }
    public int? group_id { get; set; }
    public int? term_no { get; set; }
    public DateTime? from_date { get; set; }
    public DateTime? to_date { get; set; }
    public string? studytime { get; set; }
    public string? update_by { get; set; }
    public DateTime? update_date { get; set; }
    public bool? return_already { get; set; }
    public decimal? return_rate_in { get; set; }
    public DateTime? return_date { get; set; }
    public decimal? return_amount { get; set; }
    public decimal? return_dollar { get; set; }
    public decimal? return_riel { get; set; }
    public int? booking_no { get; set; }
    public string? year_number { get; set; }
}

[Table("booking_detail_tbl")]
public class booking_detail
{
    [Key]
    public int booking_detail_id { get; set; }
    public int? booking_id { get; set; }
    public int? cloth_id { get; set; }
    public decimal? quantity { get; set; }
    public decimal? price { get; set; }
}
[Table("booking_item")]
public class booking_item
{
    [Key]
    public int booking_item_id { get; set; }
    public string? item_name { get; set; }
    public string? item_name_khmer { get; set; }
    public decimal? price { get; set; }
}

[Table("booking_return")]
public class booking_return
{
    [Key]
    public int booking_return_id { get; set; }
    public int? booking_id { get; set; }
    public DateTime? return_date { get; set; }
    public int? booking_return_no { get; set; }
    public string? year_number { get; set; }
    public int? user_id { get; set; }
    public decimal? exchange_id { get; set; }
    public string? student_id { get; set; }
    public string? degree { get; set; }
    public int? school_id { get; set; }
    public int? field_id { get; set; }
    public int? promotion_no { get; set; }
    public int? stage_no { get; set; }
    public int? group_no { get; set; }
    public int? term_no { get; set; }
    public string? study_time { get; set; }
    public DateTime? from_date { get; set; }
    public DateTime? to_date { get; set; }
    public string? update_by { get; set; }
    public DateTime? update_date { get; set; }
    public decimal? return_rate_in { get; set; }
    public decimal? return_amount { get; set; }
    public int? vat { get; set; }
    public decimal? discount { get; set; }
    public decimal? return_dollar { get; set; }
    public decimal? return_riel { get; set; }
    public string? note { get; set; }
    public bool? active { get; set; }
}

[Table("booking_return_detail")]
public class booking_return_detail
{
    [Key]
    public int booking_return_detail_id { get; set; }
    public int? booking_return_id { get; set; }
    public int? booking_id { get; set; }
    public int? cloth_id { get; set; }
    public decimal? quantity { get; set; }
    public decimal? price { get; set; }
}

//[Table("branch")]
//public class Branch
//{
//	[Key]
//	public int branch_id { get; set; }
//	public string? branch_name { get; set; }
//	public string? branch_name_in_khmer { get; set; }
//	public string? short_name { get; set; }
//	public string? address { get; set; }
//	public string? phone { get; set; }
//}

//[Table("branch_course")]
//public class branch_Course
//{
//	[Key]
//	public int branch_course_id { get; set; }
//	public int? branch_id { get; set; }
//	public int? course_id { get; set; }
//}

//[Table("category")]
//public class Category
//{
//	[Key]
//	public int category_id { get; set; }
//	public string? category_name { get; set; }
//	public string? description { get; set; }
//}

[Table("certificate")]
public class Certificate
{
    [Key]
    public int certificate_id { get; set; }
    public string? certificate_code { get; set; }
    public string? certificate_name { get; set; }
}

//[Table("change_branch")]
//public class change_branch
//{
//	[Key]
//	public int change_branch_id { get; set; }
//	public string? student_id { get; set; }
//	public int to_branch_id { get; set; }
//	public int term_no { get; set; }
//	public DateTime from_date { get; set; }
//	public DateTime? return_date { get; set; }
//	public string? degree_id { get; set; }
//	public string? school_id { get; set; }
//	public string? field_id { get; set; }
//	public string? promotion_id { get; set; }
//	public string? stage_id { get; set; }
//	public string? group_id { get; set; }
//}

//[Table("faculty")]
//public class Faculty
//{
//	[Key]
//	public int faculty_id { get; set; }
//	public string? faculty_name { get; set; }
//	public string? faculty_name_in_khmer { get; set; }
//}

//[Table("change_field")]
//public class change_field
//{
//	[Key]
//	public int change_id { get; set; }
//	public DateTime? change_date { get; set; }
//	public string? student_id { get; set; }
//	public int? old_field_id { get; set; }
//	public int? new_field_id { get; set; }
//	public string? user_name { get; set; }
//	public string? degree_id { get; set; }
//	public string? school_id { get; set; }
//	public string? school_id_new { get; set; }
//	public string? promotion_id { get; set; }
//	public string? stage_id { get; set; }
//	public string? term_no { get; set; }
//	public string? group_id { get; set; }
//}

//[Table("complement_failed_course_score")]
//public class complement_failed_course_score
//{
//	[Key]
//	public int complement_failed_course_score_id { get; set; }
//	public string? student_id { get; set; }
//	public int term_no { get; set; }
//	public int course_id { get; set; }
//	public float mid_term_score { get; set; }
//	public float final_score { get; set; }
//	public string? username { get; set; }
//	public DateTime? date_edit { get; set; }
//}

//[Table("complement_oriented_course_score")]
//public class complement_oriented_course_score
//{
//	[Key]
//	public int complement_oriented_course_score_id { get; set; }
//	public string? student_id { get; set; }
//	public int term_no { get; set; }
//	public int course_id { get; set; }
//	public float mid_term_score { get; set; }
//	public float final_score { get; set; }
//	public string? note { get; set; }
//	public string? username { get; set; }
//	public DateTime? date_edit { get; set; }
//}

//[Table("complement_semester_score")]
//public class complement_semester_score
//{
//	[Key]
//	public int complement_semester_score_id { get; set; }
//	public string? student_id { get; set; }
//	public int term_no { get; set; }
//	public int course_id { get; set; }
//	public float mid_term_score { get; set; }
//	public float final_score { get; set; }
//	public string? username { get; set; }
//	public DateTime? date_edit { get; set; }
//}

//[Table("contact_person")]
//public class contact_person
//{
//	[Key]
//	public int contact_person_id { get; set; }
//	public string? contact_person_name { get; set; }
//	public string? job { get; set; }
//	public string? phone { get; set; }
//	public string? address { get; set; }
//}

//[Table("course")]
//public class Course
//{
//	[Key]
//	public int course_id { get; set; }
//	public string? course_full_name { get; set; }
//	public string? course_full_name_in_khmer { get; set; }
//	public string? course_short_name { get; set; }
//	public string? course_short_name_in_khmer { get; set; }
//	public float? credit { get; set; }
//	public float? number_of_hours { get; set; }
//}

//[Table("course_code")]
//public class course_code
//{
//	[Key]
//	public int course_code_id { get; set; }
//	public int course_id { get; set; }
//	public int school_id { get; set; }
//	public int field_id { get; set; }
//	public int degree_id { get; set; }
//	public int term_no { get; set; }
//	public string? code { get; set; }
//}

//[Table("course_school")]
//public class course_school
//{
//	[Key]
//	public int school_id { get; set; }
//	public int course_id { get; set; }
//}

//[Table("course_term")]
//public class course_term
//{
//	[Key]
//	public int course_term_id { get; set; }
//	public int course_id { get; set; }
//	public int field_id { get; set; }
//	public int term_id { get; set; }
//	public float? credit { get; set; }
//	public string? type { get; set; }
//	public float? hours { get; set; }
//}
//[Table("INVOICE_TBL")]
//public class invoice_tbl
//{
//	[Key]
//	public int INVOICE_ID { get; set; }
//	public int INVOICE_NO { get; set; }
//	public string? YEAR_NUMBER { get; set; }
//	public DateTime INVOICE_DATE { get; set; }
//	public string? STUDENT_ID { get; set; }
//	public string? DEGREE_ID { get; set; }
//	public string? SCHOOL_ID { get; set; }
//	public string? FIELD_ID { get; set; }
//	public string? PROMOTION_ID { get; set; }
//	public string? STAGE_ID { get; set; }
//	public string? GROUP_ID { get; set; }
//	public DateTime STARTDATE { get; set; }
//	public DateTime ENDDATE { get; set; }
//	public string? TERM_NO { get; set; }
//	public int EXCHANGERATE_ID { get; set; }
//	public decimal VAT { get; set; }
//	public decimal GRAND_TOTAL { get; set; }
//	public string? DESCRIPTION { get; set; }
//	public string? STATUS { get; set; }
//	public decimal TOTALDOLLAR { get; set; }
//	public decimal TOTALRIEL { get; set; }
//	public decimal TOTALBATH { get; set; }
//	public decimal TOTALDISCOUNT { get; set; }
//	public bool PAYMENT { get; set; }
//	public bool CHECK_PAYMENT { get; set; }
//	public DateTime DATE_EDIT { get; set; }
//	public string? EDIT_BY { get; set; }
//	public decimal OWE { get; set; }
//	public string? OWE_REASON { get; set; }
//	public int USER_ID { get; set; }
//	public decimal TOTAL_RETURN_AMOUNT { get; set; }
//	public decimal RETURN_AMOUNT { get; set; }
//	public string? RETURN_DESCRIPTION { get; set; }
//	public decimal TOTALOTHER { get; set; }
//	public int PAYMENT_METHOD_ID { get; set; }
//	public decimal AMOUNT_DOLLAR { get; set; }
//	public decimal AMOUNT_REIL { get; set; }
//	public bool PAY_ON_APP { get; set; }
//}


//[Table("invoice_detail_tbl")]
//public class invoice_detail_tbl
//{
//	[Key]
//	public int invoice_detail_id { get; set; }
//	public int? invoice_id { get; set; }
//	public int? product_id { get; set; }
//	public int? qty { get; set; }
//	public string? qty_note { get; set; }
//	public decimal? price { get; set; }
//	public string? note { get; set; }
//	public decimal? vat { get; set; }
//	public decimal? p_dollar { get; set; }
//	public decimal? p_riel { get; set; }
//	public decimal? p_bath { get; set; }
//	public decimal? discount { get; set; }
//	public decimal? owe { get; set; }
//	public int? category_id { get; set; }
//	public decimal? other { get; set; }
//}

//[Table("lecturer")]
//public class Lecturer
//{
//	[Key]
//	public int lecturer_id { get; set; }
//	public string? name { get; set; }
//	public string? sex { get; set; }
//	public DateTime? date_of_birth { get; set; }
//	public decimal? price { get; set; }
//	public string? telephone { get; set; }
//	public int? degree_id { get; set; }
//	public int? lecturer_field_id { get; set; }
//	public int? school_id { get; set; }
//	public string? name_in_khmer { get; set; }
//}

//[Table("lecturer_branch")]
//public class lecturer_branch
//{
//	[Key]
//	public int lecturer_id { get; set; }
//	public int branch_id { get; set; }
//}

//[Table("lecturer_course")]
//public class lecturer_course
//{
//	[Key]
//	public int lecturer_id { get; set; }
//	public int course_id { get; set; }
//}

//[Table("lecturer_degree")]
//public class lecturer_degree
//{
//	[Key]
//	public int lecturer_degree_id { get; set; }
//	public string? lecturer_degree_name { get; set; }
//	public string? lecturer_degree_name_in_khmer { get; set; }
//}

//[Table("lecturer_field")]
//public class lecturer_field
//{
//	[Key]
//	public int lecturer_field_id { get; set; }
//	public string? name { get; set; }
//	public string? name_in_khmer { get; set; }
//	public int? lecturer_degree_id { get; set; }
//}

//[Table("lecturer_subject")]
//public class lecturer_subject
//{
//	[Key]
//	public int lecturer_id { get; set; }
//	public int subject_id { get; set; }
//}

//[Table("letter")]
//public class Letter
//{
//	[Key]
//	public int letter_id { get; set; }
//	public string? letter_name { get; set; }
//}

//[Table("letter_category")]
//public class letter_category
//{
//	[Key]
//	public short category_id { get; set; }
//	public string? category_name { get; set; }
//	public float? unit_price { get; set; }
//	public bool? active { get; set; }
//	public bool? is_admin { get; set; }
//	public bool? is_foundation { get; set; }
//	public bool? is_short_course { get; set; }
//}

//[Table("letter_certification")]
//public class letter_certification
//{
//	[Key]
//	public int id { get; set; }
//	public int? letter_no { get; set; }
//	public string? year_number { get; set; }
//	public int? certificate_id { get; set; }
//	public DateTime? issued_date { get; set; }
//	public bool issued_status { get; set; }
//	public string? student_id { get; set; }
//	public string? name_in_khmer { get; set; }
//	public string? name_in_english { get; set; }
//	public string? sex { get; set; }
//	public DateTime? birth_date { get; set; }
//	public string? degree { get; set; }
//	public string? school { get; set; }
//	public string? field { get; set; }
//	public string? promotion { get; set; }
//	public string? issued_no { get; set; }
//	public DateTime? received_date { get; set; }
//	public short? amount { get; set; }
//	public short? category_id { get; set; }
//	public string? other { get; set; }
//	public int? foundation_no { get; set; }
//	public int? foundation_year { get; set; }
//	public int? short_course_no { get; set; }
//	public int? short_course_year { get; set; }
//}

//[Table("minimum_gpa")]
//public class minimum_gpa
//{
//	[Key]
//	public float gpa { get; set; }
//}

//[Table("number_of_years_study")]
//public class number_of_years_study
//{
//	[Key]
//	public int number_of_years_study_id { get; set; }
//	public int degree_id { get; set; }
//	public int school_id { get; set; }
//	public int number_of_years { get; set; }
//}

//[Table("other_branch_score")]
//public class other_branch_score
//{
//	[Key]
//	public int other_branch_score_id { get; set; }
//	public string? student_id { get; set; }
//	public int term_no { get; set; }
//	public int? course_id { get; set; }
//	public string? course_name { get; set; }
//	public string? course_name_in_khmer { get; set; }
//	public int credit { get; set; }
//	public float mid_term_score { get; set; }
//	public float final_score { get; set; }
//	public int? year_start { get; set; }
//	public int? year_end { get; set; }
//	public string? username { get; set; }
//	public DateTime? date_edit { get; set; }
//}

//[Table("other_branch_score_unicode")]
//public class other_branch_score_unicode
//{
//	[Key]
//	public int? id { get; set; }
//	public string? name { get; set; }
//}

//[Table("payment")]
//public class Payment
//{
//	[Key]
//	public int payment_id { get; set; }
//	public string? student_id { get; set; }
//	public string? invoice_no { get; set; }
//	public DateTime invoice_date { get; set; }
//	public int term_no { get; set; }
//	public decimal paid { get; set; }
//	public decimal deposit { get; set; }
//	public string? note { get; set; }
//	public bool? is_insurance { get; set; }
//	public string? guardian { get; set; }
//}

//[Table("payment_method")]
//public class payment_method
//{
//	[Key]
//	public int id { get; set; }
//	public string? name { get; set; }
//	public string? name_khmer { get; set; }
//}

//[Table("payment_type")]
//public class payment_type
//{
//	[Key]
//	public int payment_type_id { get; set; }
//	public string? payment_type_name { get; set; }
//	public bool? status { get; set; }
//}

//[Table("position")]
//public class Position
//{
//	[Key]
//	public string? position_name { get; set; }
//}

//[Table("privilege")]
//public class Privilege
//{
//	[Key]
//	public int privilege_id { get; set; }
//	public string? privilege_name { get; set; }
//	public string? user_group { get; set; }
//}

//[Table("product_detail")]
//public class product_detail
//{
//	[Key]
//	public int product_detail_id { get; set; }
//	public int? product_id { get; set; }
//	public int? degree_id { get; set; }
//	public int? school_id { get; set; }
//}

//[Table("product")]
//public class Product
//{
//	[Key]
//	public int product_id { get; set; }
//	public string? product_name { get; set; }
//	public string? product_name_in_khmer { get; set; }
//	public string? description { get; set; }
//	public int? vat { get; set; }
//	public decimal? price { get; set; }
//	public string? type { get; set; }
//	public string? status { get; set; }
//	public bool? tuition_fees { get; set; }
//	public string? degree_id { get; set; }
//	public int? order_id { get; set; }
//	public int? card_certificate { get; set; }
//	public int? category_id { get; set; }
//}

//[Table("promotion")]
//public class Promotion
//{
//	[Key]
//	public int promotion_id { get; set; }
//	public int degree_id { get; set; }
//	public int school_id { get; set; }
//	public int promotion_no { get; set; }
//	public int academic_year_start { get; set; }
//	public int academic_year_end { get; set; }
//	public string? status { get; set; }
//	public DateTime? graduate_date1 { get; set; }
//	public DateTime? graduate_date2 { get; set; }
//}

//[Table("province")]
//public class Province
//{
//	[Key]
//	public int province_id { get; set; }
//	public string? province_name { get; set; }
//	public string? province_name_in_khmer { get; set; }
//	public int is_city { get; set; }
//}
//[Table("degrees")]
//public class Degrees
//{
//	[Key]
//	public int degree_id { get; set; }
//	public string? degree { get; set; }
//	public string? degree_in_khmer { get; set; }
//}

//[Table("field")]
//public class Field
//{
//	[Key]
//	public int field_id { get; set; }
//	public string? field_name { get; set; }
//	public string? field_name_in_khmer { get; set; }
//	public int school_id { get; set; }
//	[ForeignKey("school_id")]
//	public School? school { get; set; }
//	public int degree_id { get; set; }
//	[ForeignKey("degree_id")]
//	public Degrees? degree { get; set; }
//	public string? degree_name { get; set; }
//	public string? degree_name_in_khmer { get; set; }
//	public bool? type { get; set; }
//}
//[Table("qr_code_certificate")]
//public class qr_code_certificate
//{
//	[Key]
//	public string? id { get; set; }
//	public string? student_id { get; set; }
//	public string? student_name { get; set; }
//	public string? student_name_khmer { get; set; }
//	public string? sex { get; set; }
//	public string? dob { get; set; }
//	public string? dob_khmer { get; set; }
//	public string? status { get; set; }
//	public int? degree_id { get; set; }
//	public string? degree_name { get; set; }
//	public string? degree_name_khmer { get; set; }
//	public int? school_id { get; set; }
//	public string? school_name { get; set; }
//	public string? school_name_khmer { get; set; }
//	public int? field_id { get; set; }
//	public string? field_name { get; set; }
//	public string? field_name_khmer { get; set; }
//	public string? type { get; set; }
//	public int? promotion_id { get; set; }
//	public int? promotion_no { get; set; }
//	public int? stage_no { get; set; }
//	public string? group_name { get; set; }
//	public string? photo { get; set; }
//	public string? graduate_date { get; set; }
//	public string? graduate_date_khmer { get; set; }
//	public string? url { get; set; }
//	public string? document_key { get; set; }
//	public string? qr_code_data { get; set; }
//	public string? certificate_code { get; set; }
//	public bool? locked { get; set; }
//	public DateTime? date { get; set; }
//}

//[Table("qr_code_certificate_history")]
//public class qr_code_certificate_history : qr_code_certificate
//{
//	public DateTime? reset_date { get; set; }
//}

//[Table("questionable_student")]
//public class questionable_student
//{
//	[Key]
//	public int questionable_student_id { get; set; }
//	public string? student_id { get; set; }
//	public string? note { get; set; }
//}

//[Table("quit")]
//public class Quit
//{
//	[Key]
//	public int quit_id { get; set; }
//	public string? student_id { get; set; }
//	public int term_no { get; set; }
//	public DateTime quit_date { get; set; }
//	public string? reason_of_quit { get; set; }
//	public int? group_id { get; set; }
//	public int? promotion_id { get; set; }
//}

//[Table("reexam_date")]
//public class reexam_date
//{
//	[Key]
//	public int reexam_date_id { get; set; }
//	public int course_term_id { get; set; }
//	public int time { get; set; }
//	public DateTime date { get; set; }
//}

//[Table("reexam_score")]
//public class reexam_score
//{
//	[Key]
//	public int reexam_score_id { get; set; }
//	public int student_group_id { get; set; }
//	public int course_id { get; set; }
//	public int time { get; set; }
//	public float score { get; set; }
//}

//[Table("registry")]
//public class Registry
//{
//	[Key]
//	public int registration_id { get; set; }
//	public string? student_id { get; set; }
//	public int degree_id { get; set; }
//	public int school_id { get; set; }
//	public int promotion_no { get; set; }
//	public int stage_no { get; set; }
//	public int term_no { get; set; }
//	public string? study_time { get; set; }
//	public DateTime registration_date { get; set; }
//	public DateTime done_date { get; set; }
//	public string? high_school_result { get; set; }
//	public int? high_school_table_no { get; set; }
//	public string? update_by { get; set; }
//	public DateTime? update_date { get; set; }
//}

//[Table("report_of_student_total_score")]
//public class report_of_student_total_score
//{
//	[Key]
//	public string? student_id { get; set; }
//	public string? student_name { get; set; }
//	public string? student_name_in_khmer { get; set; }
//	public string? sex { get; set; }
//	public DateTime? date_of_birth { get; set; }
//	public string? phone { get; set; }
//	public float? total_score { get; set; }
//}

//[Table("report_page_margin")]
//public class report_page_margin
//{
//	[Key]
//	public int report_page_margin_id { get; set; }
//	public string? report_name { get; set; }
//	public int top { get; set; }
//	public int bottom { get; set; }
//	public int left { get; set; }
//	public int right { get; set; }
//}

//[Table("report_temp_student_fail_study")]
//public class report_temp_student_fail_study
//{
//	[Key]
//	public string? student_name { get; set; }
//	public string? student_name_in_khmer { get; set; }
//	public string? sex { get; set; }
//	public string? phone { get; set; }
//	public DateTime? date_of_birth { get; set; }
//	public string? nationality { get; set; }
//	public string? nationality_in_khmer { get; set; }
//	public string? province { get; set; }
//	public string? province_in_khmer { get; set; }
//	public string? school_name { get; set; }
//	public string? school_name_in_khmer { get; set; }
//	public string? status { get; set; }
//	public string? degree { get; set; }
//	public string? course_full_name { get; set; }
//	public string? course_full_name_in_khmer { get; set; }
//	public float? credit { get; set; }
//	public float? number_of_hours { get; set; }
//	public int? term_no { get; set; }
//	public float? mid_term_score { get; set; }
//	public float? final_score { get; set; }
//	public float? total { get; set; }
//	public int? promotion_no { get; set; }
//	public int? stage_no { get; set; }
//	public string? student_id { get; set; }
//}

//[Table("restudy_tbl")]
//public class restudy_tbl
//{
//	[Key]
//	public int restudy_id { get; set; }
//	public int? term_no { get; set; }
//	public int? course_id { get; set; }
//	public string? course_full_name { get; set; }
//	public int? replace_course_id { get; set; }
//	public string? replace_course_full_name { get; set; }
//	public string? note { get; set; }
//	public string? student_id { get; set; }
//}

//[Table("resume")]
//public class Resume
//{
//	[Key]
//	public int resume_id { get; set; }
//	public DateTime date_payment { get; set; }
//	public string? student_id { get; set; }
//	public int field_id { get; set; }
//	public int f_promotion { get; set; }
//	public int f_year { get; set; }
//	public int f_semester { get; set; }
//	public int c_promotion { get; set; }
//	public string? stage { get; set; }
//	public int c_year { get; set; }
//	public int c_semester { get; set; }
//	public string? other { get; set; }
//	public string? type { get; set; }
//}

[Table("room")]
public class Room
{
    [Key]
    public int room_id { get; set; }
    public string? room_name { get; set; }
    public int? capacity { get; set; }
    public string? room_type { get; set; }
}
//[Table("school")]
//public class School
//{
//	[Key]
//	public int school_id { get; set; }
//	public string? school_name { get; set; }
//	public string? school_name_in_khmer { get; set; }
//	public string? school_code { get; set; }
//	public int? faculty_id { get; set; }
//	public int is_foundation_school { get; set; }
//}
//[Table("score")]
//public class Score
//{
//	[Key]
//	public int score_id { get; set; }
//	public int student_group_id { get; set; }
//	public int course_id { get; set; }
//	public float? mid_term_score { get; set; }
//	public float? final_score { get; set; }
//	public string? username { get; set; }
//	public DateTime? date_edit { get; set; }
//	public string? update_by { get; set; }
//	public DateTime? update_date { get; set; }
//	public bool? is_allow { get; set; }
//}

//[Table("score_history")]
//public class score_history
//{
//	[Key]
//	public int score_history_id { get; set; }
//	public string? student_id { get; set; }
//	public int course_id { get; set; }
//	public float mid_term_score { get; set; }
//	public float final_score { get; set; }
//	public int term_no { get; set; }
//	public int time { get; set; }
//	public string? username { get; set; }
//	public DateTime? date_edit { get; set; }
//}

//[Table("score_history_update")]
//public class score_history_update
//{
//	[Key]
//	public int score_id { get; set; }
//	public string? student_id { get; set; }
//	public int course_id { get; set; }
//	public float? mid_term_score { get; set; }
//	public float? final_score { get; set; }
//	public string? username { get; set; }
//	public DateTime? date_edit { get; set; }
//}

//[Table("spo_report_student_group_statistic")]
//public class spo_report_student_group_statistic
//{
//	[Key]
//	public int? promotion_no { get; set; }
//	public int? stage_no { get; set; }
//	public int? term_id { get; set; }
//	public int? term_no { get; set; }
//	public DateTime? start_date { get; set; }
//	public DateTime? end_date { get; set; }
//	public DateTime? academic_year_start { get; set; }
//	public DateTime? academic_year_end { get; set; }
//	public int? group_id { get; set; }
//	public string? group_name { get; set; }
//	public int? school_id { get; set; }
//	public string? school_name { get; set; }
//	public string? school_name_in_khmer { get; set; }
//	public int? field_id { get; set; }
//	public string? field_name { get; set; }
//	public int? degree_id { get; set; }
//	public string? degree { get; set; }
//	public string? room_name { get; set; }
//	public int? total_female { get; set; }
//	public int? total_student { get; set; }
//}

[Table("sponsor")]
public class Sponsor
{
    [Key]
    public int sponsor_id { get; set; }
    public string? sponsor_name { get; set; }
    public string? sponsor_name_in_khmer { get; set; }
    public string? position { get; set; }
    public string? note { get; set; }
}

//[Table("stage")]
//public class Stage
//{
//	[Key]
//	public int stage_id { get; set; }
//	public int promotion_id { get; set; }
//	public int stage_no { get; set; }
//	public string? status { get; set; }
//}

//[Table("start_promotion")]
//public class start_promotion
//{
//	[Key]
//	public int start_promotion_id { get; set; }
//	public int degree_id { get; set; }
//	public int school_id { get; set; }
//	public int promotion_no { get; set; }
//}

//[Table("statement")]
//public class Statement
//{
//	[Key]
//	public int statement_id { get; set; }
//	public string? student_id { get; set; }
//	public int term_no { get; set; }
//	public DateTime statement_date { get; set; }
//	public DateTime due_date { get; set; }
//	public string? note { get; set; }
//}

//[Table("student")]
//public class Student
//{
//	[Key, Required, NotNull]
//	public string? student_id { get; set; }
//	public string? student_name { get; set; }
//	public string? student_name_in_khmer { get; set; }
//	public string? sex { get; set; }
//	public DateTime date_of_birth { get; set; }
//	public int? place_of_birth_id { get; set; }
//	public int? race_id { get; set; }
//	public int? nationality_id { get; set; }
//	public string? marital_status { get; set; }
//	public int? high_school_graduated_year { get; set; }
//	public int? from_province_id { get; set; }
//	public string? from_high_school_name_in_khmer { get; set; }
//	public int? job_id { get; set; }
//	public string? mother_name_in_khmer { get; set; }
//	public string? mother_occupation_in_khmer { get; set; }
//	public string? father_name_in_khmer { get; set; }
//	public string? father_occupation_in_khmer { get; set; }
//	public string? phone { get; set; }
//	public string? email { get; set; }
//	public string? address { get; set; }
//	public string? address_in_khmer { get; set; }
//	public int? contact_person_id { get; set; }
//	public int field_id { get; set; }
//	public int? is_photo_received { get; set; }
//	public string? note { get; set; }
//	public string? status { get; set; }
//	public int? is_continued_student { get; set; }
//	public int? associate_to_bachelor { get; set; }
//	public string? approved_date { get; set; }
//	public string? graduate_letter_no { get; set; }
//	public bool? is_accept_certificate { get; set; }
//	public DateTime? accept_date { get; set; }
//	public string? certificate_no { get; set; }
//	public bool? certificate_out { get; set; }
//	public byte[]? photo { get; set; }
//	public bool? card_is_print { get; set; }
//	public DateTime? print_date { get; set; }
//	public bool? found_certificate_is_print { get; set; }
//	// public bool? check_complete { get; set; }
//	// public string? check_complete_note { get; set; }
//	// public int? check_complete_term { get; set; }
//	// public int? disability_id { get; set; }
//	// public string? document_in { get; set; }
//	// public string? document_out { get; set; }
//	// public string? note_ticket { get; set; }
//	public string? update_by { get; set; }
//	public DateTime? update_date { get; set; }
//	public bool? is_authenticated { get; set; }
//	public string? authenticated_no { get; set; }
//	public string? url { get; set; }
//	public string? document_key { get; set; }
//	// public string? qr_code_data { get; set; }
//	public int? count_print { get; set; }
//	public bool? is_print_certificate { get; set; }
//	public bool? is_request { get; set; }
//	public DateTime? graduation_date { get; set; }
//	public string? certificate_code { get; set; }
//	public bool? ignor { get; set; }
//	public string? ignor_reason { get; set; }
//	public bool? locked { get; set; }
//}

//[Table("student_absent_record")]
//public class student_absent_record
//{
//	[Key]
//	public int absent_record_id { get; set; }
//	public string? student_id { get; set; }
//	public int? term_no { get; set; }
//	public int? month1 { get; set; }
//	public int? month2 { get; set; }
//	public int? month3 { get; set; }
//	public int? month4 { get; set; }
//	public int? month5 { get; set; }
//}

//[Table("student_absent_record_new")]
//public class student_absent_record_new
//{
//	[Key]
//	public int absent_record_id { get; set; }
//	public string? student_id { get; set; }
//	public int? term_no { get; set; }
//	public int? subject01 { get; set; }
//	public int? subject02 { get; set; }
//	public int? subject03 { get; set; }
//	public int? subject04 { get; set; }
//	public int? subject05 { get; set; }
//	public int? subject06 { get; set; }
//	public DateTime? date_absent { get; set; }
//}

//[Table("student_certificate")]
//public class student_certificate
//{
//	[Key]
//	public int student_certificate_id { get; set; }
//	public string? student_id { get; set; }
//	public int certificate_id { get; set; }
//	public string? grade { get; set; }
//	public int? is_received { get; set; }
//	public string? certificate_issue_no { get; set; }
//}

//[Table("student_certificate_return")]
//public class student_certificate_return
//{
//	[Key]
//	public int student_certificate_return_id { get; set; }
//	public DateTime? return_date { get; set; }
//	public string? student_id { get; set; }
//	public int? certificate_id { get; set; }
//	public int? recieve_picture { get; set; }
//	public string? other { get; set; }
//}
[Table("study_time")]
public class study_times
{
    [Key]
    public string? study_time { get; set; }
}

//[Table("suppress")]
//public class Suppress
//{
//	[Key]
//	public int suppress_id { get; set; }
//	public string? student_id { get; set; }
//	public int term_no { get; set; }
//	public DateTime suppress_date { get; set; }
//	public DateTime? express_date { get; set; }
//	public string? reason_of_suppress { get; set; }
//}

//[Table("suppress_new")]
//public class suppress_new
//{
//	[Key]
//	public int suppress_id { get; set; }
//	public string? student_id { get; set; }
//	public int term_no { get; set; }
//	public DateTime suppress_date { get; set; }
//	public DateTime? express_date { get; set; }
//	public string? reason_of_suppress { get; set; }
//}

//[Table("suspend")]
//public class Suspend
//{
//	[Key]
//	public int suspend_id { get; set; }
//	public string? student_id { get; set; }
//	public int term_no { get; set; }
//	public int group_id { get; set; }
//	public int promotion_id { get; set; }
//	public DateTime from_date { get; set; }
//	public DateTime to_date { get; set; }
//	public string? reason_of_suspend { get; set; }
//}

//[Table("term")]
//public class Term
//{
//	[Key]
//	public int term_id { get; set; }
//	public int stage_id { get; set; }
//	public int term_no { get; set; }
//	public DateTime start_date { get; set; }
//	public DateTime end_date { get; set; }
//	public int academic_year_start { get; set; }
//	public int academic_year_end { get; set; }
//	public string? status { get; set; }
//	public DateTime? start_payment_date { get; set; }
//}

//[Table("Group")]
//public class Group
//{
//	[Key]
//	public int group_id { get; set; }
//	public string? group_name { get; set; }
//	public string? study_time { get; set; }
//	public int stage_id { get; set; }
//	public int field_id { get; set; }
//	public int created_in_term_no { get; set; }
//	public string? note { get; set; }
//}

//[Table("group_room")]
//public class GroupRoom
//{
//	[Key]
//	public int group_room_id { get; set; }
//	public int group_id { get; set; }
//	public int term_no { get; set; }
//	public string? room_name { get; set; }
//	public DateTime start_payment { get; set; }
//}

//[Table("test_score")]
//public class test_score
//{
//	[Key]
//	public int score_id { get; set; }
//	public int student_group_id { get; set; }
//	public int course_id { get; set; }
//	public float? mid_term_score { get; set; }
//	public float? final_score { get; set; }
//}

//[Table("time_table")]
//public class time_table
//{
//	[Key]
//	public int time_table_id { get; set; }
//	public string? grouping_day { get; set; }
//	public string? part_of_day { get; set; }
//	public string? time { get; set; }
//}

//[Table("tuition_fee")]
//public class tuition_fee
//{
//	[Key]
//	public int tuition_fee_id { get; set; }
//	public int promotion_id { get; set; }
//	public int term_no { get; set; }
//	public decimal fee { get; set; }
//}

[Table("university")]
public class University
{
    [Key]
    public int university_id { get; set; }
    public string? university_name { get; set; }
    public string? university_name_in_khmer { get; set; }
    public string? abbreviation_name { get; set; }
}

//[Table("user")]
//public class User
//{
//	[Key]
//	public int user_id { get; set; }
//	public string? user_name { get; set; }
//	public string? password { get; set; }
//	public string? user_group { get; set; }
//	public string? status { get; set; }
//}

//[Table("user_privilege")]
//public class user_privilege
//{
//	[Key]
//	public int user_privilege_id { get; set; }
//	public int user_id { get; set; }
//	public int privilege_id { get; set; }
//}

//[Table("user_school")]
//public class user_school
//{
//	[Key]
//	public int user_school_id { get; set; }
//	public int user_id { get; set; }
//	public int school_id { get; set; }
//}

//[Table("re_examination_result")]
//public class re_examination_result
//{
//	[Key]
//	public string? student_id { get; set; }
//	public string? student_name { get; set; }
//	public string? student_name_in_khmer { get; set; }
//	public string? sex { get; set; }
//	public DateTime date_of_birth { get; set; }
//	public int course_id { get; set; }
//	public string? course_full_name { get; set; }
//	public int term_no { get; set; }
//	public int group_id { get; set; }
//	public string? group_name { get; set; }
//	public string? study_time { get; set; }
//	public int stage_id { get; set; }
//	public int stage_no { get; set; }
//	public int promotion_id { get; set; }
//	public int promotion_no { get; set; }
//	public int degree_id { get; set; }
//	public int school_id { get; set; }
//	public string? school_name { get; set; }
//	public string? school_name_in_khmer { get; set; }
//	public int field_id { get; set; }
//	public string? field_name { get; set; }
//	public string? field_name_in_khmer { get; set; }
//	public float mid_term_score { get; set; }
//	public float final_score { get; set; }
//	public float total_score { get; set; }
//}

//[Table("report_student_quit")]
//public class report_student_quit
//{
//	[Key]
//	public string? student_id { get; set; }
//	public string? student_name { get; set; }
//	public string? student_name_in_khmer { get; set; }
//	public string? sex { get; set; }
//	public DateTime? date_of_birth { get; set; }
//	public int? stage_id { get; set; }
//	public int? stage_no { get; set; }
//	public int? school_id { get; set; }
//	public string? school_name { get; set; }
//	public string? school_name_in_khmer { get; set; }
//	public int? term_no { get; set; }
//	public int? promotion_id { get; set; }
//	public int? promotion_no { get; set; }
//	public int? group_id { get; set; }
//	public string? group_name { get; set; }
//	public int? quit_id { get; set; }
//	public int? field_id { get; set; }
//	public string? field_name { get; set; }
//	public string? field_name_in_khmer { get; set; }
//	public int? degree_id { get; set; }
//	public string? degree { get; set; }
//	public string? degree_in_khmer { get; set; }
//}

//[Table("student_statistic_by_age")]
//public class student_statistic_by_age
//{
//	[Key]
//	public string? age { get; set; }
//	public int? year1_pass_total { get; set; }
//	public int? year1_pass_female { get; set; }
//	public int? year1_fail_total { get; set; }
//	public int? year1_fail_female { get; set; }
//	public int? year2_pass_total { get; set; }
//	public int? year2_pass_female { get; set; }
//	public int? year2_fail_total { get; set; }
//	public int? year2_fail_female { get; set; }
//	public int? year3_pass_total { get; set; }
//	public int? year3_pass_female { get; set; }
//	public int? year3_fail_total { get; set; }
//	public int? year3_fail_female { get; set; }
//	public int? year4_pass_total { get; set; }
//	public int? year4_pass_female { get; set; }
//	public int? year4_fail_total { get; set; }
//	public int? year4_fail_female { get; set; }
//	public int? year5_pass_total { get; set; }
//	public int? year5_pass_female { get; set; }
//	public int? year5_fail_total { get; set; }
//	public int? year5_fail_female { get; set; }
//	public int? total_pass { get; set; }
//	public int? total_pass_female { get; set; }
//	public int? total_fail { get; set; }
//	public int? total_fail_female { get; set; }
//}

//[Table("student_statistic_by_field")]
//public class student_statistic_by_field
//{
//	[Key]
//	public int field_id { get; set; }
//	public string? field_name { get; set; }
//	public string? field_name_in_khmer { get; set; }
//	public int? year1_pass_total { get; set; }
//	public int? year1_pass_female { get; set; }
//	public int? year1_fail_total { get; set; }
//	public int? year1_fail_female { get; set; }
//	public int? year2_pass_total { get; set; }
//	public int? year2_pass_female { get; set; }
//	public int? year2_fail_total { get; set; }
//	public int? year2_fail_female { get; set; }
//	public int? year3_pass_total { get; set; }
//	public int? year3_pass_female { get; set; }
//	public int? year3_fail_total { get; set; }
//	public int? year3_fail_female { get; set; }
//	public int? year4_pass_total { get; set; }
//	public int? year4_pass_female { get; set; }
//	public int? year4_fail_total { get; set; }
//	public int? year4_fail_female { get; set; }
//	public int? year5_pass_total { get; set; }
//	public int? year5_pass_female { get; set; }
//	public int? year5_fail_total { get; set; }
//	public int? year5_fail_female { get; set; }
//	public int? total_pass { get; set; }
//	public int? total_pass_female { get; set; }
//	public int? total_fail { get; set; }
//	public int? total_fail_female { get; set; }
//}

//[Table("verify_qr_code_authorization")]
//public class verify_qr_code_authorization
//{
//	[Key]
//	public int id { get; set; }
//	public string? base_url { get; set; }
//	public string? api_key_associate { get; set; }
//	public string? api_secret_associate { get; set; }
//	public string? api_key_bachelor { get; set; }
//	public string? api_secret_bachelor { get; set; }
//	public string? api_key_master { get; set; }
//	public string? api_secret_master { get; set; }
//	public string? api_key_doctor { get; set; }
//	public string? api_secret_doctor { get; set; }
//	public string? end_point_url { get; set; }
//	public string? type { get; set; }
//	public bool? allow { get; set; }
//}

//[Table("virtual_view_student_statistic1")]
//public class virtual_view_student_statistic1
//{
//	[Key]
//	public int field_id { get; set; }
//	public string? academic_year { get; set; }
//	public int term_no { get; set; }
//	public int? year { get; set; }
//	public string? student_id { get; set; }
//	public string? sex { get; set; }
//	public string? student_name { get; set; }
//	public string? status { get; set; }
//	public DateTime date_of_birth { get; set; }
//	public int degree_id { get; set; }
//}

//[Table("virtual_view_student_statistic2")]
//public class virtual_view_student_statistic2
//{
//	[Key]
//	public int field_id { get; set; }
//	public string? academic_year { get; set; }
//	public int term_no { get; set; }
//	public int? year { get; set; }
//	public string? student_id { get; set; }
//	public string? sex { get; set; }
//	public string? student_name { get; set; }
//	public string? status { get; set; }
//	public DateTime date_of_birth { get; set; }
//	public int degree_id { get; set; }
//}
