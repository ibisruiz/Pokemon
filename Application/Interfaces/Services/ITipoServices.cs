using PokePoke.Core.Application.ViewModels.Tipo;

namespace PokePoke.Core.Application.Interfaces.Services
{
    public interface ITipoServices
    {
        Task<List<TipoViewModel>> GetAllVm();
        Task Add(SaveTipoViewModel vm);
        Task<SaveTipoViewModel> GetByIdSaveVM(int id);
        Task Update(SaveTipoViewModel vm);
        Task Delete(int id);

    }
}
