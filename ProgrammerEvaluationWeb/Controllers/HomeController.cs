using Microsoft.AspNetCore.Mvc;
using ProgrammerEvaluationWeb.Models;
using ProgrammerEvaluationWeb.Services;
using System.Diagnostics;

namespace ProgrammerEvaluationWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        }

        public IActionResult Index()
        {
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

        [HttpPost]
        public IActionResult Order(string numbers)
        {
            try
            {
                if (numbers != null)
                {
                    var _numbers = numbers.Split(',').Select(n => int.Parse(n)).ToArray();
                    var result = OrdenatorService.Order(_numbers);
                    ViewBag.Numbers = result;

                }
            }
            catch (Exception exception)
            {

            }
            return View();
        }

        [HttpGet]
        public IActionResult Json()
        {
            var list = clsTesteService.CreateClsTesteList();
            FileService.CreateJsonFile(list);
            var viewModel = FileService.ReadJsonFile();
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Bank()
        {
            var list = ApiService.GetBankApi();
            return View(list);
        }
    }
}