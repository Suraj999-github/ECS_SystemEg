using ECSystem.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using ServiceLayer.ServiceClass.PaymentServiceClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECSystem.Controllers
{
    public class PaymentController : Controller
    {
        private IPaymentService _service;
        public PaymentController(IPaymentService service)
        {
            _service = service;
        }
        public IActionResult Payment(PaymentModel model)
        {
            try
            {
                RequestCommon objReq = new RequestCommon();
                objReq.RequestedData = model;          
                objReq.RequestedMethod = RequestType.Insert;               
                var response = _service.Request(objReq);
                return Json(response);
            }
            catch (Exception p)
            {
                return RedirectToAction("Index", "Home");
            }           
        }
    }
}
