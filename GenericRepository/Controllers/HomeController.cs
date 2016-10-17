using GenericRepository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenericRepository.Controllers
{
    public class HomeController : Controller
    {
        protected readonly IGenericRepository repo;


        public HomeController()
        {
            this.repo = new GenericRepository<NORTHWNDEntities>(new NORTHWNDEntities());
        }

        public ActionResult Index()
        {            
            return View();
        }
    }
}