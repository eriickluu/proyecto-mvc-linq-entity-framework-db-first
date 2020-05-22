using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicacionWeb.Models;

namespace AplicacionWeb.Controllers
{
    public class SucursalController : Controller
    {
        // GET: Sucursal
        public ActionResult Index()
        {
            List<SucursalCLS> listaSucursal = null;

            using (var db = new BDPasajeEntities())
            {
                listaSucursal = (from Sucursal in db.Sucursal
                                 where Sucursal.BHABILITADO == 1
                                 select new SucursalCLS
                                 {
                                     idsucursal = Sucursal.IIDSUCURSAL,
                                     nombre = Sucursal.NOMBRE,
                                     telefono = Sucursal.TELEFONO,
                                     email = Sucursal.EMAIL
                                 }).ToList();
            }

            return View(listaSucursal);
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(SucursalCLS oSucursalCLS)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BDPasajeEntities())
                {
                    Sucursal oSucursal = new Sucursal();
                    oSucursal.NOMBRE = oSucursalCLS.nombre;
                    oSucursal.DIRECCION = oSucursalCLS.direccion;
                    oSucursal.TELEFONO = oSucursalCLS.telefono;
                    oSucursal.EMAIL = oSucursalCLS.email;
                    oSucursal.FECHAAPERTURA = oSucursalCLS.fechaApertura;
                    oSucursal.BHABILITADO = 1;

                    db.Sucursal.Add(oSucursal);
                    db.SaveChanges();
                }
            }
            else
            {
                return View(oSucursalCLS);
            }

            return RedirectToAction("Index");
        }
    }
}