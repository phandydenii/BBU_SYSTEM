using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model
{
    [Table("user_privilege")]
    public class UserPrivilege
    {
        [Key]
        public int user_privilege_id { get; set; }
        public int user_id { get; set; }
        public int privilege_id { get; set; }
    }
}

