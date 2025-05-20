using BBU_SYSTEM.Models;

namespace BBU_SYSTEM.Respository;

public interface IProvince
{
        public Task<IEnumerable<Province>> get(string campus);
        public Task<Province> get(string campus, int id);
}