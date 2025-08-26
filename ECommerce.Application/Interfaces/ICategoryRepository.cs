using ECommerce.Domain.Models;

namespace ECommerce.Application.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task<Category> AddAsync(Product product);
        Task UpdateAsync(Category product);
        Task DeleteAsync(int id);
    }
}
