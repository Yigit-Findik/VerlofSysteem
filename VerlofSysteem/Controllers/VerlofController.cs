using Microsoft.AspNetCore.Mvc;
using VerlofSysteem.Models;
using VerlofSysteem.ViewModel;

namespace VerlofSysteem.Controllers
{
    public class VerlofController : Controller
    {
        [ViewData]
        public string titel { get; set; }
        public IActionResult Index()
        {
            // * Note: not particularly better, but it's using model instead of ViewData
            var newModel = new VerlofViewModel()
            {
                verlof = new Verlof
                {
                    Id = 1,
                    Gebruiker = "Jacks",
                    AanvraagDatum = DateTime.Now,
                    StartDatum = new DateTime(2023, 4, 19),
                    EindDatum = new DateTime(2023, 5, 19)
                },
                titel = "Verlof Details"
            };
            
            return View(newModel);
        }
    }
}
