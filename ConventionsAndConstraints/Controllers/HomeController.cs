using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConventionsAndConstraints.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConventionsAndConstraints.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View("Result", new Result { Controller = nameof(HomeController), Action = nameof(Index) });
        public IActionResult List() => View("Result", new Result { Controller = nameof(HomeController), Action = nameof(List) });
    }
}
