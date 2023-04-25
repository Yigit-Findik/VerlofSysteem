using Microsoft.AspNetCore.Mvc;
using VerlofSysteem.Models;
using VerlofSysteem.Repository;
using VerlofSysteem.ViewModel;

namespace VerlofSysteem.Controllers
{
    public class VerlofController : Controller
    {
        private readonly IVerlofRepository _verlofRepository;
        
        public VerlofController(IVerlofRepository verlofRepository)
        {
            _verlofRepository = verlofRepository;
        }
        
        public IActionResult Index()
        {
            var verlofs = _verlofRepository.GetAllVerlof();
         
            return View(verlofs);
        }
    }
}
