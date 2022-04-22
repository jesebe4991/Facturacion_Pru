using FACTURACION.FACTUR.BUSINESS;
using FACTURACION.FACTUR.ENTITY.Parametros;
using FACTURACION.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FACTURACION.Controllers
{
    public class RegistroEmpresaController : Controller
    {
        private modelList model;
        private BUPais bupais;

        public RegistroEmpresaController()
        {
            model = new modelList();
            bupais = new BUPais();
        }
        // GET: RegistroEmpresa
        public ActionResult RegistroEmpresa(ENRegistroEmpresa paramss)
        {
            string token = "";

            model.listPais = bupais.listaPaises(paramss, token);

            return View(model);
        }

       
    }
}
