using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class GestorCursoMaterial
    {
        public BeCursoMaterial ObtenerListadoMaterialPorCurso(Int32 cursoid)
        {
            return new DalCursoMaterial().ObtenerListadoMaterialPorCurso(cursoid);
        }
    }
}
