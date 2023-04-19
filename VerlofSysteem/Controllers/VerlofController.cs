using Microsoft.AspNetCore.Mvc;
using VerlofSysteem.Models;

namespace VerlofSysteem.Controllers
{
    public class VerlofController : Controller
    {
        public IActionResult Index()
        {

            var verloven = new List<Verlof>
            {
                new Verlof { Id = 1, Gebruiker = "Johan", AanvraagDatum = DateTime.Now, StartDatum = new DateTime(2023, 4, 19), EindDatum = new DateTime(2023, 5, 19) },
                new Verlof { Id = 2, Gebruiker = "Jacks", AanvraagDatum = DateTime.Now, StartDatum = new DateTime(2023, 5, 19), EindDatum = new DateTime(2023, 6, 19) },
                new Verlof { Id = 3, Gebruiker = "Gabriel", AanvraagDatum = DateTime.Now, StartDatum = new DateTime(2023, 6, 19), EindDatum = new DateTime(2023, 7, 19) }
            };
            ViewData["verloven"] = verloven;
            return View();
        }
    }
}
