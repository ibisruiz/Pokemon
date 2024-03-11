using PokePoke.Core.Application.Interfaces.Repositories;
using PokePoke.Core.Application.Interfaces.Services;
using PokePoke.Core.Application.ViewModels.Tipo;
using PokePoke.Core.Domain.Entities;

namespace PokePoke.Core.Application.Services
{
    public class TipoService : ITipoServices
    {
        private readonly ITipoRepository tipoRepository;

        //ctor
        public TipoService(ITipoRepository tipoRepository)
        {
            this.tipoRepository = tipoRepository;        
        }

        //method
        public async Task<List<TipoViewModel>> GetAllVm()
        {
            var tipoList = await tipoRepository.GetAllAsync();

            return tipoList.Select(tipo => new TipoViewModel
            {
                Id = tipo.Id,
                Name = tipo.Name
            }).ToList();
        }

        //method
        public async Task Add(SaveTipoViewModel vm)
        {
            Tipo tipo = new Tipo();
            tipo.Id = vm.Id;
            tipo.Name = vm.Name;

            await tipoRepository.AddAsync(tipo);
        }

        //method
        public async Task<SaveTipoViewModel> GetByIdSaveVM(int id)
        {
            var tipo = await tipoRepository.GetByIdAsync(id);
            SaveTipoViewModel vm = new();
            vm.Id = tipo.Id;
            vm.Name = tipo.Name;
            return vm;
        }
        //method
        public async Task Update(SaveTipoViewModel vm)
        {
            Tipo tipo = new Tipo();
            tipo.Id = vm.Id;
            tipo.Name = vm.Name;

            await tipoRepository.UpdateAsync(tipo);
        }
        //method
        public async Task Delete(int id)
        {
            var tipo = await tipoRepository.GetByIdAsync(id);
            await tipoRepository.DeleteAsync(tipo);
        }
    }
}
