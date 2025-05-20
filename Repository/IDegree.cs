using System;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;

namespace BBU_SYSTEM.Repository
{
	public interface IDegree
	{
		public IEnumerable<object> gets(string campus);
		public object get(string campus,int id);
		public object add(string campus,DegreeDto req);
		public object update(string campus,int id,DegreeDto req);
		public bool delete(string campus,int id);

	}
}

