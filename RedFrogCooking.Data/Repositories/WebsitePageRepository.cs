using RedFrogCooking.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedFrogCooking.Data.Repositories
{
    public class WebsitePageRepository : IWebsitePageRepository
    {
        public WebsitePage? GetPageById(string id)
        {
            return pages.Where(p => p.Id == id).FirstOrDefault();
        }

        List<WebsitePage> pages = new List<WebsitePage>
        {
            new WebsitePage()
            {
                Id = "index",
                MetaDescription = "descr 1",
                MetaKeywords = "Keywords 1",
                Title = "title 1",
                Texts = new List<Text> {
                    new Text()
                    {
                        Title = "About us",
                        TextContent = " <h1 class=\"mb-4\">Welcome to <i class=\"fa fa-utensils text-primary me-2\"></i>Red Frog Cooking</h1>\r\n                <p class=\"mb-4\">Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos erat ipsum et lorem et sit, sed stet lorem sit.</p>\r\n                <p class=\"mb-4\">Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit, sed stet lorem sit clita duo justo magna dolore erat amet</p>"

                    }
                }

            },

             new WebsitePage()
            {
                Id = "aboutus",
                MetaDescription = "descr aboutus",
                MetaKeywords = "Keywords aboutus",
                Title = null,
                Texts = new List<Text> {
                    new Text()
                    {
                        Title = "About us on about us page",
                        TextContent = " <h1 class=\"mb-4\">Welcome to <i class=\"fa fa-utensils text-primary me-2\"></i>Red Frog Cooking</h1>\r\n                <p class=\"mb-4\">Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos erat ipsum et lorem et sit, sed stet lorem sit.</p>\r\n                <p class=\"mb-4\">Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit, sed stet lorem sit clita duo justo magna dolore erat amet</p>"

                    }
                }

            }
        };
    }
}
