using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TatCypherWebApp.Models;
using DataLibrary.BusinessLogic;

namespace TatCypherWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EncryptMessage(MessageModel model)
        {
            if (ModelState.IsValid)
            {
                string Message = model.OriginalMessage;
                int i = 0;
                foreach (char c in Message)
                {
                    var sModel = SymbolProcessor.GetRow(c);
                    Message = $"{Message.Substring(0,i)}{sModel.newSymbol}{Message.Substring(i+1)}";
                    i++;
                }
                MessageProcessor.CreateMessage(model.OriginalMessage, Message);
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        public ActionResult ViewMessages()
        {
            ViewBag.Message = "Список полученных зашифрованных сообщений";

            var data = MessageProcessor.LoadMessages();
            List<MessageModel> messages = new List<MessageModel>();

            foreach (var row in data)
            {
                messages.Add(new MessageModel
                {
                    ID = row.ID,
                    OriginalMessage = row.OriginalMessage,
                    EncryptedMessage = row.EncryptedMessage
                });
            }

            return View(messages);
        }

        public ActionResult ViewSymbols()
        {
            ViewBag.Message = "Список шифрованных символов";

            var data = SymbolProcessor.LoadSymbols();
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
                SymbolProcessor.CreateSymbol(sModel.oldSymbol, sModel.newSymbol);
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