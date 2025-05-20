using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
namespace BBU_SYSTEM.Models
{
    [Table("student")]
    public class Student
    {
        [Key, Required, NotNull]
        public string? student_id { get; set; }
        public string? student_name { get; set; }
        public string? student_name_in_khmer { get; set; }
        public string? sex { get; set; }
        public DateTime date_of_birth { get; set; }
        public int? place_of_birth_id { get; set; }
        public int? race_id { get; set; }
        public int? nationality_id { get; set; }
        public string? marital_status { get; set; }
        public int? high_school_graduated_year { get; set; }
        public int? from_province_id { get; set; }
        public string? from_high_school_name_in_khmer { get; set; }
        public int? job_id { get; set; }
        public string? mother_name_in_khmer { get; set; }
        public string? mother_occupation_in_khmer { get; set; }
        public string? father_name_in_khmer { get; set; }
        public string? father_occupation_in_khmer { get; set; }
        public string? phone { get; set; }
        public string? email { get; set; }
        public string? address { get; set; }
        public string? address_in_khmer { get; set; }
        public int? contact_person_id { get; set; }
        public int field_id { get; set; }
        public int? is_photo_received { get; set; }
        public string? note { get; set; }
        public string? status { get; set; }
        public int? is_continued_student { get; set; }
        public int? associate_to_bachelor { get; set; }
        public string? approved_date { get; set; }
        public string? graduate_letter_no { get; set; }
        public bool? is_accept_certificate { get; set; }
        public DateTime? accept_date { get; set; }
        public string? certificate_no { get; set; }
        public bool? certificate_out { get; set; }
        public byte[]? photo { get; set; }
        public bool? card_is_print { get; set; }
        public DateTime? print_date { get; set; }
        public bool? found_certificate_is_print { get; set; }
        public bool? checkcomplete { get; set; }
        public string? checkcompletenote { get; set; }
        public int? checkcomplete_term { get; set; }
        public int? disabilityid { get; set; }
        public string? documentin { get; set; }
        public string? documentout { get; set; }
        public string? noteticket { get; set; }
        public string? update_by { get; set; }
        public DateTime? update_date { get; set; }
        public bool? is_authenticated { get; set; }
        public string? authenticated_no { get; set; }
        public string? url { get; set; }
        public string? document_key { get; set; }
        public string? qrcode_data { get; set; }
        public int? count_print { get; set; }
        public bool? is_print_certificate { get; set; }
        public bool? is_request { get; set; }
        public DateTime? graduation_date { get; set; }
        public string? certificate_code { get; set; }
        public bool? ignor { get; set; }
        public string? ignor_reason { get; set; }
        public bool? locked { get; set; }
    }
}
