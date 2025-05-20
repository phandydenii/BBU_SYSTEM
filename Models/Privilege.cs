using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model
{
    [Table("privilege")]
    public class Privilege
    {
        [Key]
        public int privilege_id { get; set; }
        public string? privilege_name { get; set; }
        public string? user_group { get; set; }
    }
}

