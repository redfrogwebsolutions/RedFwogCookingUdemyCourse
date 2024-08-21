using RedFrogCooking.Data.Model;

namespace RedFrogCooking.Data.Repositories
{
    public interface IMenuRepository
    {
        IEnumerable<MenuCategory> GetCategories();

        IEnumerable<MenuItem> GetMenuItems();

    }
}