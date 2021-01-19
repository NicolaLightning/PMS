using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Web.Host.Controller
{
    public class HomeController : PMSControllerBase
    {
        public IActionResult Index()
        {
            return Redirect("/swagger/index.html");
        }
    }
}
