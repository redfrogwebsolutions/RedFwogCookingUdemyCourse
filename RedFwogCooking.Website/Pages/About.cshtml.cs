using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RedFrogCooking.Data.Model;
using RedFrogCooking.Data.Repositories;

namespace RedFwogCooking.Website.Pages
{
    public class AboutModel : PageModel
    {
        private readonly IWebsitePageRepository _repository;
        public AboutModel(IWebsitePageRepository repository)
        {
            _repository = repository;
        }

        public Text PageText { get; set; } = new Text();
        public string MetaTitle { get; set; } = "RedFrogCooking.com - the best seafood restaurant in the city";
        public string MetaKeywords { get; set; } = "seafood, restaurant";
        public string MetaDescription { get; set; } = "RedFrogCooking.com - the best seafood restaurant in the city. You can find us in the south area of the city";

        public void OnGet()
        {

            var page = _repository.GetPageById("aboutus");

            if (page == null)
            {
                throw new Exception("page 'aboutus' not found");
            }

            Text? text = page.Texts.FirstOrDefault();

            if (text == null)
            {
                throw new Exception("text content in 'aboutus' not found");
            }

            PageText.Title = text.Title;
            PageText.TextContent = text.TextContent;
        }

       
    }
}
