using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicacionWeb.Models;

namespace AplicacionWeb.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            List<ClienteCLS> listaCliente = null;

            using (var db = new BDPasajeEntities())
            {
                listaCliente = (from Cliente in db.Cliente
                                 where Cliente.BHABILITADO == 1
                                 select new ClienteCLS
                                 {
                                     idcliente = Cliente.IIDCLIENTE,
                                     nombre = Cliente.NOMBRE,
                                     aPaterno = Cliente.APPATERNO,
                                     aMaterno = Cliente.APMATERNO,
                                     telefonoFijo = Cliente.TELEFONOFIJO
                                 }).ToList();
            }

            return View(listaCliente);
        }

        List<SelectListItem> listaSexo;

        private void LlenarSexo()
        {     
            using (var db = new BDPasajeEntities())
            {
                listaSexo = (from Sexo in db.Sexo
                                where Sexo.BHABILITADO == 1
                                select new SelectListItem
                                {
                                    Text = Sexo.NOMBRE,
                                    Value = Sexo.IIDSEXO.ToString()
                                }).ToList();

                listaSexo.Insert(0, new SelectListItem { Text = "--Seleccione--", Value = "" });
            }
        }

        public ActionResult Agregar()
        {
            LlenarSexo();

            ViewBag.lista = listaSexo;

            return View();
        }


        [HttpPost]
        public ActionResult Agregar(ClienteCLS oClienteCLS)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BDPasajeEntities())
                {
                    Cliente oCliente = new Cliente();
                    oCliente.NOMBRE = oClienteCLS.nombre;
                    oCliente.APPATERNO = oClienteCLS.aPaterno;
                    oCliente.APMATERNO = oClienteCLS.aMaterno;
                    oCliente.EMAIL = oClienteCLS.email;
                    oCliente.DIRECCION = oClienteCLS.direccion;
                    oCliente.IIDCLIENTE = oClienteCLS.idsexo;
                    oCliente.TELEFONOCELULAR = oClienteCLS.telefonoCelular;
                    oCliente.TELEFONOFIJO = oClienteCLS.telefonoFijo;
                    oCliente.BHABILITADO = 1;

                    db.Cliente.Add(oCliente);
                    db.SaveChanges();
                }
            }
            else
            {
                LlenarSexo();

                ViewBag.lista = listaSexo;

                return View(oClienteCLS);
            }

            return RedirectToAction("Index");
        }
    }
}