using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ServiceClass.CustomerServiceClass
{
    public class CustomerService : ICustomerService
    {
        ResponseCommon response;
        SqlHandler handler;
        public CustomerService()
        {
            //handler = new SqlHandler();
            response = new ResponseCommon();
        }
        public ResponseCommon Request(RequestCommon req)
        {
            switch (req.RequestedMethod)
            {
                case RequestType.Insert:
                   response = InsertCustomer(req);
                    break;               
              
                default:
                    var result = new Result();
                    result.Status = 1;
                    result.Type = "error";
                    result.Detail = "No such request is found !";
                    response.Result = result;
                    break;
            }
            return response;
        }
        public ResponseCommon InsertCustomer(RequestCommon req)
        {            
            try
            {
                var sql = "EXEC spaUserDetail ";              
                var dbresposnse = handler.ParseDbResponse(sql);
                response.Result = dbresposnse;
                return response;               
            }
            catch (Exception ex)
            {
                return response;
            }

        }

    }

  }
