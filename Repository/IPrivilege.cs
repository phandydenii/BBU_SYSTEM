using System;
namespace BBU_SYSTEM.Respository
{
	public interface IPrivilege
	{
        public IEnumerable<object> gets(string campus);
        public object get(string campus, int id);
    }
}

