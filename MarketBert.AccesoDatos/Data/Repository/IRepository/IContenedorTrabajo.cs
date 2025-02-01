using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketBert.AccesoDatos.Data.Repository.IRepository
{
    public interface IContenedorTrabajo : IDisposable
    {
        //Todo los Repositorios
        ICategoriaRepository CategoriaRp { get; }
        IArticuloRepository ArticuloRp { get; }

        void Save();
    }
}
