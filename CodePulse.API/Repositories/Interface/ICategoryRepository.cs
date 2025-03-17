using CodePulse.API.Models.Domain;

namespace CodePulse.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);

        // List of categories
        Task<IEnumerable<Category>> GetAllAsync();

        Task<Category?> GetById(Guid id);
    }
}
