using AdminTarefas.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdminTarefas.WebUI.Controllers
{
    public class EmplooyerController : Controller
    {
        private readonly IEmplooyerService _emplooyerService;
        public EmplooyerController(IEmplooyerService emplooyerService)
        {
            _emplooyerService = emplooyerService;
        }

        public async Task<IActionResult> Emplooyers()
        {
            var emplooyers = await _emplooyerService.GetEmplooyers();
            return View(emplooyers);
        }
    }
}
