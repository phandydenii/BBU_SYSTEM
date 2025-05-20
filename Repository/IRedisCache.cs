using System;
namespace BBU_SYSTEM.Respository
{
	public interface IRedisCache
	{
		T? GetT<T>(string campus);
	}
}

