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
        protected readonly IRepository repo;


        public HomeController()
        {
            this.repo = new EntityFrameworkRepository<NORTHWNDEntities>(new NORTHWNDEntities());
        }

        public ActionResult Index()
        {            
            return View();
        }
    }
}