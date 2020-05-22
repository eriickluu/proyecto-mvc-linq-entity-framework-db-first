using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicacionWeb.Models;

namespace AplicacionWeb.Controllers
{
    public class MarcaController : Controller
    {
        // GET: Marca
        public ActionResult Index()
        {
            List<MarcaCLS> listaMarca = null;

            using (var db = new BDPasajeEntities())
            {
                listaMarca = (from Marca in db.Marca
                              where Marca.BHABILITADO == 1
                              select new MarcaCLS
                              {
                                  idmarca = Marca.IIDMARCA,
                                  nombre = Marca.NOMBRE,
                                  descripcion = Marca.DESCRIPCION
                              }).ToList();
            }

            return View(listaMarca);
        }

        public ActionResult Agregar() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(MarcaCLS oMarcaCLS)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BDPasajeEntities())
                {
                    Marca oMarca = new Marca();
                    oMarca.NOMBRE = oMarcaCLS.nombre;
                    oMarca.DESCRIPCION = oMarcaCLS.descripcion;
                    oMarca.BHABILITADO = 1;

                    db.Marca.Add(oMarca);
                    db.SaveChanges();
                }
            }
            else
            {
                return View(oMarcaCLS);
            }

            return RedirectToAction("Index");
        }
    }
}