using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RedFrogCooking.Data.Model;
using RedFrogCooking.Data.Repositories;
using RedFwogCooking.Website.Utils;
using static System.Net.Mime.MediaTypeNames;

namespace RedFwogCooking.Website.Pages
{
    public class AboutModel : WebsiteModelBase<AboutModel>
    {
        public RedFrogCooking.Data.Model.WebsiteText PageText { get; set; }
        public AboutModel(IWebsitePageRepository repository) : base(repository)
        {
        }

        public void OnGet()
        {
            var page = GetWebsitePageById(PageNames.AboutUs);

            SetMetaTags(page);
            if (page.WebsiteTexts == null || page.WebsiteTexts.Any() is false)
            {
                throw new Exception($"text content in '{typeof(AboutModel)}' not found");
            }

            PageText = page.WebsiteTexts.FirstOrDefault();
          
        }

       
    }
}
