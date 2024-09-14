using RedFrogCooking.Data.Model;

namespace RedFrogCooking.Data.Repositories
{
    public interface IMenuItemRepository
    {
        Task<IEnumerable<MenuItem>> GetMenuItems();
    }
}