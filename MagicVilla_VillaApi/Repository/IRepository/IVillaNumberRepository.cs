using MagicVilla_VillaApi.Models;
using static MagicVilla_VillaApi.Repository.IRepository.IRepository;

namespace MagicVilla_VillaApi.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {

        Task<VillaNumber> UpdateAsync(VillaNumber entity);

    }
}
