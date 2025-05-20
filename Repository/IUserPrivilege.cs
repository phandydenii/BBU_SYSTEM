using System;
namespace BBU_SYSTEM.Respository
{
	public interface IUserPrivilege
	{
        public IEnumerable<object> gets(string campus);
        public IEnumerable<object> gets(string campus, int userid);
        public object get(string campus, int id);
    }
}

