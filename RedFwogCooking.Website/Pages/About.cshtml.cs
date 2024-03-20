using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RedFrogCooking.Data.Model;
using RedFrogCooking.Data.Repositories;
using RedFwogCooking.Website.Utils;

namespace RedFwogCooking.Website.Pages
{
    public class AboutModel : WebsiteModelBase<AboutModel>
    {
        public AboutModel(IWebsitePageRepository repository) : base(repository)
        {
        }

        public void OnGet()
        {
            var page = GetWebsitePageById(PageNames.AboutUs);

            SetMetaTags(page);

            Text? text = page.Texts.FirstOrDefault();

            if (text == null)
            {
                throw new Exception($"text content in '{typeof(AboutModel)}' not found");
            }

            PageText.Title = text.Title;
            PageText.TextContent = text.TextContent;
        }

       
    }
}
