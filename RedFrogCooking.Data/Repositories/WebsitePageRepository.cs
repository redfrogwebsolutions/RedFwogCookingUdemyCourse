using Microsoft.EntityFrameworkCore;
using RedFrogCooking.Data.Model;

namespace RedFrogCooking.Data.Repositories
{
    public class WebsitePageRepository : IWebsitePageRepository
    {
        private readonly RedFrogCooking.Data.DataContext.DataContext _dbContext;

        public WebsitePageRepository(DataContext.DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public WebsitePage? GetPageById(string id)
        {
            return _dbContext.WebsitePages.Include(x=>x.WebsiteTexts).Where(p => p.Id == id).FirstOrDefault();
        }

        //List<WebsitePage> pages = new List<WebsitePage>
        //{
        //    new WebsitePage()
        //    {
        //        Id = "index",
        //        MetaDescription = "descr 1",
        //        MetaKeywords = "Keywords 1",
        //        Title = "title 1",
        //        WebsiteTexts = new List<WebsiteText> {
        //            new WebsiteText()
        //            {
        //                Id = Guid.NewGuid().ToString(),
        //                Title = "About us",
        //                TextContent = " <h1 class=\"mb-4\">Welcome to <i class=\"fa fa-utensils text-primary me-2\"></i>Red Frog Cooking</h1>\r\n                <p class=\"mb-4\">Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos erat ipsum et lorem et sit, sed stet lorem sit.</p>\r\n                <p class=\"mb-4\">Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit, sed stet lorem sit clita duo justo magna dolore erat amet</p>"

        //            }
        //        }

        //    },

        //     new WebsitePage()
        //    {
        //        Id = "aboutus",
        //        MetaDescription = "descr aboutus",
        //        MetaKeywords = "Keywords aboutus",
        //        Title = null,
        //        WebsiteTexts = new List<WebsiteText> {
        //            new WebsiteText()
        //            {
        //                Id = Guid.NewGuid().ToString(),
        //                Title = "About us",
        //                TextContent = " <h1 class=\"mb-4\">Welcome to <i class=\"fa fa-utensils text-primary me-2\"></i>Red Frog Cooking</h1>\r\n                <p class=\"mb-4\">Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos erat ipsum et lorem et sit, sed stet lorem sit.</p>\r\n                <p class=\"mb-4\">Tempor erat elitr rebum at clita. Diam dolor diam ipsum sit. Aliqu diam amet diam et eos. Clita erat ipsum et lorem et sit, sed stet lorem sit clita duo justo magna dolore erat amet</p>"

        //            }
        //        }

        //    },
        //    new WebsitePage()
        //    {
        //        Id = "menu",
        //        MetaDescription = "descr menu",
        //        MetaKeywords = "Keywords menu",
        //        Title = "RedFrogCooking - Menu"
        //    },

        //     new WebsitePage()
        //    {
        //        Id = "contact",
        //        MetaDescription = "descr aboutus",
        //        MetaKeywords = "Keywords aboutus",
        //        Title = null,
        //        WebsiteTexts = new List<WebsiteText> {
        //            new WebsiteText()
        //            {
        //                Id = Guid.NewGuid().ToString(),
        //                Title = "Contact",
        //                TextContent = "          <div class=\"container-xxl py-5\">\r\n            <div class=\"container\">\r\n                <div class=\"text-center wow fadeInUp\" data-wow-delay=\"0.1s\">\r\n                    <h5 class=\"section-title ff-secondary text-center text-primary fw-normal\">Contact Us</h5>\r\n                    <h1 class=\"mb-5\">Contact For Any Query</h1>\r\n                </div>\r\n                <div class=\"row g-4\">\r\n                    <div class=\"col-12\">\r\n                        <div class=\"row gy-4\">\r\n                            <div class=\"col-md-4\">\r\n                                <h5 class=\"section-title ff-secondary fw-normal text-start text-primary\">Booking</h5>\r\n                                <p><i class=\"fa fa-envelope-open text-primary me-2\"></i>book@example.com</p>\r\n                            </div>\r\n                            <div class=\"col-md-4\">\r\n                                <h5 class=\"section-title ff-secondary fw-normal text-start text-primary\">General</h5>\r\n                                <p><i class=\"fa fa-envelope-open text-primary me-2\"></i>info@example.com</p>\r\n                            </div>\r\n                            <div class=\"col-md-4\">\r\n                                <h5 class=\"section-title ff-secondary fw-normal text-start text-primary\">Technical</h5>\r\n                                <p><i class=\"fa fa-envelope-open text-primary me-2\"></i>tech@example.com</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-6 wow fadeIn\" data-wow-delay=\"0.1s\">\r\n                        <iframe class=\"position-relative rounded w-100 h-100\"\r\n                            src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3001156.4288297426!2d-78.01371936852176!3d42.72876761954724!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4ccc4bf0f123a5a9%3A0xddcfc6c1de189567!2sNew%20York%2C%20USA!5e0!3m2!1sen!2sbd!4v1603794290143!5m2!1sen!2sbd\"\r\n                            frameborder=\"0\" style=\"min-height: 350px; border:0;\" allowfullscreen=\"\" aria-hidden=\"false\"\r\n                            tabindex=\"0\"></iframe>\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"wow fadeInUp\" data-wow-delay=\"0.2s\">\r\n                            <form>\r\n                                <div class=\"row g-3\">\r\n                                    <div class=\"col-md-6\">\r\n                                        <div class=\"form-floating\">\r\n                                            <input type=\"text\" class=\"form-control\" id=\"name\" placeholder=\"Your Name\">\r\n                                            <label for=\"name\">Your Name</label>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"col-md-6\">\r\n                                        <div class=\"form-floating\">\r\n                                            <input type=\"email\" class=\"form-control\" id=\"email\" placeholder=\"Your Email\">\r\n                                            <label for=\"email\">Your Email</label>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"col-12\">\r\n                                        <div class=\"form-floating\">\r\n                                            <input type=\"text\" class=\"form-control\" id=\"subject\" placeholder=\"Subject\">\r\n                                            <label for=\"subject\">Subject</label>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"col-12\">\r\n                                        <div class=\"form-floating\">\r\n                                            <textarea class=\"form-control\" placeholder=\"Leave a message here\" id=\"message\" style=\"height: 150px\"></textarea>\r\n                                            <label for=\"message\">Message</label>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"col-12\">\r\n                                        <button class=\"btn btn-primary w-100 py-3\" type=\"submit\">Send Message</button>\r\n                                    </div>\r\n                                </div>\r\n                            </form>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>"

        //            }
        //        }

        //    }
        //};

     
    }
}
