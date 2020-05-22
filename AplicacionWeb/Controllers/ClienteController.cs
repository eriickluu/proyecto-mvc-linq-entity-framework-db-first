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

        public ActionResult Agregar()
        {
            return View();
        }
    }
}