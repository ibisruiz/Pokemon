using Microsoft.AspNetCore.Mvc;
using PokePoke.Core.Application.Interfaces.Services;
using PokePoke.Core.Application.Services;
using PokePoke.Core.Application.ViewModels.Region;

namespace WebApp.Pokemon.Controllers
{
    public class RegionController : Controller
    {
        private readonly IRegionServices regionServices;

        public RegionController(IRegionServices regionServices)
        {
            this.regionServices = regionServices;
        }

        public async Task<IActionResult> Index()
        {
            return View(await regionServices.GetAllVm());
        }

        public IActionResult Create()
        {
            return View("SaveRegion", new SaveRegionViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveRegionViewModel vm)
        {            
            await regionServices.Add(vm);
            return RedirectToRoute(new { controller = "Region", action = "Index" });
        }

        public async Task<IActionResult> Edit(int id)
        {
            return View("SaveRegion", await regionServices.GetByIdSaveVM(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SaveRegionViewModel vm)
        {
            await regionServices.Update(vm);
            return RedirectToRoute(new { controller = "Region", action = "Index" });
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View(await regionServices.GetByIdSaveVM(id));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            await regionServices.Delete(id);
            return RedirectToRoute(new { controller = "Region", action = "Index" });
        }




    }
}
