using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class Filter
    {
        public String FilterString(string strVal, string defaultValue = "")
        {
            if (String.IsNullOrEmpty(strVal))
                strVal = defaultValue;
            var str = FilterQuote(strVal);

            if (str.ToLower() != "null")
                str = "'" + str + "'";
            return str.TrimEnd().TrimStart();
        }
        public string FilterQuote(string strVal)
        {
            if (string.IsNullOrEmpty(strVal))
            {
                strVal = "";
            }
            var str = strVal.Trim();

            if (!string.IsNullOrEmpty(str))
            {
                str = str.Replace(";", "");
                str = str.Replace("--", "");
                str = str.Replace("'", "");

                str = str.Replace("/*", "");
                str = str.Replace("*/", "");

                str = Regex.Replace(str, " select ", string.Empty, RegexOptions.IgnoreCase);
                str = Regex.Replace(str, " insert ", string.Empty, RegexOptions.IgnoreCase);
                str = Regex.Replace(str, " update ", string.Empty, RegexOptions.IgnoreCase);
                str = Regex.Replace(str, " delete ", string.Empty, RegexOptions.IgnoreCase);
                str = Regex.Replace(str, " drop ", string.Empty, RegexOptions.IgnoreCase);
                str = Regex.Replace(str, " truncate ", string.Empty, RegexOptions.IgnoreCase);
                str = Regex.Replace(str, " create ", string.Empty, RegexOptions.IgnoreCase);
                str = Regex.Replace(str, " begin ", string.Empty, RegexOptions.IgnoreCase);
                str = Regex.Replace(str, " end ", string.Empty, RegexOptions.IgnoreCase);
                str = Regex.Replace(str, " char ", string.Empty, RegexOptions.IgnoreCase);
                str = Regex.Replace(str, " exec ", string.Empty, RegexOptions.IgnoreCase);
                str = Regex.Replace(str, " xp_cmd ", string.Empty, RegexOptions.IgnoreCase);

                str = Regex.Replace(str, @"<.*?>", string.Empty);
            }
            else
            {
                str = "null";
            }
            return str;
        }
    }
}
