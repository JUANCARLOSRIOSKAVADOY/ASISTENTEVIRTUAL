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
    public class DalPregunta
    {

        public List<BePregunta> ObtenerListadoPreguntaPorCurMat(Int32 cursoid, Int32 materialid)
        {
            List<BePregunta> listado = new List<BePregunta>();
            DatabaseHelper helper = null;
            SqlDataReader reader = null;

            try
            {
                helper = new DatabaseHelper(DalConexion.getConexion());
                helper.AddParameter("@P_CURSOID", cursoid);
                helper.AddParameter("@P_MATERIALID", materialid);
                reader = (SqlDataReader)helper.ExecuteReader("spr_ObtenerListadoPreguntaPorCurMat", System.Data.CommandType.StoredProcedure);
                while (reader.Read())
                {
                    BePregunta obj = new BePregunta();
                    obj.id = Validacion.DBToInt32(ref reader, "preguntaid");
                    obj.descripcion = Validacion.DBToString(ref reader, "desc_pregunta");
                    listado.Add(obj);
                }
            }
            catch (Exception ex)
            {
                clsException localException = new clsException(ex, "DalPregunta -> ObtenerListadoPreguntaPorCurMat()");
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
