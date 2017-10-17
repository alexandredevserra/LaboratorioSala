using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaboratorioAlexandre.Models;

namespace LaboratorioAlexandre.Controllers
{
    public class CidadeController : Controller
    {
        // GET: Cidade
        public ActionResult Listar()
        {
            IList<Cidade> cidades = new Cidade().GetAll();
            return View(cidades);
        }
    }
}