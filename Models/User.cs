using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model
{
    [Table("user")]
    public class User
    {
        [Key]
        public int user_id { get; set; }
        public string? user_name { get; set; }
        public string? password { get; set; }
        public string? user_group { get; set; }
        public string? status { get; set; }
    }
}

