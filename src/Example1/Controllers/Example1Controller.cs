using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.DataAnnotations.Internal;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Example1.Controllers
{
    public class Example1Controller : Controller
    {
        // GET: /<controller>/
        public IActionResult Example1()
        {
            return View();
        }


        [HttpPost]
        public IActionResult ValidatePerson(SimplePerson person)
        {
            if (!ModelState.IsValid)
            {
                return View("Example1");
            }
            
            return View("PersonAdded", person);
            
        }

       
    }
}
