using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RedFrogCooking.Data.Model;
using RedFrogCooking.Data.Repositories;
using RedFwogCooking.Website.Utils;

namespace RedFwogCooking.Website.Pages
{
    public class ContactModel : WebsiteModelBase<ContactModel>
    {
        public ContactModel(IWebsitePageRepository repository): base(repository) { }
        
        public void OnGet()
        {

            var page = GetWebsitePageById(PageNames.Contact);

            SetMetaTags(page);

            Text? text = page.Texts.FirstOrDefault();

            if (text == null)
            {
                throw new Exception($"text content in '{PageNames.Contact}' not found");
            }

            PageText.Title = text.Title;
            PageText.TextContent = text.TextContent;
        }
    }
}
