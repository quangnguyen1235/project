using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement1.Controllers
{
    public class ErrorController : Controller
    {
        [Microsoft.AspNetCore.Mvc.Route("Error")]
        public ViewResult Error()
        {
            return View("Exception");
        }
    }
}
