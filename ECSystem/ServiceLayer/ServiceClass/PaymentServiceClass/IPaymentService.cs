using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ServiceClass.PaymentServiceClass
{
   public interface IPaymentService
    {
        ResponseCommon Request(RequestCommon req);
    }
}
