using Fitos.Datos.Data.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Fitos.Areas.Cliente.Controllers
{
    //[Authorize]
    [Area("Cliente")]
    public class FitosController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        //con esta variable ya podremos trabajar con subida de archivos
        private readonly IWebHostEnvironment _hostingEnvironment;
        // GET: FitosController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FitosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FitosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FitosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FitosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FitosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FitosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FitosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        #region Llamadas a la API
        [HttpGet]
        public IActionResult GetAll()
        {
            //GetAll() método del Repository y del IRespository
            //para acceder a la Categoria hay que ponerlo en articulos.js, categoria.nombre
            return Json(new { data = _contenedorTrabajo.Fitos.GetAll(includeProperties: "Fitos") });
        }
        //El método que borra los registros o tuplas de la base de datos lo pone aquí en llamadas a la API
        /*
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _contenedorTrabajo.Categoria.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error borrando categoria" });
            }
            _contenedorTrabajo.Categoria.Remove(objFromDb);
            _contenedorTrabajo.Save();
            return Json(new { success = true, message = "Categoria borrada correctamente" });
        }*/
        #endregion
    }
}
