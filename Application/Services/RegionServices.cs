using PokePoke.Core.Application.Interfaces.Repositories;
using PokePoke.Core.Application.Interfaces.Services;
using PokePoke.Core.Application.ViewModels.Region;
using PokePoke.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokePoke.Core.Application.Services
{
    public class RegionServices : IRegionServices
    {
        private readonly IRegionRepository regionRepository;

        //ctor
        public RegionServices(IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;        
        }

        //method
        public async Task<List<RegionViewModel>> GetAllVm()
        {
            var regionList = await regionRepository.GetAllAsync();

            return regionList.Select(region => new RegionViewModel
            {
                Id = region.Id,
                Name = region.Name
            }).ToList();
        }

        //method
        public async Task Add(SaveRegionViewModel vm)
        {
            Region region = new Region();
            region.Id = vm.Id;
            region.Name = vm.Name;

            await regionRepository.AddAsync(region);
        }

        //method
        public async Task<SaveRegionViewModel> GetByIdSaveVM(int id)
        {
            var region = await regionRepository.GetByIdAsync(id);
            SaveRegionViewModel vm = new();
            vm.Id = region.Id;
            vm.Name = region.Name;
            return vm;
        }
        //method
        public async Task Update(SaveRegionViewModel vm)
        {
            Region region = new Region();
            region.Id = vm.Id;
            region.Name = vm.Name;

            await regionRepository.UpdateAsync(region);
        }
        //method
        public async Task Delete(int id)
        {
            var region = await regionRepository.GetByIdAsync(id);
            await regionRepository.DeleteAsync(region);
        }
    }
}
