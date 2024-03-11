using Microsoft.AspNetCore.Mvc;
using PokePoke.Core.Application.Interfaces.Services;
using PokePoke.Core.Application.ViewModels.Tipo;


namespace WebApp.Pokemon.Controllers
{
    public class TipoController : Controller
    {
        private readonly ITipoServices tipoServices;

        public TipoController(ITipoServices tipoServices)
        {
            this.tipoServices = tipoServices;   
        }
        public async Task<IActionResult> Index()
        {
            return View(await tipoServices.GetAllVm());
        }

        public IActionResult Create()
        {
            return View("SaveTipo", new SaveTipoViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveTipoViewModel vm)
        {
            await tipoServices.Add(vm);
            return RedirectToRoute(new { controller = "Tipo", action = "Index" });
        }

        public async Task<IActionResult> Edit(int id)
        {
            return View("SaveTipo", await tipoServices.GetByIdSaveVM(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SaveTipoViewModel vm)
        {
            await tipoServices.Update(vm);
            return RedirectToRoute(new { controller = "Tipo", action = "Index" });
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View(await tipoServices.GetByIdSaveVM(id));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            await tipoServices.Delete(id);
            return RedirectToRoute(new { controller = "Tipo", action = "Index" });
        }


        // ced copy // const estudio // miercoles 17
    }
}
