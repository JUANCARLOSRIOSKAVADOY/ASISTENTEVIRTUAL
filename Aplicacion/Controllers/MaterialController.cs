using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio;
using Entidades;

namespace Aplicacion.Controllers
{
    public class MaterialController : Controller
    {
        //
        // GET: /Material/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ViewMaterialByCurso(Int32 cursoid) {
            GestorCursoMaterial GestorCursoMaterial = new GestorCursoMaterial();
            BeCursoMaterial objCursoMaterial = GestorCursoMaterial.ObtenerListadoMaterialPorCurso(cursoid);
            ViewBag.cursoid = cursoid;
            ViewBag.CursoMaterial = objCursoMaterial;
            return View();
        }

    }
}
