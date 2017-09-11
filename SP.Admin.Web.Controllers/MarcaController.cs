using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using SP.Admin.Web.Data;
using SP.Admin.Web.Models;

namespace SP.Admin.Web.Controllers
{
    public class MarcaController : Controller
    {
        SIRESPAEntities db = new SIRESPAEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult Editar(int? id)
        {
            ViewBag.Title = "Editar ";

            if (id == null) return null;

                MarcaDto marca = (from mar in db.CA_MARCAS
                                 where mar.MAR_KEYMAR == id
                                 select new MarcaDto()
                                 {
                                     id = mar.MAR_KEYMAR,
                                     Nombre = mar.MAR_DESCRI
                                 }
                                 ).ToList()[0];

            return PartialView("_Editar", marca);
                       
        }

        [HttpPost]
        public JsonResult CargarMarcas()
        {
            try
            {

                var lstMarcas = (from mar in db.CA_MARCAS
                                   select new
                                   {
                                       id = mar.MAR_KEYMAR,
                                       nombre = mar.MAR_DESCRI
                                   }).ToList();

                return Json(new { Success = true, data = lstMarcas });

            }
            catch (Exception exp)
            {
                return Json(new { Success = false, Messages = exp.Message });
            }

        }

    }
}
