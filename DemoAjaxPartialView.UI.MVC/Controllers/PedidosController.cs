using DemoAjaxPartialView.UI.MVC.Contexto;
using DemoAjaxPartialView.UI.MVC.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace DemoAjaxPartialView.UI.MVC.Controllers
{
    public class PedidosController : Controller
    {
        // GET: Pedidos
        DataContexto db = new DataContexto();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RegistrarPedidos()
        {
           return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegistrarPedidos(Pedidos model)
        {
            if (ModelState.IsValid)
            {
                model.Data = DateTime.Now;
                db.Pedidos.Add(model);
                db.SaveChanges();
            }
           
            return Json(new { Resultado = model.Id },JsonRequestBehavior.AllowGet);
        }
        public JsonResult ListarPedidos(int Id)
        {
            var listar = db.Pedidos.ToList();
            var contar = db.Pedidos.Count();
            ViewBag.Total = contar;
            return Json(contar, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ListaDados(int Id)
        {
            var listar = db.Pedidos.Where(p=>p.Id == Id);
            ViewBag.Pedido = Id;
            return PartialView(listar);
        }
    }
}