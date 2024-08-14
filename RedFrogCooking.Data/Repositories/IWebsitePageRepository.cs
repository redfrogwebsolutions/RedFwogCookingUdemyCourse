using RedFrogCooking.Data.Model;

namespace RedFrogCooking.Data.Repositories
{
    public interface IWebsitePageRepository
    {
        WebsitePage? GetPageById(string id);
        Task InsertStartData();
    }
}