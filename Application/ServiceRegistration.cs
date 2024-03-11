using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PokePoke.Core.Application.Interfaces.Repositories;
using PokePoke.Core.Application.Interfaces.Services;
using PokePoke.Core.Application.Services;

namespace PokePoke.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
        {            
            #region Repositories
            services.AddTransient<IPokemonServices, PokemonServices>();
            services.AddTransient<IRegionServices, RegionServices>();
            services.AddTransient<ITipoServices, TipoService>();
            #endregion

        }
    }
}
