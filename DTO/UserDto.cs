using System;
namespace BBU_SYSTEM.DTO
{
	public class UserDto
	{
        public int user_id { get; set; }
        public string? user_name { get; set; }
        public string? password { get; set; }
        public string? user_group { get; set; }
        public string? status { get; set; }
    }
}

