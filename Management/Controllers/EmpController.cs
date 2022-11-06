using Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace Management.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SaveEmp(EmpModel model)
        {
            try
            {
                
               return Json(new { model = (new EmpModel().SaveEmp(model)) },JsonRequestBehavior.AllowGet);

            }
            catch(Exception ex)
            {
                return Json(new { model = ex.Message }, JsonRequestBehavior.AllowGet);


            }
        }
    }
}