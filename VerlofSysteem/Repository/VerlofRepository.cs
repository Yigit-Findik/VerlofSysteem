using VerlofSysteem.Models;

namespace VerlofSysteem.Repository;

public class VerlofRepository : IVerlofRepository
{
    private List<Verlof> _verlofs;

    public VerlofRepository()
    {
        //Mock data
        _verlofs = new List<Verlof>()
        {
            new Verlof(){ Id = 1, Gebruiker = "Jack", AanvraagDatum = DateTime.Now, StartDatum = DateTime.Now.AddDays(7), EindDatum = DateTime.Now.AddMonths(1) },
            new Verlof(){ Id = 2, Gebruiker = "Jason", AanvraagDatum = DateTime.Now, StartDatum = DateTime.Now.AddDays(7), EindDatum = DateTime.Now.AddMonths(1) }
        };
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
        return _verlofs;
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