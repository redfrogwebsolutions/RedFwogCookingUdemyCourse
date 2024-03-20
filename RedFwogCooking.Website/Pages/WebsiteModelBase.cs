using Microsoft.AspNetCore.Mvc.RazorPages;
using RedFrogCooking.Data.Model;
using RedFrogCooking.Data.Repositories;
using RedFwogCooking.Website.Utils;

namespace RedFwogCooking.Website.Pages
{
    public class WebsiteModelBase<T>: PageModel where T : class
    {
        protected readonly IWebsitePageRepository _websitePageRepository;

        public WebsiteModelBase(IWebsitePageRepository repository)
        {
            _websitePageRepository = repository;
        }

        public Text PageText { get; set; } = new Text();
        public string MetaTitle { get; set; } = "RedFrogCooking.com - the best seafood restaurant in the city";
        public string MetaKeywords { get; set; } = "seafood, restaurant";
        public string MetaDescription { get; set; } = "RedFrogCooking.com - the best seafood restaurant in the city. You can find us in the south area of the city";


        protected WebsitePage GetWebsitePageById(string id)
        {
            var page = _websitePageRepository.GetPageById(id);

            if (page == null)
            {
                throw new Exception($"page {typeof(T)} not found");
            }

            return page;
        }

        protected void SetMetaTags(WebsitePage page)
        {

            MetaTitle = page.Title ?? MetaTitle;
            MetaDescription = page.MetaDescription ?? MetaDescription;
            MetaKeywords = page.MetaKeywords ?? MetaKeywords;
        }
    }
}
