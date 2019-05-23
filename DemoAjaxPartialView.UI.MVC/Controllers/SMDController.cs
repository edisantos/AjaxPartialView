using DemoAjaxPartialView.UI.MVC.Contexto;
using DemoAjaxPartialView.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DemoAjaxPartialView.UI.MVC.Controllers
{
    public class SMDController : Controller
    {
        // GET: SMD
        DataContexto db = new DataContexto();
        public ActionResult Index()
        {
            var result = db.Wlan.ToList();
           
            return View(result);
        }
      
        public ActionResult Register()
        {
           

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Wlan model)
        {
            
            
              

                if (!Request.IsAjaxRequest())
                {
                    Response.StatusCode = (int)System.Net.HttpStatusCode.BadRequest;
                    return Content("Sorry, this method can't be called only from AJAX.");
                }
                try
                {
                    if (ModelState.IsValid)
                    {
                        model.Data = DateTime.Now;
                        db.Wlan.Add(model);
                        db.SaveChanges();
                        return Content("Registro feito com sucesso !");
                    }
                    else
                    {
                    StringBuilder strB = new StringBuilder(500);
                    foreach (ModelState modelState in ModelState.Values)
                    {
                        foreach (ModelError error in modelState.Errors)
                        {
                            strB.Append(error.ErrorMessage + ".");
                        }
                    }
                    Response.StatusCode = (int)System.Net.HttpStatusCode.BadRequest;
                    return Content(strB.ToString());
                }
                }
                catch (Exception ex)
                {

                    Response.StatusCode = (int)System.Net.HttpStatusCode.BadRequest;
                    return Content("Sorry, an error occured." + ex.Message);
                }
            
            
           
        }
        public PartialViewResult ListarDados()
        {
            var result = db.Wlan;
            return PartialView("_ListaPartialView", result.ToList());
        }

       
        public PartialViewResult GetMagazine()
        {
           
            var res = db.Wlan.ToList();
            return PartialView(res);
        }

        public PartialViewResult ListaMagazine()
        {

            var res = db.Wlan.ToList();
            return PartialView(res);
        }

    }
}