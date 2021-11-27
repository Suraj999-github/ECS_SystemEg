using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
   public  class Result
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public string Detail { get; set; }
        public string Instance { get; set; }
        public string Id { get; set; }
        public string Extra { get; set; }
        public Object Errors { get; set; }
        public Object Response { get; set; }
     
    }
}
