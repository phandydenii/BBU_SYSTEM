using System;
namespace BBU_SYSTEM.Repository
{
	public interface IUniversity
	{
        public Task<IEnumerable<University>> get(string campus);
        public Task<University> get(string campus, int id);
    }
}

