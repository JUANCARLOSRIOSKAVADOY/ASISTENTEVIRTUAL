using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class GestorRespuesta
    {
        public List<BeRespuesta> ObtenerRespuestasByPregunta(Int32 preguntaid){
            return new DalRespuesta().ObtenerRespuestasByPregunta(preguntaid);
        }
    }
}
