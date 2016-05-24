using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class GestorPregunta
    {
        public List<BePregunta> ObtenerListadoPreguntaPorCurMat(Int32 cursoid, Int32 materialid)
        {
            return new DalPregunta().ObtenerListadoPreguntaPorCurMat(cursoid,materialid);
        }
    }
}
