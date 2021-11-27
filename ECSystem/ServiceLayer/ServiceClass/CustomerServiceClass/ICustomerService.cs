using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ServiceClass.CustomerServiceClass
{
   public interface ICustomerService
    {
        ResponseCommon Request(RequestCommon req);
    }
}
