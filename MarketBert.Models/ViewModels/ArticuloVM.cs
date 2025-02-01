using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketBert.Models.ViewModels
{
    public class ArticuloVM
    {
        public ArticuloMd Articulo { get; set; }

        public IEnumerable<SelectListItem> ListaCategorias { get; set; }
    }
}
