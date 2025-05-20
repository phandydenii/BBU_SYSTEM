using System;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.ViewModel;

namespace BBU_SYSTEM.Respository
{
	public interface IRegistry
	{
        public IEnumerable<object> get(string campus);
        public IEnumerable<object> get(string campus, DateTime from, DateTime todate);
        public IEnumerable<object> get(string campus, FilterModel filter);
        public object get(string campus,string id);
        public object add(string campus,RegistryDto req);
    }
}

