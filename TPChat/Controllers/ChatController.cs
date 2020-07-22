using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPChat.DataBase;
using TPChat.Models;

namespace TPChat.Controllers
{

    
    public class ChatController : Controller
    {
                
           // GET: Chat
        public ActionResult Index()
        {
                       
            return View(FakeDBCat.Instance.Chats);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            var chat = FakeDBCat.Instance.Chats.FirstOrDefault(c=>c.Id == id);
            if (chat == null)
            {
                return RedirectToAction("Index");
            }
            return View(chat);
        }

        // GET: Chat/Create
        

        // POST: Chat/Create
        

        // GET: Chat/Edit/5
       

        // POST: Chat/Edit/5
        

        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            var chat = FakeDBCat.Instance.Chats.FirstOrDefault(c => c.Id == id);
            if (chat == null)
            {
                return RedirectToAction("Index");
            }
            return View(chat);
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var chat = FakeDBCat.Instance.Chats.FirstOrDefault(c => c.Id == id);
                FakeDBCat.Instance.Chats.Remove(chat);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction ("Delete",id);
            }
        }
    }
}
