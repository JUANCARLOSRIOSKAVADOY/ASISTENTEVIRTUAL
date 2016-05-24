using BinaryIntellect.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Utilitarios;

namespace Datos
{
    public class DalRespuesta
    {
        public List<BeRespuesta> ObtenerRespuestasByPregunta(Int32 preguntaid)
        {
            List<BeRespuesta> listado = new List<BeRespuesta>();
            DatabaseHelper helper = null;
            SqlDataReader reader = null;

            try
            {
                helper = new DatabaseHelper(DalConexion.getConexion());
                helper.AddParameter("@P_PREGUNTAID", preguntaid);
                reader = (SqlDataReader)helper.ExecuteReader("spr_ObtenerRespuestasByPregunta", System.Data.CommandType.StoredProcedure);
                while (reader.Read())
                {
                    BeRespuesta obj = new BeRespuesta();
                    obj.id = Validacion.DBToInt32(ref reader, "id_respuesta");
                    obj.descripcion = Validacion.DBToString(ref reader, "desc_respuesta");
                    listado.Add(obj);
                }
            }
            catch (Exception ex)
            {
                clsException localException = new clsException(ex, "DalRespuesta -> ObtenerRespuestasByPregunta()");
            }
            finally
            {
                if (helper != null)
                    helper.Dispose();
            }
            return listado;
        }

    }
}
