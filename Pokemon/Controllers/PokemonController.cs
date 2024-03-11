using Microsoft.AspNetCore.Mvc;
using PokePoke.Core.Application.Interfaces.Services;
using PokePoke.Core.Application.ViewModels.Pokemon;

namespace WebApp.Pokemon.Controllers
{
    public class PokemonController : Controller
    {
        private readonly IPokemonServices pokemonService;
        private readonly IRegionServices regionService;
        private readonly ITipoServices tipoService;

        public PokemonController(IPokemonServices pokemonService, IRegionServices regionService, ITipoServices tipoService)
        {
            this.pokemonService = pokemonService;
            this.regionService = regionService;
            this.tipoService = tipoService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await pokemonService.GetAllVm());
        }

        public async Task<IActionResult> Create() 
        {
            SavePokemonViewModel vm = new SavePokemonViewModel();
            vm.Regiones = await regionService.GetAllVm();
            vm.Tipos = await tipoService.GetAllVm();
            return View("SavePokemon", vm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SavePokemonViewModel vm)
        {
            await pokemonService.Add(vm);
            return RedirectToRoute(new { controller = "Pokemon", action = "Index" });
        }
    }
}
