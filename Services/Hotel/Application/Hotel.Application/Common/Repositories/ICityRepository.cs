using Hotel.Domain;

namespace Hotel.Application.Common.Repositories
{
    public interface ICityRepository
    {
        Task<List<City>> GetAllAsync(bool includeDetail=true);
        Task<City> GetById(int id);
        Task<List<City>> GetByTitle(string title);
    }
}
