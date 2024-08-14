using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RedFrogCooking.Data.Model;
using RedFrogCooking.Data.Repositories;
using RedFwogCooking.Website.Utils;

namespace RedFwogCooking.Website.Pages
{
    public class ContactModel : WebsiteModelBase<ContactModel>
    {
        WebsiteText PageText { get; set; }
        public ContactModel(IWebsitePageRepository repository): base(repository) { }
        
        public void OnGet()
        {

            var page = GetWebsitePageById(PageNames.Contact);

            SetMetaTags(page);

            if (page.Texts == null || page.Texts.Any() is false)
            {
                throw new Exception($"text content in '{typeof(AboutModel)}' not found");
            }

            PageText = page.Texts.FirstOrDefault();
        }
    }
}
