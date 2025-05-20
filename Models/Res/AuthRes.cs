using System;
namespace BBU_SYSTEM.Model.Res
{
	public class AuthRes
	{
        public int user_id { get; set; }
        public string? user_name { get; set; }
        public string? password { get; set; }
        public string? user_group { get; set; }
        public string? token { get; set; }
        public DateTime? expire_in { get; set; }
        public string? status { get; set; }
    }
}

