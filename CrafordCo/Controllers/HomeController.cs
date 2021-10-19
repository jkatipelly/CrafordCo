using CrafordCo.Biz.Interfaces;
using CrafordCo.Data;
using CrafordCo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CrafordCo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILossType _lossTypeBiz;

        public HomeController(ILogger<HomeController> logger, ILossType lossTypeBiz)
        {
            _logger = logger;
            _lossTypeBiz = lossTypeBiz;
        }

        public IActionResult Index()
        {          

            var lossTypes = _lossTypeBiz.GetLossTypes().ToModels();            

            if (lossTypes.Any())
            {              
                ViewData["LossTypes"] = lossTypes;
            }
            else
            {
                RedirectToAction("Error");
            }           

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
