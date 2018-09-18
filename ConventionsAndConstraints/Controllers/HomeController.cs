using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConventionsAndConstraints.Infrastructure;
using ConventionsAndConstraints.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConventionsAndConstraints.Controllers
{
    //[AdditionalActions]
    public class HomeController : Controller
    {
        public IActionResult Index() => View("Result", new Result { Controller = nameof(HomeController), Action = nameof(Index) });

        // [ActionName("Details")]
        // [ActionNamePrefix("Do")]
        // [AddAction("Details")]
        [UserAgent("Edge")]
        public IActionResult List() => View("Result", new Result { Controller = nameof(HomeController), Action = nameof(List) });

        [ActionName("Index")]
        [UserAgent("Edge")]
        public IActionResult Other() => View("Result", new Result { Controller = nameof(HomeController), Action = nameof(Other) });
    }
}
