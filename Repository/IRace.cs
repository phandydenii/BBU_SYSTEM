using BBU_SYSTEM.Models;

namespace BBU_SYSTEM.Respository;

public interface IRace
{
        public Task<IEnumerable<Race>> get(string campus);
        public Task<Race> get(string campus, int id);
}