using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatCypherWebApp.Models;
using static DataLibrary.BusinessLogic.SymbolProcessor;

namespace TatCypherWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult ViewSymbols()
        {
            ViewBag.Message = "Список шифрованных символов";

            var data = LoadSymbols();
            List<SymbolModel> symbols = new List<SymbolModel>();

            foreach (var row in data)
            {
                symbols.Add(new SymbolModel
                {
                    oldSymbol = row.oldSymbol,
                    newSymbol = row.newSymbol
                });
            }

            return View();
        }

        public ActionResult SymbolUpload()
        {
            ViewBag.Message = "Шифровка символов";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SymbolUpload(SymbolModel sModel)
        {
            if (ModelState.IsValid)
            {
                CreateSymbol(sModel.oldSymbol, sModel.newSymbol);
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult MessageUpload()
        {
            ViewBag.Message = "Зашифровать сообщение";

            return View();
        }
    }
}