using System;
using BBU_SYSTEM.DTO;

namespace BBU_SYSTEM.Respository
{
	public interface IDisability
	{
        public object get(string campus);
        public object get(string campus, int id);
        public object add(string campus, DisabilityDto req);
    }
}

