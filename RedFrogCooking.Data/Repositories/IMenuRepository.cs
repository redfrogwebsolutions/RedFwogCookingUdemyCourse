using RedFrogCooking.Data.Model;

namespace RedFrogCooking.Data.Repositories
{
    public interface IMenuRepository
    {
        Task<IEnumerable<MenuCategory>> GetCategories();

        Task<IEnumerable<MenuItem>> GetMenuItems();

        Task<MenuCategory?> GetCategoryById(string Id);

    }
}