using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedFrogCooking.Data.Model
{
    public class WebsiteText
    {
        public required string Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string TextContent { get; set; } = string.Empty;
    }
}
