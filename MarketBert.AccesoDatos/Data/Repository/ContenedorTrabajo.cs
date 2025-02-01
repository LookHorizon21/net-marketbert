using AppAdminMarketBert.Data;
using MarketBert.AccesoDatos.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketBert.AccesoDatos.Data.Repository
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {
        private readonly ApplicationDbContext _db;

        public ContenedorTrabajo(ApplicationDbContext db)
        {
            _db = db;
            CategoriaRp = new CategoriaRepository(_db);
            ArticuloRp = new ArticuloRepository(_db);
        }

        public ICategoriaRepository CategoriaRp { get; private set; }
        public IArticuloRepository ArticuloRp { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
