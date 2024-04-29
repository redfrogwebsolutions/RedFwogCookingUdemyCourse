using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedFrogCooking.Data.Model
{
    public class WebsitePage
    {
        public required string Id { get; set; }
        public string? Title { get; set; }
        public string? MetaKeywords { get; set; }
        public string? MetaDescription { get; set; }

        public List<Text>? Texts { get; set; }
    }
}
