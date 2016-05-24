using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio;
using Entidades;

namespace Aplicacion.Controllers
{
    public class PreguntaController : Controller
    {
        //
        // GET: /Pregunta/

        public ActionResult ObtenerPregunta(BePregunta obj)
        {
            GestorPregunta GestorPregunta = new GestorPregunta();
            ViewBag.Pregunta = obj;
            return View("Pregunta");
        }

        public ActionResult StartQuestion() {
            return View("StartQuestion");
        }

        public ActionResult JsonListadoPreguntasRandom(Int32 cursoid, Int32 materialid) {
            GestorPregunta GestorPregunta = new GestorPregunta();
            List<BePregunta> preguntas = GestorPregunta.ObtenerListadoPreguntaPorCurMat(cursoid, materialid);
            return Json(preguntas,JsonRequestBehavior.DenyGet);
        }

    }
}
