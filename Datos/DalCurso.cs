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
    public class DalCurso
    {
        public List<BeCurso> ObtenerListadoCursoPorEstado(Boolean? Estado)
        {
            List<BeCurso> listado = new List<BeCurso>();
            DatabaseHelper helper = null;
            SqlDataReader reader = null;

            try
            {
                helper = new DatabaseHelper(DalConexion.getConexion());
                helper.AddParameter("@P_ESTADO", Estado);
                reader = (SqlDataReader)helper.ExecuteReader("spr_ObtenerListadoCursoPorEstado", System.Data.CommandType.StoredProcedure);
                while (reader.Read())
                {
                    BeCurso obj = new BeCurso();
                    obj.id = Validacion.DBToInt32(ref reader, "id");
                    obj.descripcion = Validacion.DBToString(ref reader, "descripcion");
                    obj.image = Validacion.DBToString(ref reader, "image");
                    obj.estado = Validacion.DBToBoolean(ref reader, "estado");
                    listado.Add(obj);
                }
            }
            catch (Exception ex)
            {
                clsException localException = new clsException(ex, "DalCurso -> ObtenerListadoCursoPorEstado()");
            }
            finally
            {
                if (helper != null)
                    helper.Dispose();
            }
            return listado;
        }

        /*
        public Boolean InsertarDisponibilidadCursoPeriodo(BeDisponibilidadCursoPeriodo obj)
        {
            DatabaseHelper Helper = null;
            Boolean Resultado = false;

            try
            {
                Helper = new DatabaseHelper(DalConexion.getConexion());

                Helper.AddParameter("@IdPeriodoAcademico", obj.PeriodoAcademico.IdPeriodoAcademico);
                Helper.AddParameter("@IdCurso", obj.Curso.IdCurso);

                Resultado = Convert.ToBoolean(Helper.ExecuteNonQuery("spr_jaimInsertarDisponibilidadCursoPeriodo", System.Data.CommandType.StoredProcedure));
            }
            catch (Exception ex)
            {
                clsException localException = new clsException(ex, "DalDisponibilidadCursoPeriodo -> InsertarDisponibilidadCursoPeriodo()");
            }
            finally
            {
                if (Helper != null)
                    Helper.Dispose();
            }
            return Resultado;
        }         
         
         */

        /*
        public BeCurso ObtenerCursoPorId(Int32 IdCurso)
        {
            BeCurso obj = null;
            DatabaseHelper helper = null;
            SqlDataReader reader = null;

            try
            {
                helper = new DatabaseHelper(DalConexion.getConexion());
                helper.AddParameter("@IdCurso", IdCurso);
                reader = (SqlDataReader)helper.ExecuteReader("spr_jaimObtenerCursoPorId", System.Data.CommandType.StoredProcedure);
                if (reader.Read())
                {
                    obj = new BeCurso();
                    obj.IdCurso = Validacion.DBToInt32(ref reader, "IdCurso");
                    obj.Codigo = Validacion.DBToString(ref reader, "Codigo");
                    obj.Descripcion = Validacion.DBToString(ref reader, "DescripcionCurso");
                    obj.Observaciones = Validacion.DBToString(ref reader, "Observaciones");
                    obj.Estado = Validacion.DBToBoolean(ref reader, "Estado");
                    obj.Programa = new BePrograma()
                    {                        
                        IdPrograma = Validacion.DBToInt32(ref reader, "IdPrograma"),
                        Descripcion = Validacion.DBToString(ref reader, "DescripcionPrograma")
                    };
                }
            }
            catch (Exception ex)
            {
                clsException localException = new clsException(ex, "DalCurso -> ObtenerCursoPorId()");
            }
            finally
            {
                if (helper != null)
                    helper.Dispose();
            }
            return obj;
        }

        public List<BeCurso> ObtenerListadoCursoDisponiblePorPeriodo(Int32 IdPrograma, Int32 IdPeriodo)
        {
            List<BeCurso> listado = new List<BeCurso>();
            DatabaseHelper helper = null;
            SqlDataReader reader = null;

            try
            {
                helper = new DatabaseHelper(DalConexion.getConexion());
                helper.AddParameter("@IdPrograma", IdPrograma);
                helper.AddParameter("@IdPeriodo", IdPeriodo);
                reader = (SqlDataReader)helper.ExecuteReader("spr_jaimObtenerListadoCursoDisponiblePorPeriodo", System.Data.CommandType.StoredProcedure);
                while (reader.Read())
                {                    
                    BeCurso obj = new BeCurso();
                    obj.IdCurso = Validacion.DBToInt32(ref reader, "IdCurso");
                    obj.Codigo = Validacion.DBToString(ref reader, "Codigo");
                    obj.Descripcion = Validacion.DBToString(ref reader, "Descripcion");
                    obj.Estado = Validacion.DBToBoolean(ref reader, "Estado");
                    obj.Programa = new BePrograma(){
                        IdPrograma = Validacion.DBToInt32(ref reader, "IdPrograma")
                    };
                    listado.Add(obj);
                }
            }
            catch (Exception ex)
            {
                clsException localException = new clsException(ex, "DalCurso -> ObtenerListadoCursoDisponiblePorPeriodo()");
            }
            finally
            {
                if (helper != null)
                    helper.Dispose();
            }
            return listado;
        }
        */
    }
}
