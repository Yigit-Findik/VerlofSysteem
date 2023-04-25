using VerlofSysteem.Models;

namespace VerlofSysteem.Repository;

public interface IVerlofRepository
{
    Verlof Add(Verlof verlof);
    
    Verlof Update(Verlof verlof);
    
    Verlof Delete(int Id);
    
    Verlof GetVerlof(int Id);
    
    IEnumerable<Verlof> GetAllVerlof();
}