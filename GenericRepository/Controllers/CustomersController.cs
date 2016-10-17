using GenericRepository.Data;
using GenericRepository.Models;
using GenericRepository.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace GenericRepository.Controllers
{
    /// <summary>
    /// No Service Layer
    /// </summary>
    public class CustomersController : Controller
    {
        private readonly CustomersService _customerService;


        public CustomersController()
        {
            _customerService = new CustomersService();
        }

        // GET: Customers
        public ActionResult Index()
        {
            List<CustomerModel> customers = _customerService.GetCustomers()
                .Select(s => new CustomerModel
                {
                    Address = s.Address,
                    City = s.City,
                    CompanyName = s.CompanyName,
                    ContactName = s.ContactName,
                    ContactTitle = s.ContactTitle,
                    Country = s.Country,
                    CustomerID = s.CustomerID,
                    Fax = s.Fax,
                    Phone = s.Phone,
                    PostalCode = s.PostalCode,
                    Region = s.Region                
                })
                .ToList();

            return View(customers);
        }

        public ActionResult Create()
        {
            return View();
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<ActionResult> Create(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                await _customerService.CreateAsync(model.ToEntity());

                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}