using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio;
using Entidades;

namespace Aplicacion.Controllers
{
    public class RespuestaController : Controller
    {
        //
        // GET: /Respuesta/

        public ActionResult ObtenerRespuestaByPregunta(Int32 preguntaid)
        {
            GestorRespuesta GestorRespuesta = new GestorRespuesta();
            List<BeRespuesta> respuestas = GestorRespuesta.ObtenerRespuestasByPregunta(preguntaid);
            return Json(respuestas, JsonRequestBehavior.DenyGet);
        }

    }
}
