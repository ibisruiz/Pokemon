using PokePoke.Core.Application.ViewModels.Region;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokePoke.Core.Application.Interfaces.Services
{
    public interface IRegionServices
    {
        Task<List<RegionViewModel>> GetAllVm();
        Task Add(SaveRegionViewModel vm);
        Task<SaveRegionViewModel> GetByIdSaveVM(int id);
        Task Update(SaveRegionViewModel vm);
        Task Delete(int id);
    }
}
