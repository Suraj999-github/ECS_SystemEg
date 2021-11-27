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
<<<<<<< HEAD
=======
           // var returndetail = JsonConvert.DeserializeObject<NeaPaymentDetail>(rcommom);
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
            try
            {
                var c = new SqlConnection(configuration.GetConnectionString("ConnectionString:DefaultConnection"));
                var sql = "EXEC SP_Payment ";
                sql += "@Flag = " + "'insert'";              
                sql += ",@RequestedData = " + filter.FilterString(rcommom);
<<<<<<< HEAD
                using (var connection = new SqlConnection(configuration["ConnectionString:DefaultConnection"]))
                {                   
                    connection.Open();
                    var result = connection.Query<Result>(sql).ToArray();
                    response.Result = result[0];                   
                    connection.Close();
                }
                return response;               
=======

                using (var connection = new SqlConnection(configuration["ConnectionString:DefaultConnection"]))
                {
                    //connection.ConnectionString = "Data Source=DESKTOP-LN59I96;Initial Catalog=ECSSystem;Persist Security Info=True;User ID=sa;Password=MeroUat@321";
                    connection.Open();
                    var result = connection.Query<Result>(sql).ToArray();
                    response.Result = result[0];
                    //var res = new DbResponse(
                    //res.ErrorCode = result[0].ErrorCode;
                    //res.Id = result[0].Id;
                    //res.Message = result[0].Message;
                    //response. = res;
                    connection.Close();
                }
                return response;

               
>>>>>>> f78e806823a4e05f69278089bff51f228ccb9966
            }
            catch (Exception ex)
            {
                return response;
            }

        }
    }
}
