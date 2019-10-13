using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class CreatePersonController : Controller
    {
        // GET: CreatePerson
        public ActionResult Index()
        {
            return View();
        }
    }
}