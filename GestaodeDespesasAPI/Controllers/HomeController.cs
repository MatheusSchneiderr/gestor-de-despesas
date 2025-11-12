using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using GestaodeDespesasAPI.Models;
using GestaodeDespesasAPI.Services;

namespace GestaodeDespesasAPI.Controllers
{
    public class HomeController : Controller
    {
        private DespesaService _service = new DespesaService();
        
        public ActionResult Index()
        {
            var despesas = _service.GetAll();
            return View(despesas.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}