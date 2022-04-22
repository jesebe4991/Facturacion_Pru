using FACTURACION.FACTUR.ENTITY.Parametros;
using FACTURACION.FACTUR.ENTITY.Response;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTURACION.FACTUR.DATOS
{
    public class DAPaises
    {
        public List<responsePais> listarPaises(ENRegistroEmpresa paramss)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                var lista = new List<responsePais>();

                using(SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_listarPaises", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while(rdr.Read)
                        {
                            var resul = new responsePais();
                            resul.idPais = Convert.ToInt32(rdr["idPais"]);
                            resul.pais = Convert.ToString(rdr["pais"]);
                            lista.Add(resul);
                        }


                    }
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
