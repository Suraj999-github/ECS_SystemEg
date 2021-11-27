using Dapper;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ServiceClass.PaymentServiceClass
{
    public class PaymentService: IPaymentService
    {
        ResponseCommon response;
        Filter filter;
        private readonly IConfiguration configuration;
        public PaymentService(IConfiguration _configuration)
        {
            filter = new Filter();
            configuration = _configuration;
            response = new ResponseCommon();
        }
        public ResponseCommon Request(RequestCommon req)
        {
            switch (req.RequestedMethod)
            {
                case RequestType.Insert:
                    response = InsertPayment(req);
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
        public ResponseCommon InsertPayment(RequestCommon req)
        {
            var rcommom = JsonConvert.SerializeObject(req.RequestedData);
            try
            {
                var c = new SqlConnection(configuration.GetConnectionString("ConnectionString:DefaultConnection"));
                var sql = "EXEC SP_Payment ";
                sql += "@Flag = " + "'insert'";              
                sql += ",@RequestedData = " + filter.FilterString(rcommom);
                using (var connection = new SqlConnection(configuration["ConnectionString:DefaultConnection"]))
                {                   
                    connection.Open();
                    var result = connection.Query<Result>(sql).ToArray();
                    response.Result = result[0];                   
                    connection.Close();
                }
                return response;               
            }
            catch (Exception ex)
            {
                return response;
            }

        }
    }
}
