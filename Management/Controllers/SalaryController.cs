using Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Management.Controllers
{
    public class SalaryController : Controller
    {
        // GET: Salary
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SaveSalary(SalaryModel model)
        {
            try
            {
                return Json(new { model = (new SalaryModel().SaveSalary(model)) }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                return Json(new { message = ex.ToString() }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult GetSalaryList()
        {
            try
            {
                return Json(new { model = new SalaryModel().GetSalaryList() }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { model = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}