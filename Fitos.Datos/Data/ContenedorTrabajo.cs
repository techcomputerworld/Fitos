using Fitos.Data;
using Fitos.Datos.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace Fitos.Datos.Data
{
    public class ContenedorTrabajo
    {
        private readonly ApplicationDbContext _db;
        public ContenedorTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Fitos = new FitosRepository(_db);
        }
        public IFitosRepository Fitos { get; private set; }
    }
}
