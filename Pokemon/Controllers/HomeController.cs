using Microsoft.AspNetCore.Mvc;
using Pokemon.Models;
using PokePoke.Core.Application.Interfaces.Services;
using PokePoke.Core.Application.Services;
using System.Diagnostics;

namespace Pokemon.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPokemonServices pokemonService;
        public HomeController(IPokemonServices pokemonService)
        {
            this.pokemonService = pokemonService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await pokemonService.GetAllVm());
        }

    }
}