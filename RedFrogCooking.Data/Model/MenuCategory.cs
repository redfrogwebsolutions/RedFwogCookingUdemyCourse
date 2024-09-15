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
        [StringLength(15, ErrorMessage = "moze byc max 15 znakow")]
        public required string Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }
        public string Icon { get; set; } = string.Empty;
    }
}
