using FACTURACION.FACTUR.CLIENTS;
using FACTURACION.FACTUR.ENTITY.Parametros;
using FACTURACION.FACTUR.ENTITY.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTURACION.FACTUR.BUSINESS
{
    public class BUPais
    {
        private Client client;

        public BUPais()
        {
            client = new Client();

        }

        public List<responsePais> listaPaises(ENRegistroEmpresa paramss, string token)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<responsePais>>(client.Post<ENRegistroEmpresa>("RegistroEmpresa/listarPaises", paramss, token));
        
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
    }
}
