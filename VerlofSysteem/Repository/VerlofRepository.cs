using VerlofSysteem.Context;
using VerlofSysteem.Models;

namespace VerlofSysteem.Repository;

public class VerlofRepository : IVerlofRepository
{
    private readonly VerlofDbContext _context;

    public VerlofRepository(VerlofDbContext context)
    {
        _context = context;
    }
    
    public Verlof Add(Verlof verlof)
    {
        throw new NotImplementedException();
    }
    
    public Verlof Delete(int Id)
    {
        throw new NotImplementedException();
    }
    
    public IEnumerable<Verlof> GetAllVerlof()
    {
        return _context.Verlofs;
    }
    
    public Verlof GetVerlof(int Id)
    {
        throw new NotImplementedException();
    }
    
    public Verlof Update(Verlof verlof)
    {
        throw new NotImplementedException();
    }
}