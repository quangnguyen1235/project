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
        // nghe anh nói k k nghe chi hết nghe e nói k, nghe rè rè e có nói mô mà  nghe
    }
}
// chừ đụng đi hifiiiiii fiiiiiiii mô rồi