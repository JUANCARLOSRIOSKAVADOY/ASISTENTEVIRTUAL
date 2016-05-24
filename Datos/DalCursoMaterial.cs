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
    public class DalCursoMaterial
    {
        public BeCursoMaterial ObtenerListadoMaterialPorCurso(Int32 cursoid)
        {
            BeCursoMaterial obj = new BeCursoMaterial();
            obj.lstMaterial = new List<BeMaterial>();
            DatabaseHelper helper = null;
            SqlDataReader reader = null;

            try
            {
                helper = new DatabaseHelper(DalConexion.getConexion());
                helper.AddParameter("@P_CURSOID", cursoid);
                reader = (SqlDataReader)helper.ExecuteReader("spr_ObtenerListadoMaterialPorCurso", System.Data.CommandType.StoredProcedure);
                while (reader.Read())
                {
                    BeCurso objCurso = new BeCurso();
                    objCurso.id = Validacion.DBToInt32(ref reader, "cursoid");
                    objCurso.descripcion = Validacion.DBToString(ref reader, "desc_curso");

                    BeMaterial objMaterial = new BeMaterial();
                    objMaterial.id = Validacion.DBToInt32(ref reader, "materialid");
                    objMaterial.descripcion = Validacion.DBToString(ref reader, "desc_material");
                    objMaterial.curso = new BeCurso()
                    {
                        id = Validacion.DBToInt32(ref reader, "cursoid")
                    };

                    obj.curso = objCurso;
                    obj.lstMaterial.Add(objMaterial);
                }
            }
            catch (Exception ex)
            {
                clsException localException = new clsException(ex, "DalCursoMaterial -> ObtenerListadoMaterialPorCurso()");
            }
            finally
            {
                if (helper != null)
                    helper.Dispose();
            }
            return obj;
        }
    }
}
