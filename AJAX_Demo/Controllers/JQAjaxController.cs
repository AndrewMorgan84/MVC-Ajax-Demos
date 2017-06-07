using AJAX_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AJAX_Demo.Controllers
{
    public class JQAjaxController : Controller
    {
        // GET: JQAjax
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public string Index(string txtFirstNo, string txtSecondNo)
        //{
        //    var result = int.Parse(txtFirstNo) + int.Parse(txtSecondNo);
        //    return result.ToString();
        //}

        [HttpPost]
        public string Index(AjaxViewModel m)
        {
            var result = int.Parse(m.txtFirstNo) + int.Parse(m.txtSecondNo);
            return result.ToString();
        }
    }
}