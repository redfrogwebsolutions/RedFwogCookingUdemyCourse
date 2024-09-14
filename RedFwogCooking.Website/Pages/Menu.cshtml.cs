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

        private readonly ICategoryRepository _categoryRepository;
        private readonly IMenuItemRepository _menuItemRepository;
        public MenuModel(IWebsitePageRepository repository, IMenuItemRepository menuItemRepository, ICategoryRepository categoryRepository) : base(repository)
        {
            _menuItemRepository = menuItemRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task OnGetAsync()
        {
            var page = GetWebsitePageById(PageNames.Menu);
            SetMetaTags(page);

            Categories = (await _categoryRepository.GetCategories()).ToList();
            MenuItems = (await _menuItemRepository.GetMenuItems()).ToList();
        }
    }
}
