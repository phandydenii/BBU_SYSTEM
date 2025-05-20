using System;
using BBU_SYSTEM.Models;

namespace BBU_SYSTEM.Repository
{
	public interface INationality
	{
        public Task<IEnumerable<Nationality>> get(string campus);
        public Task<Nationality> get(string campus, int id);
    }
}

