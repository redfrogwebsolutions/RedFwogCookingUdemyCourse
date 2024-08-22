using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedFrogCooking.Data.Model
{
    public class MenuCategory
    {
        [StringLength(3, ErrorMessage = "moxe byc max 3 xnaki")]
        public required string Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [EmailAddress]
        public string? Description { get; set; }
        public string Icon { get; set; } = string.Empty;
    }
}
