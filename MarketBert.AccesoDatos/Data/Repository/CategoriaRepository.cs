using AppAdminMarketBert.Data;
using MarketBert.AccesoDatos.Data.Repository.IRepository;
using MarketBert.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketBert.AccesoDatos.Data.Repository
{
    public class CategoriaRepository : Repository<CategoriaMd>, ICategoriaRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoriaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListaCategorias()
        {
            return _db.Categoria.Select(i => new SelectListItem()
            {
                Text = i.Nombre,
                Value = i.Id.ToString()
            });
        }

        public void Update(CategoriaMd categoriaMd)
        {
            var objDb = _db.Categoria.FirstOrDefault(S => S.Id == categoriaMd.Id);

            objDb.Nombre = categoriaMd.Nombre;
            objDb.Orden = categoriaMd.Orden;

            //_db.SaveChanges();
        }
    }
}
