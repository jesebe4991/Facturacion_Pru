using FACTURACION.FACTUR.DATOS;
using FACTURACION.FACTUR.ENTITY.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FACTURACION.WEBSERVICE.Controllers
{
    [RoutePrefix("api/RegistroEmpresa")]
    public class RegistroEmpresaController : ApiController
    {

        private DAPaises dapaises;

        public RegistroEmpresaController()
        {
            dapaises = new DAPaises();
        }

        [HttpPost]
        [Route("listarPaises")]
        public IHttpActionResult  listarPaises(ENRegistroEmpresa paramss)
        {
            try
            {

                var rpt = dapaises.listarPaises(paramss);
                return Ok(rpt)

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
