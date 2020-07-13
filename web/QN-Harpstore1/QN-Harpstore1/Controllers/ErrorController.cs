using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Controllers
{
    public class ErrorController:Controller
    {
        [Route("Error")]
        public ViewResult Error()
        {
            return View("Exception");
        }
    }
}
