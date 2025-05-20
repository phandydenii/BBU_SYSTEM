using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model
{
    [Table("CONTACT_PERSON")]
	public class ContactPerson
	{
        [Key]
        public int contact_person_id { get; set; }
        public string? contact_person_name { get; set; }
        public string? job { get; set; }
        public string? phone { get; set; }
        public string? address { get; set; }
    }
}

