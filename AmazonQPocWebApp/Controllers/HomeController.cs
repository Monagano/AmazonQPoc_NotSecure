using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmazonQPocWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            AmazonQPocClassLib.OldClass oldClass = new AmazonQPocClassLib.OldClass();

            SqlCommand cmd = new SqlCommand(); // 修正対象

            VBCodeProvider provider = new VBCodeProvider();

            VbStrConv vbsc = VbStrConv.Narrow;
            Console.WriteLine(vbsc);
            return View();
        }
    }
}
