using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio;
using Entidades;

namespace Aplicacion.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            GestorCurso GestorCurso = new GestorCurso();
            List<BeCurso> lstCurso = GestorCurso.ObtenerListadoCursoPorEstado(true);
            ViewBag.ListadoCurso = lstCurso;
            return View();
        }

    }
}
