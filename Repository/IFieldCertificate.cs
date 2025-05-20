namespace BBU_SYSTEM.Respository;

public interface IFieldCertificate
{
    public Task<IEnumerable<FieldCertificate>> get(string campus);
    //Task<FieldCertificate> get(string campus, int id);
}