using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RedFrogCooking.Data.Model;
using RedFrogCooking.Data.Repositories;
using RedFwogCooking.Website.Utils;

namespace RedFwogCooking.Website.Pages
{
    public class MenuModel : WebsiteModelBase<MenuModel>
    {
        public List<MenuCategory>  Categories { get; set; }
        public List<MenuItem> MenuItems { get; set; }

        private readonly IMenuRepository _menuRepository;
        public MenuModel(IWebsitePageRepository repository, IMenuRepository menuRepository) : base(repository)
        {
            _menuRepository = menuRepository;
        }

        public async Task OnGetAsync()
        {
            var page = GetWebsitePageById(PageNames.Menu);
            SetMetaTags(page);

            Categories = (await _menuRepository.GetCategories()).ToList();
            MenuItems = (await _menuRepository.GetMenuItems()).ToList();
        }
    }
}
