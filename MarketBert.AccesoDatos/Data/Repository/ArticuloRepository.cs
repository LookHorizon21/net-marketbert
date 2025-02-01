using AppAdminMarketBert.Data;
using MarketBert.AccesoDatos.Data.Repository.IRepository;
using MarketBert.Models;
using MarketBert.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketBert.AccesoDatos.Data.Repository
{
    public class ArticuloRepository : Repository<ArticuloMd>, IArticuloRepository
    {
        private readonly ApplicationDbContext _db;

        public ArticuloRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IQueryable<ArticuloMd> AsQueryable()
        {
            return _db.Set<ArticuloMd>().AsQueryable();
        }

        public void Update(ArticuloMd articulo)
        {
            var objDesdeDb = _db.Articulo.FirstOrDefault(s => s.Id == articulo.Id);
            objDesdeDb.Nombre = articulo.Nombre;
            objDesdeDb.Descripcion = articulo.Descripcion;
            objDesdeDb.UrlImagen = articulo.UrlImagen;
            objDesdeDb.CategoriaId = articulo.CategoriaId;

            //_db.SaveChanges();
        }
    }
}
