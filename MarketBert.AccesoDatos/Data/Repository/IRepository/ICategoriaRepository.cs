using MarketBert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MarketBert.AccesoDatos.Data.Repository.IRepository
{
    public interface ICategoriaRepository : IRepository<CategoriaMd>
    {
        void Update(CategoriaMd categoriaMd);

        IEnumerable<SelectListItem> GetListaCategorias();
    }
}
