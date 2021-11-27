using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class SqlHandler
    {
        private readonly IConfiguration configuration;
        public SqlHandler(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public DataSet ExecuteDataset(string sql)
        {
            var ds = new DataSet();
            using (var con = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                var cmd = new SqlCommand(sql, con);                
                SqlDataAdapter da;
                try
                {
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    da.Dispose();
                }

                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    da = null;
                    cmd.Dispose();
                }
                return ds;
            }
        }
        public DataTable ExecuteDataTable(string sql)
        {
            using (var ds = ExecuteDataset(sql))
            {
                if (ds == null || ds.Tables.Count == 0)
                    return null;
                if (ds.Tables[0].Rows.Count == 0)
                    return null;
                return ds.Tables[0];
            }
        }
     
        public Result ParseDbResponse(string sql)
        {
            return ParseDbResponse(ExecuteDataTable(sql));
        }
        public Result ParseDbResponse(DataTable dt)
        {
            var res = new Result();
            if (dt != null && dt.Rows.Count > 0)
            {
                res.Status = Convert.ToInt32(dt.Rows[0][0].ToString());
                res.Type = dt.Rows[0][1].ToString();
                res.Detail = dt.Rows[0][3].ToString();
                if (dt.Columns.Count > 3)
                    res.Id = dt.Rows[0][2].ToString();
                if (dt.Columns.Count > 3)
                {
                    res.Extra = dt.Rows[0][3].ToString();
                }
            }
            return res;
        }
    }
}
