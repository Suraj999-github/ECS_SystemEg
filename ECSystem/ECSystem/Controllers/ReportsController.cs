using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECSystem.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult ProfitLossReport()
        {
            return View();
        }
        public IActionResult OrderHistoryReport()
        {
            return View();
        }
    }
}
