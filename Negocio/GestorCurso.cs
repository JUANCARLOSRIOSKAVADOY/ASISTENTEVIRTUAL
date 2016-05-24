using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class GestorCurso
    {
        #region Curso

        public List<BeCurso> ObtenerListadoCursoPorEstado(Boolean? Estado)
        {
            return new DalCurso().ObtenerListadoCursoPorEstado(Estado);
        }

        #endregion
    }
}
