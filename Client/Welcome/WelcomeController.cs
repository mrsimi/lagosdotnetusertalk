using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using lagosdotnetusertalk.Server.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace lagosdotnetusertalk.Client.Welcome
{
    public class WelcomeController : Controller
    {
        private readonly ILogger<WelcomeController> _logger;

        public WelcomeController(ILogger<WelcomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var response = WelcomeService.ReturnMessage();   
            return View("Index", response);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}