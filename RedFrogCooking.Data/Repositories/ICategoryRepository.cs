using RedFrogCooking.Data.Model;

namespace RedFrogCooking.Data.Repositories
{
    public interface ICategoryRepository
    {
        Task Add(MenuCategory category);
        Task Delete(string id);
        Task<IEnumerable<MenuCategory>> GetCategories();
        Task<MenuCategory?> GetCategoryById(string Id);
        Task Update(MenuCategory category);
    }
}