using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using RedFrogCooking.Data.Model;
using RedFrogCooking.Data.Repositories;
using System.Data;

namespace RedFwogCooking.Website.Pages
{
    public class IndexModel : WebsiteModelBase<IndexModel>
    {
        private readonly ILogger<IndexModel> _logger;
        public Text PageText { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IWebsitePageRepository repository): base(repository)
        {
            _logger = logger;
        }
        public void OnGet()
        {

            PageText.Title = title;
            PageText.TextContent = text;
            ViewData["displayShowMoreButton"] = true;
        }

        const string text = " <h1 class=\"mb-4\">Welcome to <i class=\"fa fa-utensils text-primary me-2\"></i>Red Frog Cooking1</h1>\r\n                <p class=\"mb-4\">Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos erat ipsum et lorem et sit, sed stet lorem sit.</p>\r\n                <p class=\"mb-4\">Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit, sed stet lorem sit clita duo justo magna dolore erat amet</p>";
        const string title = "About us";
    }
}
