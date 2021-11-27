using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public enum RequestType
    {
        Insert,
        Save,
        Update,
        Edit,
        PopulateById,
        RequestById,
        ValidateById,
        SaveLog,
        UpdateLog,
        UserDefined,
        AuthenticateUser,
        TokenValidate,
        ErrorHandling,
        List,
        Populate,
    }
    public class RequestCommon
    {
        public RequestType RequestedMethod { get; set; }
        public string RequestedBy { get; set; }
        public string RequestedId { get; set; }
        public string RequestedIp { get; set; }
        public string Flag { get; set; }
        public string Username { get; set; }
        public string ActionName { get; set; }
        public string SearchData { get; set; }
        public string PageSize { get; set; }
        public string XmlData { get; set; }
        public string MacAddress { get; set; }
        public object ResponseData { get; set; }
        public object RequestedData { get; set; }
        public string RequestedUrl { get; set; }
        public string Token { get; set; }
        public string RequestMedium { get; set; }
        public string Environment { get; set; }
        public decimal Amount { get;  set; }
    }
}
