using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Project.Models;

namespace Project.Controllers
{
    public class OpendataViewController : Controller
    {
        // GET: OpendataView
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LocationIndex()
        {
            return View();
        }
    }
}