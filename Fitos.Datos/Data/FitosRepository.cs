using System;
using System.Collections.Generic;
using System.Text;
using Fitos.Models;
using Fitos.Datos.Data.Repository;
using Fitos.Data;
using System.Linq;

namespace Fitos.Datos.Data
{
    public class FitosRepository : Repository<Fitosanitario>, IFitosRepository
    {
        private readonly ApplicationDbContext _db;
        /// <summary>
        /// Constructor de la clase CategoriaRepository pasando el argumento db 
        /// </summary>
        /// <param name="db"></param>
        public FitosRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
            
        }
        public void Update(Fitosanitario fitosanitario)
        {
            var objDesdeDb = _db.Fitosanitario.FirstOrDefault(s => s.Id == fitosanitario.Id);
            objDesdeDb.Nombre = fitosanitario.Nombre;
            objDesdeDb.Tipo = fitosanitario.Tipo;
            
            objDesdeDb.Descripcion = fitosanitario.Descripcion;
            objDesdeDb.UrlImagen = fitosanitario.UrlImagen;
            objDesdeDb.UrlImagen2 = fitosanitario.UrlImagen2;

            //guardar los cambios en la base de datos actualizandolos.
            //Lo comentamos porque el guardado lo vamos a hacer desde el controlador
            //_db.SaveChanges();
        }

    }
}
