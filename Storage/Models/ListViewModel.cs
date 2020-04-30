using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class ListViewModel
    {
        public IEnumerable<ProductViewModel> ProductViewModels { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}
