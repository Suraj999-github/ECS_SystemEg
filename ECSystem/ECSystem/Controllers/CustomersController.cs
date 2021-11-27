using ECSystem.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ServiceClass.CustomerServiceClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECSystem.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerService _service;      
        public CustomersController(ICustomerService service)
        {
            _service = service;                         
        }
        public IActionResult AddCompany()
        {
            InsertCompanyCustomerModel model = new InsertCompanyCustomerModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCompany(InsertCompanyCustomerModel model)
        {
            if (ModelState.IsValid)
            {
            }
            else
            {

            }
                return View(model);
        }
<<<<<<< HEAD
        public IActionResult CorporateList()
        {
            return View();
        }
        public IActionResult HomeOffice()
        {
            return View();
        }
        public IActionResult HomeOfficeList()
        {
            return View();
        }

        
             public IActionResult Students()
        {
            return View();
        }
        public IActionResult StudentsList()
        {
            return View();
        }
=======
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
        public IActionResult Index()
        {
            return View();
        }
    }
}
