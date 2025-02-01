using MarketBert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using MarketBert.Models.ViewModels;

namespace MarketBert.AccesoDatos.Data.Repository.IRepository
{
    public interface IArticuloRepository : IRepository<ArticuloMd>
    {
        void Update(ArticuloMd articulo);

        //Método para el buscador
        IQueryable<ArticuloMd> AsQueryable();
    }
}
