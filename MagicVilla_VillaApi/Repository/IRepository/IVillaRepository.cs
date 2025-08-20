using MagicVilla_VillaApi.Models;
using static MagicVilla_VillaApi.Repository.IRepository.IRepository;

namespace MagicVilla_VillaApi.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {

        Task<Villa> UpdateAsync(Villa entity);

    }
}
