using CurrencyExchange.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using CurrencyExchange.Core.Model;
using CurrencyExchange.Core.Service;

namespace CurrencyExchange.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICurrencyService _currencyService;
        private readonly ICalculatorService _calculatorService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ICurrencyService currencyService,
            ICalculatorService calculatorService)
        {
            _currencyService = currencyService;
            _calculatorService = calculatorService;
            _logger = logger;
        }

        public IActionResult Index(OutputCurrencyDto outputCurrencyDto)
        {
            outputCurrencyDto = _calculatorService.CalculateName(outputCurrencyDto);

            outputCurrencyDto.ComboBoxItems = _currencyService.getallCodes();
            return View(outputCurrencyDto);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}